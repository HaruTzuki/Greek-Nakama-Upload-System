namespace GreekNakamaTorrentUpload
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbx_AnimeList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_slug = new System.Windows.Forms.Label();
            this.lbl_originalname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CurrentCred = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_torrent = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_selectedTorrentName = new System.Windows.Forms.Label();
            this.brn_browse = new System.Windows.Forms.Button();
            this.txt_torrentFile = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.TipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_AnimeList
            // 
            this.cbx_AnimeList.FormattingEnabled = true;
            this.cbx_AnimeList.Location = new System.Drawing.Point(6, 19);
            this.cbx_AnimeList.Name = "cbx_AnimeList";
            this.cbx_AnimeList.Size = new System.Drawing.Size(236, 21);
            this.cbx_AnimeList.TabIndex = 0;
            this.TipHelp.SetToolTip(this.cbx_AnimeList, "List of available anime.");
            this.cbx_AnimeList.SelectedIndexChanged += new System.EventHandler(this.cbx_AnimeList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_slug);
            this.groupBox1.Controls.Add(this.lbl_originalname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_AnimeList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anime List";
            // 
            // lbl_slug
            // 
            this.lbl_slug.AutoSize = true;
            this.lbl_slug.Location = new System.Drawing.Point(48, 69);
            this.lbl_slug.Name = "lbl_slug";
            this.lbl_slug.Size = new System.Drawing.Size(34, 13);
            this.lbl_slug.TabIndex = 4;
            this.lbl_slug.Text = "%slug";
            this.TipHelp.SetToolTip(this.lbl_slug, "Slug name of anime.");
            // 
            // lbl_originalname
            // 
            this.lbl_originalname.AutoSize = true;
            this.lbl_originalname.Location = new System.Drawing.Point(88, 43);
            this.lbl_originalname.Name = "lbl_originalname";
            this.lbl_originalname.Size = new System.Drawing.Size(80, 13);
            this.lbl_originalname.TabIndex = 3;
            this.lbl_originalname.Text = "%original_name";
            this.TipHelp.SetToolTip(this.lbl_originalname, "Original name of the Anime.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Slug:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Credetials:";
            // 
            // txt_CurrentCred
            // 
            this.txt_CurrentCred.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_CurrentCred.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txt_CurrentCred.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_CurrentCred.Location = new System.Drawing.Point(580, 12);
            this.txt_CurrentCred.Multiline = true;
            this.txt_CurrentCred.Name = "txt_CurrentCred";
            this.txt_CurrentCred.ReadOnly = true;
            this.txt_CurrentCred.Size = new System.Drawing.Size(203, 82);
            this.txt_CurrentCred.TabIndex = 3;
            this.TipHelp.SetToolTip(this.txt_CurrentCred, "Current Credentials for Connections.");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_torrent);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.lbl_name);
            this.groupBox2.Controls.Add(this.lbl_selectedTorrentName);
            this.groupBox2.Controls.Add(this.brn_browse);
            this.groupBox2.Controls.Add(this.txt_torrentFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 157);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browse Torrent File && Name:";
            // 
            // lbl_torrent
            // 
            this.lbl_torrent.AutoSize = true;
            this.lbl_torrent.Location = new System.Drawing.Point(3, 71);
            this.lbl_torrent.Name = "lbl_torrent";
            this.lbl_torrent.Size = new System.Drawing.Size(44, 13);
            this.lbl_torrent.TabIndex = 5;
            this.lbl_torrent.Text = "Torrent:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(6, 32);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(451, 20);
            this.txt_name.TabIndex = 1;
            this.TipHelp.SetToolTip(this.txt_name, "The name that will appear on the page.");
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_selectedTorrentName
            // 
            this.lbl_selectedTorrentName.AutoSize = true;
            this.lbl_selectedTorrentName.Location = new System.Drawing.Point(6, 136);
            this.lbl_selectedTorrentName.Name = "lbl_selectedTorrentName";
            this.lbl_selectedTorrentName.Size = new System.Drawing.Size(57, 13);
            this.lbl_selectedTorrentName.TabIndex = 2;
            this.lbl_selectedTorrentName.Text = "File Name:";
            this.TipHelp.SetToolTip(this.lbl_selectedTorrentName, "Torrent file name.");
            // 
            // brn_browse
            // 
            this.brn_browse.Location = new System.Drawing.Point(382, 113);
            this.brn_browse.Name = "brn_browse";
            this.brn_browse.Size = new System.Drawing.Size(75, 23);
            this.brn_browse.TabIndex = 3;
            this.brn_browse.Text = "Browse...";
            this.TipHelp.SetToolTip(this.brn_browse, "Browse the files to find torrent.");
            this.brn_browse.UseVisualStyleBackColor = true;
            this.brn_browse.Click += new System.EventHandler(this.brn_browse_Click);
            // 
            // txt_torrentFile
            // 
            this.txt_torrentFile.Location = new System.Drawing.Point(6, 87);
            this.txt_torrentFile.Name = "txt_torrentFile";
            this.txt_torrentFile.Size = new System.Drawing.Size(451, 20);
            this.txt_torrentFile.TabIndex = 2;
            this.TipHelp.SetToolTip(this.txt_torrentFile, "The uploaded torrent file.");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_upload);
            this.groupBox3.Location = new System.Drawing.Point(484, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(299, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Upload";
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(108, 25);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(92, 52);
            this.btn_upload.TabIndex = 4;
            this.btn_upload.Text = "Upload";
            this.TipHelp.SetToolTip(this.btn_upload, "Upload the current torrent");
            this.btn_upload.UseVisualStyleBackColor = true;
            // 
            // btn_help
            // 
            this.btn_help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_help.Location = new System.Drawing.Point(685, 231);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(46, 44);
            this.btn_help.TabIndex = 5;
            this.TipHelp.SetToolTip(this.btn_help, "Help for program");
            this.btn_help.UseVisualStyleBackColor = true;
            // 
            // btn_settings
            // 
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.Location = new System.Drawing.Point(737, 231);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(46, 44);
            this.btn_settings.TabIndex = 6;
            this.TipHelp.SetToolTip(this.btn_settings, "Settings");
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 296);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_CurrentCred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Upload System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_AnimeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_slug;
        private System.Windows.Forms.Label lbl_originalname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CurrentCred;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_torrent;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_selectedTorrentName;
        private System.Windows.Forms.Button brn_browse;
        private System.Windows.Forms.TextBox txt_torrentFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.ToolTip TipHelp;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_help;
    }
}

