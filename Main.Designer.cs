namespace Test8
{
    partial class Main
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
            this.DisplayNameL = new System.Windows.Forms.Label();
            this.DisplayName = new System.Windows.Forms.TextBox();
            this.AuthorL = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.BuildIgnoreL = new System.Windows.Forms.Label();
            this.BuildIgnoreButton = new System.Windows.Forms.Button();
            this.OtherButtonL = new System.Windows.Forms.Label();
            this.OtherButton = new System.Windows.Forms.Button();
            this.SourceLink = new System.Windows.Forms.LinkLabel();
            this.SureAboutThat = new System.Windows.Forms.Button();
            this.HomepageL = new System.Windows.Forms.Label();
            this.Homepage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DisplayNameL
            // 
            this.DisplayNameL.AutoSize = true;
            this.DisplayNameL.Location = new System.Drawing.Point(12, 9);
            this.DisplayNameL.Name = "DisplayNameL";
            this.DisplayNameL.Size = new System.Drawing.Size(98, 14);
            this.DisplayNameL.TabIndex = 0;
            this.DisplayNameL.Text = "Display Name:";
            // 
            // DisplayName
            // 
            this.DisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayName.Location = new System.Drawing.Point(12, 26);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(360, 23);
            this.DisplayName.TabIndex = 0;
            // 
            // AuthorL
            // 
            this.AuthorL.AutoSize = true;
            this.AuthorL.Location = new System.Drawing.Point(12, 66);
            this.AuthorL.Name = "AuthorL";
            this.AuthorL.Size = new System.Drawing.Size(56, 14);
            this.AuthorL.TabIndex = 0;
            this.AuthorL.Text = "Author:";
            // 
            // Author
            // 
            this.Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Author.Location = new System.Drawing.Point(12, 83);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(360, 23);
            this.Author.TabIndex = 1;
            // 
            // BuildIgnoreL
            // 
            this.BuildIgnoreL.AutoSize = true;
            this.BuildIgnoreL.Location = new System.Drawing.Point(12, 180);
            this.BuildIgnoreL.Name = "BuildIgnoreL";
            this.BuildIgnoreL.Size = new System.Drawing.Size(91, 14);
            this.BuildIgnoreL.TabIndex = 0;
            this.BuildIgnoreL.Text = "BuildIgnore:";
            // 
            // BuildIgnoreButton
            // 
            this.BuildIgnoreButton.Location = new System.Drawing.Point(12, 197);
            this.BuildIgnoreButton.Name = "BuildIgnoreButton";
            this.BuildIgnoreButton.Size = new System.Drawing.Size(360, 23);
            this.BuildIgnoreButton.TabIndex = 2;
            this.BuildIgnoreButton.Text = "点此切换";
            this.BuildIgnoreButton.UseVisualStyleBackColor = true;
            this.BuildIgnoreButton.Click += new System.EventHandler(this.BuildIgnoreButton_Click);
            // 
            // OtherButtonL
            // 
            this.OtherButtonL.AutoSize = true;
            this.OtherButtonL.Location = new System.Drawing.Point(12, 237);
            this.OtherButtonL.Name = "OtherButtonL";
            this.OtherButtonL.Size = new System.Drawing.Size(70, 14);
            this.OtherButtonL.TabIndex = 0;
            this.OtherButtonL.Text = "其他选项:";
            // 
            // OtherButton
            // 
            this.OtherButton.Location = new System.Drawing.Point(12, 254);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(360, 23);
            this.OtherButton.TabIndex = 3;
            this.OtherButton.Text = "点此切换";
            this.OtherButton.UseVisualStyleBackColor = true;
            this.OtherButton.Click += new System.EventHandler(this.OtherButton_Click);
            // 
            // SourceLink
            // 
            this.SourceLink.ActiveLinkColor = System.Drawing.Color.Black;
            this.SourceLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SourceLink.AutoSize = true;
            this.SourceLink.BackColor = System.Drawing.Color.Transparent;
            this.SourceLink.DisabledLinkColor = System.Drawing.Color.Black;
            this.SourceLink.LinkColor = System.Drawing.Color.Black;
            this.SourceLink.Location = new System.Drawing.Point(12, 338);
            this.SourceLink.Name = "SourceLink";
            this.SourceLink.Size = new System.Drawing.Size(245, 14);
            this.SourceLink.TabIndex = 5;
            this.SourceLink.TabStop = true;
            this.SourceLink.Text = "低技术力生草屑作，源码地址点此查看";
            this.SourceLink.VisitedLinkColor = System.Drawing.Color.Black;
            this.SourceLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceLink_LinkClicked);
            // 
            // SureAboutThat
            // 
            this.SureAboutThat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SureAboutThat.AutoSize = true;
            this.SureAboutThat.Location = new System.Drawing.Point(12, 311);
            this.SureAboutThat.Name = "SureAboutThat";
            this.SureAboutThat.Size = new System.Drawing.Size(45, 24);
            this.SureAboutThat.TabIndex = 4;
            this.SureAboutThat.Text = "确定";
            this.SureAboutThat.UseVisualStyleBackColor = true;
            this.SureAboutThat.Click += new System.EventHandler(this.SureAboutThat_Click);
            // 
            // HomepageL
            // 
            this.HomepageL.AutoSize = true;
            this.HomepageL.Location = new System.Drawing.Point(12, 123);
            this.HomepageL.Name = "HomepageL";
            this.HomepageL.Size = new System.Drawing.Size(70, 14);
            this.HomepageL.TabIndex = 6;
            this.HomepageL.Text = "Homepage:";
            // 
            // Homepage
            // 
            this.Homepage.Location = new System.Drawing.Point(12, 140);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(360, 23);
            this.Homepage.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Homepage);
            this.Controls.Add(this.HomepageL);
            this.Controls.Add(this.SureAboutThat);
            this.Controls.Add(this.SourceLink);
            this.Controls.Add(this.OtherButton);
            this.Controls.Add(this.OtherButtonL);
            this.Controls.Add(this.BuildIgnoreButton);
            this.Controls.Add(this.BuildIgnoreL);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.AuthorL);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.DisplayNameL);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayNameL;
        private System.Windows.Forms.TextBox DisplayName;
        private System.Windows.Forms.Label AuthorL;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.Label BuildIgnoreL;
        private System.Windows.Forms.Button BuildIgnoreButton;
        private System.Windows.Forms.Label OtherButtonL;
        private System.Windows.Forms.Button OtherButton;
        private System.Windows.Forms.LinkLabel SourceLink;
        private System.Windows.Forms.Button SureAboutThat;
        private System.Windows.Forms.Label HomepageL;
        private System.Windows.Forms.TextBox Homepage;
    }
}