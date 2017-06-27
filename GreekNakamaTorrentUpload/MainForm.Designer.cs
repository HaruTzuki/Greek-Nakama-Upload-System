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
            this.cbx_AnimeList = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_originalname = new System.Windows.Forms.Label();
            this.lbl_slug = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CurrentCred = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_AnimeList
            // 
            this.cbx_AnimeList.FormattingEnabled = true;
            this.cbx_AnimeList.Location = new System.Drawing.Point(6, 19);
            this.cbx_AnimeList.Name = "cbx_AnimeList";
            this.cbx_AnimeList.Size = new System.Drawing.Size(236, 21);
            this.cbx_AnimeList.TabIndex = 0;
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
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anime List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Original Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Slug:";
            // 
            // lbl_originalname
            // 
            this.lbl_originalname.AutoSize = true;
            this.lbl_originalname.Location = new System.Drawing.Point(88, 43);
            this.lbl_originalname.Name = "lbl_originalname";
            this.lbl_originalname.Size = new System.Drawing.Size(80, 13);
            this.lbl_originalname.TabIndex = 3;
            this.lbl_originalname.Text = "%original_name";
            // 
            // lbl_slug
            // 
            this.lbl_slug.AutoSize = true;
            this.lbl_slug.Location = new System.Drawing.Point(48, 69);
            this.lbl_slug.Name = "lbl_slug";
            this.lbl_slug.Size = new System.Drawing.Size(34, 13);
            this.lbl_slug.TabIndex = 4;
            this.lbl_slug.Text = "%slug";
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 477);
            this.Controls.Add(this.txt_CurrentCred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

