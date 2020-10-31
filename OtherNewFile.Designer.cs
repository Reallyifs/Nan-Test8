namespace Test8
{
    partial class OtherNewFile
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
            this.NewBuild = new System.Windows.Forms.CheckBox();
            this.NewGitignore = new System.Windows.Forms.CheckBox();
            this.NewDescription = new System.Windows.Forms.CheckBox();
            this.BackDefault = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NewREADME = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NewBuild
            // 
            this.NewBuild.AutoSize = true;
            this.NewBuild.Location = new System.Drawing.Point(12, 12);
            this.NewBuild.Name = "NewBuild";
            this.NewBuild.Size = new System.Drawing.Size(117, 18);
            this.NewBuild.TabIndex = 0;
            this.NewBuild.Text = "New build.txt";
            this.NewBuild.UseVisualStyleBackColor = true;
            // 
            // NewGitignore
            // 
            this.NewGitignore.AutoSize = true;
            this.NewGitignore.Checked = true;
            this.NewGitignore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewGitignore.Location = new System.Drawing.Point(12, 60);
            this.NewGitignore.Name = "NewGitignore";
            this.NewGitignore.Size = new System.Drawing.Size(124, 18);
            this.NewGitignore.TabIndex = 2;
            this.NewGitignore.Text = "New .gitignore";
            this.NewGitignore.UseVisualStyleBackColor = true;
            // 
            // NewDescription
            // 
            this.NewDescription.AutoSize = true;
            this.NewDescription.Location = new System.Drawing.Point(12, 36);
            this.NewDescription.Name = "NewDescription";
            this.NewDescription.Size = new System.Drawing.Size(159, 18);
            this.NewDescription.TabIndex = 1;
            this.NewDescription.Text = "New description.txt";
            this.NewDescription.UseVisualStyleBackColor = true;
            // 
            // BackDefault
            // 
            this.BackDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackDefault.Location = new System.Drawing.Point(297, 326);
            this.BackDefault.Name = "BackDefault";
            this.BackDefault.Size = new System.Drawing.Size(75, 23);
            this.BackDefault.TabIndex = 5;
            this.BackDefault.Text = "返回默认";
            this.BackDefault.UseVisualStyleBackColor = true;
            this.BackDefault.Click += new System.EventHandler(this.BackDefault_Click);
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
            // NewREADME
            // 
            this.NewREADME.AutoSize = true;
            this.NewREADME.Checked = true;
            this.NewREADME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewREADME.Location = new System.Drawing.Point(12, 84);
            this.NewREADME.Name = "NewREADME";
            this.NewREADME.Size = new System.Drawing.Size(117, 18);
            this.NewREADME.TabIndex = 3;
            this.NewREADME.Text = "New README.md";
            this.NewREADME.UseVisualStyleBackColor = true;
            // 
            // OtherNewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.NewREADME);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.BackDefault);
            this.Controls.Add(this.NewDescription);
            this.Controls.Add(this.NewGitignore);
            this.Controls.Add(this.NewBuild);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "OtherNewFile";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-git.Other.NewFile";
            this.Load += new System.EventHandler(this.OtherNewFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NewBuild;
        private System.Windows.Forms.CheckBox NewGitignore;
        private System.Windows.Forms.CheckBox NewDescription;
        private System.Windows.Forms.Button BackDefault;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.CheckBox NewREADME;
    }
}