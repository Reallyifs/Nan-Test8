namespace Test8
{
    partial class Other
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
            this.NewFileButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.BuildTxtButton = new System.Windows.Forms.Button();
            this.OldMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.AutoSize = true;
            this.BackButton.Location = new System.Drawing.Point(12, 325);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 24);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "返回";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NewFileButton
            // 
            this.NewFileButton.Location = new System.Drawing.Point(12, 12);
            this.NewFileButton.Name = "NewFileButton";
            this.NewFileButton.Size = new System.Drawing.Size(360, 23);
            this.NewFileButton.TabIndex = 0;
            this.NewFileButton.Text = "新建文件选项";
            this.NewFileButton.UseVisualStyleBackColor = true;
            this.NewFileButton.Click += new System.EventHandler(this.NewFileButton_Click);
            // 
            // OtherButton
            // 
            this.OtherButton.Location = new System.Drawing.Point(12, 70);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(360, 23);
            this.OtherButton.TabIndex = 2;
            this.OtherButton.Text = "其他选项";
            this.OtherButton.UseVisualStyleBackColor = true;
            this.OtherButton.Click += new System.EventHandler(this.OtherButton_Click);
            // 
            // BuildTxtButton
            // 
            this.BuildTxtButton.Location = new System.Drawing.Point(12, 41);
            this.BuildTxtButton.Name = "BuildTxtButton";
            this.BuildTxtButton.Size = new System.Drawing.Size(360, 23);
            this.BuildTxtButton.TabIndex = 1;
            this.BuildTxtButton.Text = "build.txt选项";
            this.BuildTxtButton.UseVisualStyleBackColor = true;
            this.BuildTxtButton.Click += new System.EventHandler(this.BuildTxtButton_Click);
            // 
            // OldMainButton
            // 
            this.OldMainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OldMainButton.AutoSize = true;
            this.OldMainButton.Location = new System.Drawing.Point(12, 296);
            this.OldMainButton.Name = "OldMainButton";
            this.OldMainButton.Size = new System.Drawing.Size(115, 24);
            this.OldMainButton.TabIndex = 3;
            this.OldMainButton.Text = "切换到旧版界面";
            this.OldMainButton.UseVisualStyleBackColor = true;
            this.OldMainButton.Click += new System.EventHandler(this.OldMainButton_Click);
            // 
            // Other
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.OldMainButton);
            this.Controls.Add(this.BuildTxtButton);
            this.Controls.Add(this.OtherButton);
            this.Controls.Add(this.NewFileButton);
            this.Controls.Add(this.BackButton);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Other";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-git.Other";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NewFileButton;
        private System.Windows.Forms.Button OtherButton;
        private System.Windows.Forms.Button BuildTxtButton;
        private System.Windows.Forms.Button OldMainButton;
    }
}