using GreekNakamaTorrentUpload.WinClass.Helper;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GreekNakamaTorrentUpload.WinForms.Settings
{
    public partial class frmSettings : Form
    {
        string internetPath;
        Timer checkIfProcessExited;
        Process p;


        public frmSettings()
        {
            InitializeComponent();
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
            internetPath = text_webImageFolder.Text;
            Helper.SaveToJson(internetPath);
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
            internetPath = Helper.LoadFromJson();
            if (internetPath == "0x01") return;
            text_webImageFolder.Text = internetPath;

        }
    }
}
