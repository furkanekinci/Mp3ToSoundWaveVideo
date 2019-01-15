namespace Mp3ToSoundWaveVideo
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblMP3FilePath = new System.Windows.Forms.Label();
            this.txtMP3FilePath = new System.Windows.Forms.TextBox();
            this.btnMP3FileBrowse = new System.Windows.Forms.Button();
            this.lblExportPath = new System.Windows.Forms.Label();
            this.txtExportPath = new System.Windows.Forms.TextBox();
            this.btnBrowseExportPath = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cmbVideoResolution = new System.Windows.Forms.ComboBox();
            this.lblVideoResolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMP3FilePath
            // 
            this.lblMP3FilePath.AutoSize = true;
            this.lblMP3FilePath.Location = new System.Drawing.Point(12, 9);
            this.lblMP3FilePath.Name = "lblMP3FilePath";
            this.lblMP3FilePath.Size = new System.Drawing.Size(73, 13);
            this.lblMP3FilePath.TabIndex = 0;
            this.lblMP3FilePath.Text = "MP3 File Path";
            // 
            // txtMP3FilePath
            // 
            this.txtMP3FilePath.Location = new System.Drawing.Point(91, 6);
            this.txtMP3FilePath.Name = "txtMP3FilePath";
            this.txtMP3FilePath.Size = new System.Drawing.Size(479, 20);
            this.txtMP3FilePath.TabIndex = 0;
            // 
            // btnMP3FileBrowse
            // 
            this.btnMP3FileBrowse.Location = new System.Drawing.Point(576, 4);
            this.btnMP3FileBrowse.Name = "btnMP3FileBrowse";
            this.btnMP3FileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnMP3FileBrowse.TabIndex = 2;
            this.btnMP3FileBrowse.Text = "Browse";
            this.btnMP3FileBrowse.UseVisualStyleBackColor = true;
            this.btnMP3FileBrowse.Click += new System.EventHandler(this.btnMP3FileBrowse_Click);
            // 
            // lblExportPath
            // 
            this.lblExportPath.AutoSize = true;
            this.lblExportPath.Location = new System.Drawing.Point(12, 35);
            this.lblExportPath.Name = "lblExportPath";
            this.lblExportPath.Size = new System.Drawing.Size(62, 13);
            this.lblExportPath.TabIndex = 0;
            this.lblExportPath.Text = "Export Path";
            // 
            // txtExportPath
            // 
            this.txtExportPath.Location = new System.Drawing.Point(91, 32);
            this.txtExportPath.Name = "txtExportPath";
            this.txtExportPath.Size = new System.Drawing.Size(479, 20);
            this.txtExportPath.TabIndex = 1;
            // 
            // btnBrowseExportPath
            // 
            this.btnBrowseExportPath.Location = new System.Drawing.Point(576, 30);
            this.btnBrowseExportPath.Name = "btnBrowseExportPath";
            this.btnBrowseExportPath.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseExportPath.TabIndex = 3;
            this.btnBrowseExportPath.Text = "Browse";
            this.btnBrowseExportPath.UseVisualStyleBackColor = true;
            this.btnBrowseExportPath.Click += new System.EventHandler(this.btnBrowseExportPath_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(576, 59);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cmbVideoResolution
            // 
            this.cmbVideoResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoResolution.FormattingEnabled = true;
            this.cmbVideoResolution.Items.AddRange(new object[] {
            "320x240",
            "640x480",
            "960x540",
            "1280x720",
            "1920x1080",
            "3840x2160"});
            this.cmbVideoResolution.Location = new System.Drawing.Point(91, 58);
            this.cmbVideoResolution.Name = "cmbVideoResolution";
            this.cmbVideoResolution.Size = new System.Drawing.Size(83, 21);
            this.cmbVideoResolution.TabIndex = 5;
            // 
            // lblVideoResolution
            // 
            this.lblVideoResolution.AutoSize = true;
            this.lblVideoResolution.Location = new System.Drawing.Point(12, 61);
            this.lblVideoResolution.Name = "lblVideoResolution";
            this.lblVideoResolution.Size = new System.Drawing.Size(70, 13);
            this.lblVideoResolution.TabIndex = 0;
            this.lblVideoResolution.Text = "V. Resolution";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 91);
            this.Controls.Add(this.cmbVideoResolution);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnBrowseExportPath);
            this.Controls.Add(this.btnMP3FileBrowse);
            this.Controls.Add(this.txtExportPath);
            this.Controls.Add(this.lblVideoResolution);
            this.Controls.Add(this.lblExportPath);
            this.Controls.Add(this.txtMP3FilePath);
            this.Controls.Add(this.lblMP3FilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MP3 to Sound Wave Video";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMP3FilePath;
        private System.Windows.Forms.TextBox txtMP3FilePath;
        private System.Windows.Forms.Button btnMP3FileBrowse;
        private System.Windows.Forms.Label lblExportPath;
        private System.Windows.Forms.TextBox txtExportPath;
        private System.Windows.Forms.Button btnBrowseExportPath;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cmbVideoResolution;
        private System.Windows.Forms.Label lblVideoResolution;
    }
}

