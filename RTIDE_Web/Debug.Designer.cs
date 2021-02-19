namespace RTIDE_Web
{
    partial class Debug
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
            this.debugText = new System.Windows.Forms.TextBox();
            this.cmdBox = new System.Windows.Forms.TextBox();
            this.exBtn = new System.Windows.Forms.Button();
            this.argumentBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(12, 12);
            this.debugText.Multiline = true;
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(260, 209);
            this.debugText.TabIndex = 0;
            // 
            // cmdBox
            // 
            this.cmdBox.Location = new System.Drawing.Point(12, 229);
            this.cmdBox.Name = "cmdBox";
            this.cmdBox.Size = new System.Drawing.Size(85, 20);
            this.cmdBox.TabIndex = 1;
            // 
            // exBtn
            // 
            this.exBtn.Location = new System.Drawing.Point(197, 227);
            this.exBtn.Name = "exBtn";
            this.exBtn.Size = new System.Drawing.Size(75, 23);
            this.exBtn.TabIndex = 2;
            this.exBtn.Text = "Execute";
            this.exBtn.UseVisualStyleBackColor = true;
            this.exBtn.Click += new System.EventHandler(this.execute);
            // 
            // argumentBox
            // 
            this.argumentBox.Location = new System.Drawing.Point(103, 229);
            this.argumentBox.Name = "argumentBox";
            this.argumentBox.Size = new System.Drawing.Size(88, 20);
            this.argumentBox.TabIndex = 3;
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.argumentBox);
            this.Controls.Add(this.exBtn);
            this.Controls.Add(this.cmdBox);
            this.Controls.Add(this.debugText);
            this.MaximizeBox = false;
            this.Name = "Debug";
            this.Text = "Debug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.TextBox cmdBox;
        private System.Windows.Forms.Button exBtn;
        private System.Windows.Forms.TextBox argumentBox;
    }
}