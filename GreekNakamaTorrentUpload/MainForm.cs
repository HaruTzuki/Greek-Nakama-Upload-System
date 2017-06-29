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

        //Simple Vars
        string WebImageFolder;

        public MainForm()
        {
            InitializeComponent();
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
            WebImageFolder = Helper.LoadFromJson();
            if (WebImageFolder == "0x01")
            {
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
    }
}
