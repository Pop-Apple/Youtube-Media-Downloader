namespace Youtube_Media_Downloader
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportGitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAndroidiphoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yahooToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioMp3 = new System.Windows.Forms.RadioButton();
            this.radioMp4 = new System.Windows.Forms.RadioButton();
            this.PreprogressBar = new System.Windows.Forms.ProgressBar();
            this.ProcessLabel = new System.Windows.Forms.Label();
            this.DefaultprogressBar = new System.Windows.Forms.ProgressBar();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnON = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.timerError = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.toolTToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(693, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exportGitToolStripMenuItem,
            this.exportAndroidiphoneToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(62, 30);
            this.ファイルFToolStripMenuItem.Text = "File(&F)";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(298, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(298, 34);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exportGitToolStripMenuItem
            // 
            this.exportGitToolStripMenuItem.Name = "exportGitToolStripMenuItem";
            this.exportGitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.exportGitToolStripMenuItem.Size = new System.Drawing.Size(298, 34);
            this.exportGitToolStripMenuItem.Text = "Export Github Language";
            this.exportGitToolStripMenuItem.Click += new System.EventHandler(this.exportGitToolStripMenuItem_Click);
            // 
            // exportAndroidiphoneToolStripMenuItem
            // 
            this.exportAndroidiphoneToolStripMenuItem.Name = "exportAndroidiphoneToolStripMenuItem";
            this.exportAndroidiphoneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.exportAndroidiphoneToolStripMenuItem.Size = new System.Drawing.Size(298, 34);
            this.exportAndroidiphoneToolStripMenuItem.Text = "Export Android iphone";
            this.exportAndroidiphoneToolStripMenuItem.Click += new System.EventHandler(this.exportAndroidiphoneToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(295, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(298, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(66, 30);
            this.editEToolStripMenuItem.Text = "Edit(&E)";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolTToolStripMenuItem
            // 
            this.toolTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.googleToolStripMenuItem,
            this.yahooToolStripMenuItem});
            this.toolTToolStripMenuItem.Name = "toolTToolStripMenuItem";
            this.toolTToolStripMenuItem.Size = new System.Drawing.Size(69, 30);
            this.toolTToolStripMenuItem.Text = "Tool(&T)";
            // 
            // googleToolStripMenuItem
            // 
            this.googleToolStripMenuItem.Name = "googleToolStripMenuItem";
            this.googleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.googleToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.googleToolStripMenuItem.Text = "&Google";
            this.googleToolStripMenuItem.Click += new System.EventHandler(this.googleToolStripMenuItem_Click);
            // 
            // yahooToolStripMenuItem
            // 
            this.yahooToolStripMenuItem.Name = "yahooToolStripMenuItem";
            this.yahooToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Y)));
            this.yahooToolStripMenuItem.Size = new System.Drawing.Size(193, 34);
            this.yahooToolStripMenuItem.Text = "&Youtube";
            this.yahooToolStripMenuItem.Click += new System.EventHandler(this.yahooToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(70, 30);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // licenseToolStripMenuItem
            // 
            this.licenseToolStripMenuItem.Name = "licenseToolStripMenuItem";
            this.licenseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.licenseToolStripMenuItem.Size = new System.Drawing.Size(187, 34);
            this.licenseToolStripMenuItem.Text = "License";
            this.licenseToolStripMenuItem.Click += new System.EventHandler(this.licenseToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Youtube Media Downloader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtAddress.Location = new System.Drawing.Point(156, 94);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(518, 26);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Formated :";
            // 
            // radioMp3
            // 
            this.radioMp3.AutoSize = true;
            this.radioMp3.Checked = true;
            this.radioMp3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioMp3.Location = new System.Drawing.Point(256, 159);
            this.radioMp3.Name = "radioMp3";
            this.radioMp3.Size = new System.Drawing.Size(66, 22);
            this.radioMp3.TabIndex = 5;
            this.radioMp3.TabStop = true;
            this.radioMp3.Text = ".mp3";
            this.radioMp3.UseVisualStyleBackColor = true;
            this.radioMp3.CheckedChanged += new System.EventHandler(this.radioMp3_CheckedChanged);
            // 
            // radioMp4
            // 
            this.radioMp4.AutoSize = true;
            this.radioMp4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioMp4.Location = new System.Drawing.Point(156, 159);
            this.radioMp4.Name = "radioMp4";
            this.radioMp4.Size = new System.Drawing.Size(66, 22);
            this.radioMp4.TabIndex = 6;
            this.radioMp4.Text = ".mp4";
            this.radioMp4.UseVisualStyleBackColor = true;
            this.radioMp4.CheckedChanged += new System.EventHandler(this.radioMp4_CheckedChanged);
            // 
            // PreprogressBar
            // 
            this.PreprogressBar.Location = new System.Drawing.Point(16, 236);
            this.PreprogressBar.Name = "PreprogressBar";
            this.PreprogressBar.Size = new System.Drawing.Size(658, 23);
            this.PreprogressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PreprogressBar.TabIndex = 7;
            // 
            // ProcessLabel
            // 
            this.ProcessLabel.AutoSize = true;
            this.ProcessLabel.Location = new System.Drawing.Point(13, 212);
            this.ProcessLabel.Name = "ProcessLabel";
            this.ProcessLabel.Size = new System.Drawing.Size(95, 18);
            this.ProcessLabel.TabIndex = 8;
            this.ProcessLabel.Text = "Preparation";
            // 
            // DefaultprogressBar
            // 
            this.DefaultprogressBar.Location = new System.Drawing.Point(16, 236);
            this.DefaultprogressBar.Name = "DefaultprogressBar";
            this.DefaultprogressBar.Size = new System.Drawing.Size(658, 23);
            this.DefaultprogressBar.Step = 0;
            this.DefaultprogressBar.TabIndex = 9;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Transparent;
            this.btnConvert.BackgroundImage = global::Youtube_Media_Downloader.Properties.Resources.Convert;
            this.btnConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConvert.Location = new System.Drawing.Point(16, 270);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(108, 53);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.BackColor = System.Drawing.Color.Transparent;
            this.btnOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOFF.Location = new System.Drawing.Point(592, 270);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(82, 53);
            this.btnOFF.TabIndex = 11;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = false;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnON
            // 
            this.btnON.BackColor = System.Drawing.Color.SkyBlue;
            this.btnON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnON.Location = new System.Drawing.Point(504, 270);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(82, 53);
            this.btnON.TabIndex = 15;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = false;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 337);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 34);
            this.panel1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ver 1.1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerError
            // 
            this.timerError.Tick += new System.EventHandler(this.timerError_Tick);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 371);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.DefaultprogressBar);
            this.Controls.Add(this.ProcessLabel);
            this.Controls.Add(this.PreprogressBar);
            this.Controls.Add(this.radioMp4);
            this.Controls.Add(this.radioMp3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Media Downloader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioMp3;
        private System.Windows.Forms.RadioButton radioMp4;
        private System.Windows.Forms.ProgressBar PreprogressBar;
        private System.Windows.Forms.Label ProcessLabel;
        private System.Windows.Forms.ProgressBar DefaultprogressBar;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportGitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yahooToolStripMenuItem;
        private System.Windows.Forms.Timer timerError;
        private System.Windows.Forms.ToolStripMenuItem exportAndroidiphoneToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

