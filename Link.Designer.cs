namespace Test8
{
    partial class Link
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
            this.BackButton = new System.Windows.Forms.Button();
            this.GithubLink = new System.Windows.Forms.LinkLabel();
            this.CodingLink = new System.Windows.Forms.LinkLabel();
            this.L1 = new System.Windows.Forms.Label();
            this.L2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.AutoSize = true;
            this.BackButton.Location = new System.Drawing.Point(12, 325);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 24);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "返回";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GithubLink
            // 
            this.GithubLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.GithubLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.GithubLink.AutoSize = true;
            this.GithubLink.BackColor = System.Drawing.Color.Transparent;
            this.GithubLink.DisabledLinkColor = System.Drawing.Color.Black;
            this.GithubLink.LinkColor = System.Drawing.Color.Black;
            this.GithubLink.Location = new System.Drawing.Point(12, 9);
            this.GithubLink.Name = "GithubLink";
            this.GithubLink.Size = new System.Drawing.Size(147, 14);
            this.GithubLink.TabIndex = 0;
            this.GithubLink.TabStop = true;
            this.GithubLink.Text = "To Github - 去Github";
            this.GithubLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.GithubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // CodingLink
            // 
            this.CodingLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.CodingLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CodingLink.AutoSize = true;
            this.CodingLink.BackColor = System.Drawing.Color.Transparent;
            this.CodingLink.DisabledLinkColor = System.Drawing.Color.Black;
            this.CodingLink.LinkColor = System.Drawing.Color.Black;
            this.CodingLink.Location = new System.Drawing.Point(12, 23);
            this.CodingLink.Name = "CodingLink";
            this.CodingLink.Size = new System.Drawing.Size(147, 14);
            this.CodingLink.TabIndex = 1;
            this.CodingLink.TabStop = true;
            this.CodingLink.Text = "To Coding - 去Coding";
            this.CodingLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.CodingLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CodingLink_LinkClicked);
            // 
            // L1
            // 
            this.L1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.L1.AutoSize = true;
            this.L1.Location = new System.Drawing.Point(12, 37);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(63, 14);
            this.L1.TabIndex = 0;
            this.L1.Text = "Nothing1";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Location = new System.Drawing.Point(12, 51);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(63, 14);
            this.L2.TabIndex = 0;
            this.L2.Text = "Nothing2";
            // 
            // Link
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.L2);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.CodingLink);
            this.Controls.Add(this.GithubLink);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Link";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-git.Link";
            this.Load += new System.EventHandler(this.Link_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.LinkLabel GithubLink;
        private System.Windows.Forms.LinkLabel CodingLink;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.Label L2;
    }
}