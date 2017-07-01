using GreekNakamaTorrentUpload.WinClass.Helper;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GreekNakamaTorrentUpload.WinForms.Settings
{
    public partial class frmSettings : Form
    {
        Credentials _cred;
        Timer checkIfProcessExited;
        Process p;


        public frmSettings()
        {
            InitializeComponent();
            _cred = new Credentials();
            checkIfProcessExited = new Timer();
            checkIfProcessExited.Interval = 100; //100 ms
            checkIfProcessExited.Tick += CheckIfProcessExited_Tick;
            checkIfProcessExited.Stop();
            p = new Process();

        }

        private void CheckIfProcessExited_Tick(object sender, EventArgs e)
        {
            var HasExited = p.HasExited;
            if (HasExited)
            {
                checkIfProcessExited.Stop();
                MessageBox.Show("You must restart the program.", "Restart...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void btn_openCred_Click(object sender, EventArgs e)
        {
            DialogResult DL = MessageBox.Show("If you open file. After this you must do restart.\nDo you want to open it?", "Open Credentials...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (DL == DialogResult.OK)
            {
                p.StartInfo.Arguments = "config.txt";
                p.StartInfo.FileName = "notepad.exe";
                p.Start();
                checkIfProcessExited.Start();
            }
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (File.Exists("settings.json"))
            {
                File.Delete("settings.json");
            }

            _cred.WebImageFolder = text_webImageFolder.Text;
            _cred.FTPServer = txtServer.Text;
            _cred.FTPUsername = txtUsername.Text;
            _cred.FTPPassword = txtPassword.Text;

            Helper.SaveToJson(_cred);
            MessageBox.Show("Settings has changed. We restart the Application. See you!", "Perfect...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (text_webImageFolder.Text == "")
            {
                MessageBox.Show("You don't fill the Web Image Folder Text Box. Please fill it.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                e.Cancel = true;
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            try
            {
                _cred = Helper.LoadFromJson();
                text_webImageFolder.Text = _cred.WebImageFolder;
                txtUsername.Text = _cred.FTPUsername;
                txtServer.Text = _cred.FTPServer;
                txtPassword.Text = _cred.FTPPassword;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }


        }
    }
}
