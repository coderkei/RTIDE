namespace RTIDE_Web
{
    partial class htmlHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(htmlHelp));
            this.htmlView = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // htmlView
            // 
            this.htmlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlView.Location = new System.Drawing.Point(0, 0);
            this.htmlView.MinimumSize = new System.Drawing.Size(20, 20);
            this.htmlView.Name = "htmlView";
            this.htmlView.Size = new System.Drawing.Size(653, 645);
            this.htmlView.TabIndex = 0;
            // 
            // htmlHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 645);
            this.Controls.Add(this.htmlView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "htmlHelp";
            this.Text = "Help Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser htmlView;
    }
}