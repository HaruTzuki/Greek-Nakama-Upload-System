using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using GreekNakamaTorrentUpload.WinClass;
using System.Data.Odbc;
using GreekNakamaTorrentUpload.WinClass.Helper;
using GreekNakamaTorrentUpload.WinForms.Settings;

namespace GreekNakamaTorrentUpload
{
    public partial class MainForm : Form
    {
        List<AnimeList> _animeList;
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader reader;
        Credentials _cred;
        Upload _upload;

        //Simple Vars
        string WebImageFolder;
        string _ftpUsername;
        string _ftpPassword;
        string _ftpPath;
        //---
        string _uploadDate;

        public MainForm()
        {
            InitializeComponent();
            _cred = new Credentials();
            _animeList = new List<AnimeList>();
            DB.InitializeCredetials();
            txt_CurrentCred.Text = DB.PrintCredetials();
            DB.Connect();

            if (DB.Cn.State == ConnectionState.Open)
            {
                this.Text = "Greek-Nakama Torrent Upload - Connected";
            }
            else
            {
                this.Text = "Greek-Nakama Torrent Upload - Disconnected";
            }

            cmd.Connection = DB.Cn;
            Init();
        }

        private void Init()
        {
            try
            {
                _cred = Helper.LoadFromJson();
                WebImageFolder = _cred.WebImageFolder;
                _ftpPath = _cred.FTPServer;
                _ftpUsername = _cred.FTPUsername;
                _ftpPassword = _cred.FTPPassword;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                MessageBox.Show("We can't find the settings file.\nPlease set your settings before use the app.", "Error while load file...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                frmSettings frmSettings = new frmSettings();
                frmSettings.ShowDialog();
            }

            fillList();
            loadComboBox(cbx_AnimeList);
        }



        private void fillList()
        {
            AnimeList _anime;
            try
            {
                cmd.CommandText = Queries.LoadComboBox();
                reader = cmd.ExecuteReader();
                _animeList.Clear();
                while (reader.Read())
                {
                    _anime = new AnimeList(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString());
                    _animeList.Add(_anime);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("We can't load the list. Please restart the program. If problem exist. Please contact with Administrator: support@greek-nakama.com", "Can't load list...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader?.Close();
        }

        private void loadComboBox(ComboBox cbx_AnimeList)
        {
            cbx_AnimeList.BeginUpdate();
            cbx_AnimeList.DataSource = null;
            cbx_AnimeList.DataSource = _animeList;
            cbx_AnimeList.ValueMember = "AnimeSlug";
            cbx_AnimeList.DisplayMember = "AnimeName";
            cbx_AnimeList.EndUpdate();
        }

        private void cbx_AnimeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_originalname.Text = _animeList[cbx_AnimeList.SelectedIndex].AnimeName;
            lbl_slug.Text = _animeList[cbx_AnimeList.SelectedIndex].AnimeSlug;
        }

        private void brn_browse_Click(object sender, EventArgs e)
        {
            Helper.BrowseFiles(this.txt_torrentFile, this.lbl_selectedTorrentName);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();
            frmSettings.ShowDialog();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            if (chb_today.Checked)
            {
                _uploadDate = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                _uploadDate = dtp_uploadDate.Value.ToString("yyyy-MM-dd");
            }

            try
            {

                _upload = new Upload(_ftpUsername, _ftpPassword, _ftpPath);
                _upload.StartUploading(txt_torrentFile.Text, lbl_selectedTorrentName.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Something goes wrong. Please check the file or you Credentials or Internet Connection.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            cmd.CommandText = Queries.InsertToDatabase(txt_name.Text, @"http://greek-nakama.com/blog/torrents/files/" + lbl_selectedTorrentName.Text, WebImageFolder + "" + lbl_slug.Text + ".png", _uploadDate);
            cmd.ExecuteNonQuery();

            MessageBox.Show("You have succefull complete the Operation.", "Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chb_today_CheckedChanged(object sender, EventArgs e)
        {
            dtp_uploadDate.Enabled = !dtp_uploadDate.Enabled;
        }
    }
}
