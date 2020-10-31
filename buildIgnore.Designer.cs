namespace Test8
{
    partial class BuildIgnore
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
            this.IgnoreList = new System.Windows.Forms.CheckedListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.BackDefault = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IgnoreList
            // 
            this.IgnoreList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IgnoreList.FormattingEnabled = true;
            this.IgnoreList.HorizontalScrollbar = true;
            this.IgnoreList.Items.AddRange(new object[] {
            "*.csproj",
            "*.dll",
            "*.exe",
            "*.sln",
            "*.user",
            ".git/*",
            ".gitattributes",
            ".gitignore",
            ".vs/*",
            "bin/*",
            "obj/*",
            "README.md"});
            this.IgnoreList.Location = new System.Drawing.Point(12, 12);
            this.IgnoreList.Name = "IgnoreList";
            this.IgnoreList.Size = new System.Drawing.Size(360, 292);
            this.IgnoreList.Sorted = true;
            this.IgnoreList.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.AutoSize = true;
            this.BackButton.Location = new System.Drawing.Point(12, 325);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 24);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "返回";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackDefault
            // 
            this.BackDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackDefault.Location = new System.Drawing.Point(297, 326);
            this.BackDefault.Name = "BackDefault";
            this.BackDefault.Size = new System.Drawing.Size(75, 23);
            this.BackDefault.TabIndex = 2;
            this.BackDefault.Text = "返回默认";
            this.BackDefault.UseVisualStyleBackColor = true;
            this.BackDefault.Click += new System.EventHandler(this.BackDefault_Click);
            // 
            // BuildIgnore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.BackDefault);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.IgnoreList);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "BuildIgnore";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-git.BuildIgrone";
            this.Load += new System.EventHandler(this.BuildIgnore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox IgnoreList;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button BackDefault;
    }
}