using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GreekNakamaTorrentUpload.WinClass;
using System.Data.Odbc;

namespace GreekNakamaTorrentUpload
{
    public partial class MainForm : Form
    {
        List<AnimeList> _animeList;
        OdbcCommand cmd = new OdbcCommand();
        OdbcDataReader reader;
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
                MessageBox.Show("Can't load the list");
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
    }
}
