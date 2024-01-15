namespace StorageApp
{
    partial class Dashboard
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Upload = new System.Windows.Forms.TabPage();
            this.PnlFile = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDirectories = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.DownloadprogressBar = new System.Windows.Forms.ProgressBar();
            this.btnDownloadfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AllFile = new System.Windows.Forms.TabPage();
            this.PnlDirectory = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirName = new System.Windows.Forms.TextBox();
            this.lstCreateDirTab = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.Settings = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txlFolderLocation = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllFiles = new System.Windows.Forms.TabControl();
            this.Download = new System.Windows.Forms.TabPage();
            this.lstDownloadFiles = new System.Windows.Forms.ListView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.Upload.SuspendLayout();
            this.PnlFile.SuspendLayout();
            this.AllFile.SuspendLayout();
            this.PnlDirectory.SuspendLayout();
            this.Settings.SuspendLayout();
            this.AllFiles.SuspendLayout();
            this.Download.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Upload
            // 
            this.Upload.Controls.Add(this.PnlFile);
            this.Upload.Controls.Add(this.lstDirectories);
            this.Upload.Controls.Add(this.label4);
            this.Upload.Location = new System.Drawing.Point(4, 30);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(710, 378);
            this.Upload.TabIndex = 3;
            this.Upload.Text = "Upload file on server";
            this.Upload.UseVisualStyleBackColor = true;
            // 
            // PnlFile
            // 
            this.PnlFile.Controls.Add(this.button2);
            this.PnlFile.Controls.Add(this.txtFileName);
            this.PnlFile.Controls.Add(this.button1);
            this.PnlFile.Location = new System.Drawing.Point(380, 66);
            this.PnlFile.Name = "PnlFile";
            this.PnlFile.Size = new System.Drawing.Size(323, 238);
            this.PnlFile.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 57);
            this.button2.TabIndex = 0;
            this.button2.Text = "Upload Files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnFileUpload_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(4, 29);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(216, 24);
            this.txtFileName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstDirectories
            // 
            this.lstDirectories.FullRowSelect = true;
            this.lstDirectories.Location = new System.Drawing.Point(8, 66);
            this.lstDirectories.Name = "lstDirectories";
            this.lstDirectories.Size = new System.Drawing.Size(319, 238);
            this.lstDirectories.TabIndex = 8;
            this.lstDirectories.UseCompatibleStateImageBehavior = false;
            this.lstDirectories.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select Directory ";
            // 
            // DownloadprogressBar
            // 
            this.DownloadprogressBar.BackColor = System.Drawing.Color.Maroon;
            this.DownloadprogressBar.ForeColor = System.Drawing.Color.DarkRed;
            this.DownloadprogressBar.Location = new System.Drawing.Point(19, 325);
            this.DownloadprogressBar.Name = "DownloadprogressBar";
            this.DownloadprogressBar.Size = new System.Drawing.Size(314, 23);
            this.DownloadprogressBar.TabIndex = 3;
            // 
            // btnDownloadfile
            // 
            this.btnDownloadfile.Location = new System.Drawing.Point(460, 154);
            this.btnDownloadfile.Name = "btnDownloadfile";
            this.btnDownloadfile.Size = new System.Drawing.Size(143, 48);
            this.btnDownloadfile.TabIndex = 2;
            this.btnDownloadfile.Text = "Download File";
            this.btnDownloadfile.UseVisualStyleBackColor = true;
            this.btnDownloadfile.Click += new System.EventHandler(this.btnDownloadfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "List of All Directory / Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Download Files ";
            // 
            // AllFile
            // 
            this.AllFile.Controls.Add(this.PnlDirectory);
            this.AllFile.Controls.Add(this.lstCreateDirTab);
            this.AllFile.Controls.Add(this.label2);
            this.AllFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllFile.Location = new System.Drawing.Point(4, 30);
            this.AllFile.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AllFile.Name = "AllFile";
            this.AllFile.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AllFile.Size = new System.Drawing.Size(710, 378);
            this.AllFile.TabIndex = 0;
            this.AllFile.Text = "Create Directory on server";
            this.AllFile.UseVisualStyleBackColor = true;
            // 
            // PnlDirectory
            // 
            this.PnlDirectory.Controls.Add(this.button3);
            this.PnlDirectory.Controls.Add(this.label5);
            this.PnlDirectory.Controls.Add(this.txtDirName);
            this.PnlDirectory.Location = new System.Drawing.Point(367, 93);
            this.PnlDirectory.Name = "PnlDirectory";
            this.PnlDirectory.Size = new System.Drawing.Size(300, 238);
            this.PnlDirectory.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 57);
            this.button3.TabIndex = 3;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Enter directory name";
            // 
            // txtDirName
            // 
            this.txtDirName.Location = new System.Drawing.Point(33, 52);
            this.txtDirName.Name = "txtDirName";
            this.txtDirName.Size = new System.Drawing.Size(246, 30);
            this.txtDirName.TabIndex = 1;
            // 
            // lstCreateDirTab
            // 
            this.lstCreateDirTab.FullRowSelect = true;
            this.lstCreateDirTab.Location = new System.Drawing.Point(8, 93);
            this.lstCreateDirTab.Name = "lstCreateDirTab";
            this.lstCreateDirTab.Size = new System.Drawing.Size(319, 238);
            this.lstCreateDirTab.TabIndex = 10;
            this.lstCreateDirTab.UseCompatibleStateImageBehavior = false;
            this.lstCreateDirTab.View = System.Windows.Forms.View.List;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Update local location";
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.button6);
            this.Settings.Controls.Add(this.button4);
            this.Settings.Controls.Add(this.txlFolderLocation);
            this.Settings.Controls.Add(this.button5);
            this.Settings.Controls.Add(this.label6);
            this.Settings.Controls.Add(this.label1);
            this.Settings.Location = new System.Drawing.Point(4, 30);
            this.Settings.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(710, 378);
            this.Settings.TabIndex = 2;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(379, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(140, 57);
            this.button6.TabIndex = 7;
            this.button6.Text = "Signout";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(233, 144);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 57);
            this.button4.TabIndex = 7;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txlFolderLocation
            // 
            this.txlFolderLocation.Enabled = false;
            this.txlFolderLocation.Location = new System.Drawing.Point(233, 74);
            this.txlFolderLocation.Name = "txlFolderLocation";
            this.txlFolderLocation.Size = new System.Drawing.Size(216, 24);
            this.txlFolderLocation.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(455, 72);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 29);
            this.button5.TabIndex = 9;
            this.button5.Text = "Select path";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(120, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Dashboard";
            // 
            // AllFiles
            // 
            this.AllFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AllFiles.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.AllFiles.Controls.Add(this.AllFile);
            this.AllFiles.Controls.Add(this.Download);
            this.AllFiles.Controls.Add(this.Upload);
            this.AllFiles.Controls.Add(this.Settings);
            this.AllFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AllFiles.ImeMode = System.Windows.Forms.ImeMode.On;
            this.AllFiles.Location = new System.Drawing.Point(0, 1);
            this.AllFiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AllFiles.Multiline = true;
            this.AllFiles.Name = "AllFiles";
            this.AllFiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AllFiles.SelectedIndex = 0;
            this.AllFiles.Size = new System.Drawing.Size(718, 412);
            this.AllFiles.TabIndex = 6;
            // 
            // Download
            // 
            this.Download.Controls.Add(this.lstDownloadFiles);
            this.Download.Controls.Add(this.DownloadprogressBar);
            this.Download.Controls.Add(this.btnDownloadfile);
            this.Download.Controls.Add(this.label3);
            this.Download.Location = new System.Drawing.Point(4, 30);
            this.Download.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Download.Name = "Download";
            this.Download.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Download.Size = new System.Drawing.Size(710, 378);
            this.Download.TabIndex = 1;
            this.Download.Text = "Download to local";
            this.Download.UseVisualStyleBackColor = true;
            // 
            // lstDownloadFiles
            // 
            this.lstDownloadFiles.FullRowSelect = true;
            this.lstDownloadFiles.Location = new System.Drawing.Point(19, 62);
            this.lstDownloadFiles.Name = "lstDownloadFiles";
            this.lstDownloadFiles.Size = new System.Drawing.Size(319, 238);
            this.lstDownloadFiles.TabIndex = 9;
            this.lstDownloadFiles.UseCompatibleStateImageBehavior = false;
            this.lstDownloadFiles.View = System.Windows.Forms.View.List;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 414);
            this.Controls.Add(this.AllFiles);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.contextMenuStrip1.ResumeLayout(false);
            this.Upload.ResumeLayout(false);
            this.Upload.PerformLayout();
            this.PnlFile.ResumeLayout(false);
            this.PnlFile.PerformLayout();
            this.AllFile.ResumeLayout(false);
            this.AllFile.PerformLayout();
            this.PnlDirectory.ResumeLayout(false);
            this.PnlDirectory.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.AllFiles.ResumeLayout(false);
            this.Download.ResumeLayout(false);
            this.Download.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage Upload;
        private System.Windows.Forms.ProgressBar DownloadprogressBar;
        private System.Windows.Forms.Button btnDownloadfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage AllFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl AllFiles;
        private System.Windows.Forms.TabPage Download;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstDirectories;
        private System.Windows.Forms.ListView lstDownloadFiles;
        private System.Windows.Forms.Panel PnlFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lstCreateDirTab;
        private System.Windows.Forms.Panel PnlDirectory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txlFolderLocation;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}