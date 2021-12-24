namespace MyLittleKaraoke_WebInstall
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxInstallPath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DownloadAndInstallButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InstalledVersionLabel = new System.Windows.Forms.Label();
            this.InstalledPackageLabel = new System.Windows.Forms.Label();
            this.ActionNextLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ServerBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ForceReinstall = new System.Windows.Forms.CheckBox();
            this.ForceUpd = new System.Windows.Forms.CheckBox();
            this.forceupgradetext = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.DisableInstall = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Little Karaoke - Developper Web Installer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "This Webinstaller will download and install My Little Karaoke for you";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Where do you want to install My Little Karaoke:";
            // 
            // TextBoxInstallPath
            // 
            this.TextBoxInstallPath.Location = new System.Drawing.Point(16, 86);
            this.TextBoxInstallPath.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxInstallPath.Name = "TextBoxInstallPath";
            this.TextBoxInstallPath.Size = new System.Drawing.Size(585, 22);
            this.TextBoxInstallPath.TabIndex = 4;
            this.TextBoxInstallPath.Text = "C:\\Program Files\\My Little Karaoke";
            this.TextBoxInstallPath.TextChanged += new System.EventHandler(this.TextBoxInstallPath_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(13, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(588, 60);
            this.label4.TabIndex = 6;
            this.label4.Text = "If anything happened to your internet connection during the download, or, if the " +
    "downloaded file is corrupted, \r\nMy Little Karaoke will ask you to redownload onl" +
    "y the last part.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DownloadAndInstallButton
            // 
            this.DownloadAndInstallButton.Location = new System.Drawing.Point(16, 196);
            this.DownloadAndInstallButton.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadAndInstallButton.Name = "DownloadAndInstallButton";
            this.DownloadAndInstallButton.Size = new System.Drawing.Size(585, 41);
            this.DownloadAndInstallButton.TabIndex = 7;
            this.DownloadAndInstallButton.Text = "Install the Game!";
            this.DownloadAndInstallButton.UseVisualStyleBackColor = true;
            this.DownloadAndInstallButton.Click += new System.EventHandler(this.DownloadAndInstallButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(24, 367);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(577, 28);
            this.progressBar1.TabIndex = 8;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(24, 436);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(577, 28);
            this.progressBar2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Download part progress:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(211, 399);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(390, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "Speed and File Size";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(474, 468);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Part 0 of ?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Download (Overall) progress:";
            // 
            // InstalledVersionLabel
            // 
            this.InstalledVersionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstalledVersionLabel.Location = new System.Drawing.Point(205, 144);
            this.InstalledVersionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstalledVersionLabel.Name = "InstalledVersionLabel";
            this.InstalledVersionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InstalledVersionLabel.Size = new System.Drawing.Size(396, 16);
            this.InstalledVersionLabel.TabIndex = 18;
            this.InstalledVersionLabel.Text = "Installed version: unknown";
            this.InstalledVersionLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InstalledPackageLabel
            // 
            this.InstalledPackageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InstalledPackageLabel.Location = new System.Drawing.Point(205, 160);
            this.InstalledPackageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InstalledPackageLabel.Name = "InstalledPackageLabel";
            this.InstalledPackageLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InstalledPackageLabel.Size = new System.Drawing.Size(396, 16);
            this.InstalledPackageLabel.TabIndex = 19;
            this.InstalledPackageLabel.Text = "- here extra package information -";
            this.InstalledPackageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ActionNextLabel
            // 
            this.ActionNextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionNextLabel.Location = new System.Drawing.Point(205, 176);
            this.ActionNextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ActionNextLabel.Name = "ActionNextLabel";
            this.ActionNextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ActionNextLabel.Size = new System.Drawing.Size(396, 16);
            this.ActionNextLabel.TabIndex = 20;
            this.ActionNextLabel.Text = "Action: unknown";
            this.ActionNextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 484);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(188, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Package Installation progress:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(133, 535);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(468, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Part 0 of ?";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(24, 503);
            this.progressBar3.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(577, 28);
            this.progressBar3.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(630, 75);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(265, 20);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Delete installation packages after install";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ServerBox
            // 
            this.ServerBox.Location = new System.Drawing.Point(699, 5);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(321, 22);
            this.ServerBox.TabIndex = 25;
            this.ServerBox.Text = "https://www.mylittlekaraoke.com/store/webinst";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(627, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "SERVER:";
            // 
            // ForceReinstall
            // 
            this.ForceReinstall.AutoSize = true;
            this.ForceReinstall.Location = new System.Drawing.Point(630, 102);
            this.ForceReinstall.Name = "ForceReinstall";
            this.ForceReinstall.Size = new System.Drawing.Size(322, 20);
            this.ForceReinstall.TabIndex = 27;
            this.ForceReinstall.Text = "Force full reinstallation, ignore installed packages";
            this.ForceReinstall.UseVisualStyleBackColor = true;
            this.ForceReinstall.CheckedChanged += new System.EventHandler(this.ForceReinstall_CheckedChanged);
            // 
            // ForceUpd
            // 
            this.ForceUpd.AutoSize = true;
            this.ForceUpd.Location = new System.Drawing.Point(630, 128);
            this.ForceUpd.Name = "ForceUpd";
            this.ForceUpd.Size = new System.Drawing.Size(150, 20);
            this.ForceUpd.TabIndex = 28;
            this.ForceUpd.Text = "Force upgrade from:";
            this.ForceUpd.UseVisualStyleBackColor = true;
            this.ForceUpd.CheckedChanged += new System.EventHandler(this.ForceUpd_CheckedChanged);
            // 
            // forceupgradetext
            // 
            this.forceupgradetext.Location = new System.Drawing.Point(826, 126);
            this.forceupgradetext.Name = "forceupgradetext";
            this.forceupgradetext.Size = new System.Drawing.Size(199, 22);
            this.forceupgradetext.TabIndex = 29;
            this.forceupgradetext.Text = "winusdx5.mlu";
            this.forceupgradetext.TextChanged += new System.EventHandler(this.forceupgradetext_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(630, 202);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(390, 356);
            this.listBox1.TabIndex = 30;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 563);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(510, 16);
            this.label13.TabIndex = 32;
            this.label13.Text = "For testing purposes only - Do not use to install the game in production - Ver 20" +
    "211224";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 35);
            this.button2.TabIndex = 33;
            this.button2.Text = "Fetch available versions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DisableInstall
            // 
            this.DisableInstall.AutoSize = true;
            this.DisableInstall.Location = new System.Drawing.Point(630, 153);
            this.DisableInstall.Name = "DisableInstall";
            this.DisableInstall.Size = new System.Drawing.Size(142, 20);
            this.DisableInstall.TabIndex = 34;
            this.DisableInstall.Text = "Disable installation";
            this.DisableInstall.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(630, 176);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 20);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "Custom Version";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.DownloadAndInstallButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 586);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.DisableInstall);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.forceupgradetext);
            this.Controls.Add(this.ForceUpd);
            this.Controls.Add(this.ForceReinstall);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.ActionNextLabel);
            this.Controls.Add(this.InstalledPackageLabel);
            this.Controls.Add(this.InstalledVersionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DownloadAndInstallButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBoxInstallPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1038, 362);
            this.Name = "Form1";
            this.Text = "My Little Karaoke - Web Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxInstallPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DownloadAndInstallButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label InstalledVersionLabel;
        private System.Windows.Forms.Label InstalledPackageLabel;
        private System.Windows.Forms.Label ActionNextLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox ServerBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ForceReinstall;
        private System.Windows.Forms.CheckBox ForceUpd;
        private System.Windows.Forms.TextBox forceupgradetext;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox DisableInstall;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

