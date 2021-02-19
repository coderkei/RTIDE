namespace RTIDE_Web
{
    partial class startForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            this.quickStartBtn = new System.Windows.Forms.Button();
            this.getStartTitle = new System.Windows.Forms.Label();
            this.ideTitle = new System.Windows.Forms.Label();
            this.openRecent = new System.Windows.Forms.Button();
            this.recentLabel = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.lastViewGrp = new System.Windows.Forms.GroupBox();
            this.recentFadeBox = new System.Windows.Forms.PictureBox();
            this.openLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.newFile = new System.Windows.Forms.LinkLabel();
            this.openFile = new System.Windows.Forms.LinkLabel();
            this.openURL = new System.Windows.Forms.LinkLabel();
            this.projectGrp = new System.Windows.Forms.GroupBox();
            this.projectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.lastViewGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentFadeBox)).BeginInit();
            this.projectGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // quickStartBtn
            // 
            this.quickStartBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quickStartBtn.Location = new System.Drawing.Point(335, 63);
            this.quickStartBtn.Name = "quickStartBtn";
            this.quickStartBtn.Size = new System.Drawing.Size(272, 45);
            this.quickStartBtn.TabIndex = 6;
            this.quickStartBtn.Text = "Quick Start";
            this.quickStartBtn.UseVisualStyleBackColor = true;
            this.quickStartBtn.Click += new System.EventHandler(this.openQuickStart);
            // 
            // getStartTitle
            // 
            this.getStartTitle.AutoSize = true;
            this.getStartTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStartTitle.Location = new System.Drawing.Point(328, 11);
            this.getStartTitle.Name = "getStartTitle";
            this.getStartTitle.Size = new System.Drawing.Size(212, 40);
            this.getStartTitle.TabIndex = 10;
            this.getStartTitle.Text = "Getting Started";
            // 
            // ideTitle
            // 
            this.ideTitle.AutoSize = true;
            this.ideTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ideTitle.Location = new System.Drawing.Point(18, 11);
            this.ideTitle.Name = "ideTitle";
            this.ideTitle.Size = new System.Drawing.Size(215, 40);
            this.ideTitle.TabIndex = 9;
            this.ideTitle.Text = "RT-IDE for Web";
            // 
            // openRecent
            // 
            this.openRecent.Enabled = false;
            this.openRecent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openRecent.Location = new System.Drawing.Point(14, 216);
            this.openRecent.Name = "openRecent";
            this.openRecent.Size = new System.Drawing.Size(254, 38);
            this.openRecent.TabIndex = 6;
            this.openRecent.Text = "Open File";
            this.openRecent.UseVisualStyleBackColor = true;
            this.openRecent.Click += new System.EventHandler(this.openRecentBtn);
            // 
            // recentLabel
            // 
            this.recentLabel.AutoSize = true;
            this.recentLabel.Location = new System.Drawing.Point(6, 25);
            this.recentLabel.Name = "recentLabel";
            this.recentLabel.Size = new System.Drawing.Size(110, 21);
            this.recentLabel.TabIndex = 1;
            this.recentLabel.Text = "No Recent File";
            // 
            // helpBtn
            // 
            this.helpBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Location = new System.Drawing.Point(335, 114);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(272, 45);
            this.helpBtn.TabIndex = 11;
            this.helpBtn.Text = "Open Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.openHelp);
            // 
            // lastViewGrp
            // 
            this.lastViewGrp.Controls.Add(this.openRecent);
            this.lastViewGrp.Controls.Add(this.recentLabel);
            this.lastViewGrp.Controls.Add(this.recentFadeBox);
            this.lastViewGrp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastViewGrp.Location = new System.Drawing.Point(25, 322);
            this.lastViewGrp.Name = "lastViewGrp";
            this.lastViewGrp.Size = new System.Drawing.Size(286, 270);
            this.lastViewGrp.TabIndex = 8;
            this.lastViewGrp.TabStop = false;
            this.lastViewGrp.Text = "Last Viewed File";
            // 
            // recentFadeBox
            // 
            this.recentFadeBox.Image = ((System.Drawing.Image)(resources.GetObject("recentFadeBox.Image")));
            this.recentFadeBox.Location = new System.Drawing.Point(6, 58);
            this.recentFadeBox.Name = "recentFadeBox";
            this.recentFadeBox.Size = new System.Drawing.Size(274, 206);
            this.recentFadeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.recentFadeBox.TabIndex = 0;
            this.recentFadeBox.TabStop = false;
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Location = new System.Drawing.Point(6, 102);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(57, 21);
            this.openLabel.TabIndex = 6;
            this.openLabel.Text = "Open...";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Location = new System.Drawing.Point(6, 25);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(51, 21);
            this.newLabel.TabIndex = 5;
            this.newLabel.Text = "New...";
            // 
            // newFile
            // 
            this.newFile.AutoSize = true;
            this.newFile.Location = new System.Drawing.Point(6, 61);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(79, 21);
            this.newFile.TabIndex = 2;
            this.newFile.TabStop = true;
            this.newFile.Text = "New File...";
            this.newFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.newFile_LinkClicked);
            // 
            // openFile
            // 
            this.openFile.AutoSize = true;
            this.openFile.Location = new System.Drawing.Point(6, 136);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(85, 21);
            this.openFile.TabIndex = 3;
            this.openFile.TabStop = true;
            this.openFile.Text = "Open File...";
            this.openFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loadFile);
            // 
            // openURL
            // 
            this.openURL.AutoSize = true;
            this.openURL.Location = new System.Drawing.Point(6, 157);
            this.openURL.Name = "openURL";
            this.openURL.Size = new System.Drawing.Size(90, 21);
            this.openURL.TabIndex = 4;
            this.openURL.TabStop = true;
            this.openURL.Text = "Open URL...";
            this.openURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loadURL);
            // 
            // projectGrp
            // 
            this.projectGrp.BackColor = System.Drawing.Color.White;
            this.projectGrp.Controls.Add(this.openLabel);
            this.projectGrp.Controls.Add(this.newLabel);
            this.projectGrp.Controls.Add(this.newFile);
            this.projectGrp.Controls.Add(this.openFile);
            this.projectGrp.Controls.Add(this.openURL);
            this.projectGrp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectGrp.Location = new System.Drawing.Point(25, 53);
            this.projectGrp.Name = "projectGrp";
            this.projectGrp.Size = new System.Drawing.Size(286, 270);
            this.projectGrp.TabIndex = 7;
            this.projectGrp.TabStop = false;
            this.projectGrp.Text = "Project";
            // 
            // projectFolder
            // 
            this.projectFolder.Description = "**Set text for creating or opening project**";
            // 
            // logoBox
            // 
            this.logoBox.Image = global::RTIDE_Web.generalResources.logo;
            this.logoBox.Location = new System.Drawing.Point(317, 322);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(295, 268);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 13;
            this.logoBox.TabStop = false;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 602);
            this.Controls.Add(this.logoBox);
            this.Controls.Add(this.quickStartBtn);
            this.Controls.Add(this.getStartTitle);
            this.Controls.Add(this.ideTitle);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.lastViewGrp);
            this.Controls.Add(this.projectGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RT-IDE for Web";
            this.Load += new System.EventHandler(this.init);
            this.lastViewGrp.ResumeLayout(false);
            this.lastViewGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recentFadeBox)).EndInit();
            this.projectGrp.ResumeLayout(false);
            this.projectGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quickStartBtn;
        private System.Windows.Forms.Label getStartTitle;
        private System.Windows.Forms.Label ideTitle;
        private System.Windows.Forms.Button openRecent;
        private System.Windows.Forms.Label recentLabel;
        private System.Windows.Forms.PictureBox recentFadeBox;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.GroupBox lastViewGrp;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.LinkLabel newFile;
        private System.Windows.Forms.LinkLabel openFile;
        private System.Windows.Forms.LinkLabel openURL;
        private System.Windows.Forms.GroupBox projectGrp;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.FolderBrowserDialog projectFolder;

    }
}