namespace Test8
{
    partial class OtherOther
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
            this.OKClose = new System.Windows.Forms.CheckBox();
            this.OKOpen = new System.Windows.Forms.CheckBox();
            this.BackDefault = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OKClose
            // 
            this.OKClose.AutoSize = true;
            this.OKClose.Location = new System.Drawing.Point(12, 12);
            this.OKClose.Name = "OKClose";
            this.OKClose.Size = new System.Drawing.Size(96, 18);
            this.OKClose.TabIndex = 0;
            this.OKClose.Text = "完成后关闭";
            this.OKClose.UseVisualStyleBackColor = true;
            // 
            // OKOpen
            // 
            this.OKOpen.AutoSize = true;
            this.OKOpen.Checked = true;
            this.OKOpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OKOpen.Location = new System.Drawing.Point(12, 36);
            this.OKOpen.Name = "OKOpen";
            this.OKOpen.Size = new System.Drawing.Size(138, 18);
            this.OKOpen.TabIndex = 1;
            this.OKOpen.Text = "完成后打开文件夹";
            this.OKOpen.UseVisualStyleBackColor = true;
            // 
            // BackDefault
            // 
            this.BackDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackDefault.Location = new System.Drawing.Point(297, 326);
            this.BackDefault.Name = "BackDefault";
            this.BackDefault.Size = new System.Drawing.Size(75, 23);
            this.BackDefault.TabIndex = 3;
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
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "返回";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OtherOther
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.BackDefault);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OKOpen);
            this.Controls.Add(this.OKClose);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "OtherOther";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-git.Other.Other";
            this.Load += new System.EventHandler(this.OtherOther_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox OKClose;
        private System.Windows.Forms.CheckBox OKOpen;
        private System.Windows.Forms.Button BackDefault;
        private System.Windows.Forms.Button BackButton;
    }
}