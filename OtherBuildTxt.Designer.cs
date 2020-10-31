namespace Test8
{
    partial class OtherBuildTxt
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
            this.components = new System.ComponentModel.Container();
            this.IncludePDB = new System.Windows.Forms.CheckBox();
            this.IncludeSource = new System.Windows.Forms.CheckBox();
            this.HideResources = new System.Windows.Forms.CheckBox();
            this.HideCode = new System.Windows.Forms.CheckBox();
            this.BuildVersion = new System.Windows.Forms.Label();
            this.Major = new System.Windows.Forms.NumericUpDown();
            this.BackButton = new System.Windows.Forms.Button();
            this.MajorL = new System.Windows.Forms.Label();
            this.MinorL = new System.Windows.Forms.Label();
            this.Minor = new System.Windows.Forms.NumericUpDown();
            this.Build = new System.Windows.Forms.NumericUpDown();
            this.BuildL = new System.Windows.Forms.Label();
            this.RevisionL = new System.Windows.Forms.Label();
            this.Revision = new System.Windows.Forms.NumericUpDown();
            this.BackDefault = new System.Windows.Forms.Button();
            this.HideCodeT = new System.Windows.Forms.ToolTip(this.components);
            this.HideResourcesT = new System.Windows.Forms.ToolTip(this.components);
            this.IncludeSourceT = new System.Windows.Forms.ToolTip(this.components);
            this.IncludePDBT = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Major)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Build)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Revision)).BeginInit();
            this.SuspendLayout();
            // 
            // IncludePDB
            // 
            this.IncludePDB.AutoSize = true;
            this.IncludePDB.Location = new System.Drawing.Point(12, 60);
            this.IncludePDB.Name = "IncludePDB";
            this.IncludePDB.Size = new System.Drawing.Size(103, 18);
            this.IncludePDB.TabIndex = 2;
            this.IncludePDB.Text = "Include PDB";
            this.IncludePDB.UseVisualStyleBackColor = true;
            // 
            // IncludeSource
            // 
            this.IncludeSource.AutoSize = true;
            this.IncludeSource.Location = new System.Drawing.Point(12, 84);
            this.IncludeSource.Name = "IncludeSource";
            this.IncludeSource.Size = new System.Drawing.Size(124, 18);
            this.IncludeSource.TabIndex = 3;
            this.IncludeSource.Text = "Include Source";
            this.IncludeSource.UseVisualStyleBackColor = true;
            // 
            // HideResources
            // 
            this.HideResources.AutoSize = true;
            this.HideResources.Checked = true;
            this.HideResources.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideResources.Location = new System.Drawing.Point(12, 36);
            this.HideResources.Name = "HideResources";
            this.HideResources.Size = new System.Drawing.Size(124, 18);
            this.HideResources.TabIndex = 1;
            this.HideResources.Text = "Hide Resources";
            this.HideResources.UseVisualStyleBackColor = true;
            // 
            // HideCode
            // 
            this.HideCode.AutoSize = true;
            this.HideCode.Checked = true;
            this.HideCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HideCode.Location = new System.Drawing.Point(12, 12);
            this.HideCode.Name = "HideCode";
            this.HideCode.Size = new System.Drawing.Size(89, 18);
            this.HideCode.TabIndex = 0;
            this.HideCode.Text = "Hide Code";
            this.HideCode.UseVisualStyleBackColor = true;
            // 
            // BuildVersion
            // 
            this.BuildVersion.AutoSize = true;
            this.BuildVersion.Location = new System.Drawing.Point(9, 110);
            this.BuildVersion.Name = "BuildVersion";
            this.BuildVersion.Size = new System.Drawing.Size(63, 14);
            this.BuildVersion.TabIndex = 0;
            this.BuildVersion.Text = "Version:";
            // 
            // Major
            // 
            this.Major.AutoSize = true;
            this.Major.Location = new System.Drawing.Point(154, 108);
            this.Major.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(51, 23);
            this.Major.TabIndex = 4;
            this.Major.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.AutoSize = true;
            this.BackButton.Location = new System.Drawing.Point(12, 325);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 24);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "返回";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MajorL
            // 
            this.MajorL.AutoSize = true;
            this.MajorL.Location = new System.Drawing.Point(99, 110);
            this.MajorL.Name = "MajorL";
            this.MajorL.Size = new System.Drawing.Size(49, 14);
            this.MajorL.TabIndex = 0;
            this.MajorL.Text = "Major:";
            // 
            // MinorL
            // 
            this.MinorL.AutoSize = true;
            this.MinorL.Location = new System.Drawing.Point(99, 139);
            this.MinorL.Name = "MinorL";
            this.MinorL.Size = new System.Drawing.Size(49, 14);
            this.MinorL.TabIndex = 0;
            this.MinorL.Text = "Minor:";
            // 
            // Minor
            // 
            this.Minor.AutoSize = true;
            this.Minor.Location = new System.Drawing.Point(154, 137);
            this.Minor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Minor.Name = "Minor";
            this.Minor.Size = new System.Drawing.Size(51, 23);
            this.Minor.TabIndex = 5;
            this.Minor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Minor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Build
            // 
            this.Build.AutoSize = true;
            this.Build.Location = new System.Drawing.Point(154, 166);
            this.Build.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(51, 23);
            this.Build.TabIndex = 6;
            this.Build.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BuildL
            // 
            this.BuildL.AutoSize = true;
            this.BuildL.Location = new System.Drawing.Point(99, 168);
            this.BuildL.Name = "BuildL";
            this.BuildL.Size = new System.Drawing.Size(49, 14);
            this.BuildL.TabIndex = 0;
            this.BuildL.Text = "Build:";
            // 
            // RevisionL
            // 
            this.RevisionL.AutoSize = true;
            this.RevisionL.Location = new System.Drawing.Point(78, 197);
            this.RevisionL.Name = "RevisionL";
            this.RevisionL.Size = new System.Drawing.Size(70, 14);
            this.RevisionL.TabIndex = 0;
            this.RevisionL.Text = "Revision:";
            // 
            // Revision
            // 
            this.Revision.AutoSize = true;
            this.Revision.Location = new System.Drawing.Point(154, 195);
            this.Revision.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.Revision.Name = "Revision";
            this.Revision.Size = new System.Drawing.Size(51, 23);
            this.Revision.TabIndex = 7;
            this.Revision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackDefault
            // 
            this.BackDefault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackDefault.Location = new System.Drawing.Point(297, 326);
            this.BackDefault.Name = "BackDefault";
            this.BackDefault.Size = new System.Drawing.Size(75, 23);
            this.BackDefault.TabIndex = 9;
            this.BackDefault.Text = "返回默认";
            this.BackDefault.UseVisualStyleBackColor = true;
            this.BackDefault.Click += new System.EventHandler(this.BackDefault_Click);
            // 
            // HideCodeT
            // 
            this.HideCodeT.AutomaticDelay = 1000;
            this.HideCodeT.ToolTipTitle = "Hide Code - 隐藏代码";
            // 
            // HideResourcesT
            // 
            this.HideResourcesT.AutomaticDelay = 1000;
            this.HideResourcesT.ToolTipTitle = "Hide Resources - 隐藏资源";
            // 
            // IncludeSourceT
            // 
            this.IncludeSourceT.AutomaticDelay = 1000;
            this.IncludeSourceT.ToolTipTitle = "Include Source - 包含代码";
            // 
            // IncludePDBT
            // 
            this.IncludePDBT.AutomaticDelay = 1000;
            this.IncludePDBT.ToolTipTitle = "Include PDB - 包含程序数据库";
            // 
            // OtherBuildTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.BackDefault);
            this.Controls.Add(this.RevisionL);
            this.Controls.Add(this.Revision);
            this.Controls.Add(this.BuildL);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Minor);
            this.Controls.Add(this.MinorL);
            this.Controls.Add(this.MajorL);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.BuildVersion);
            this.Controls.Add(this.HideCode);
            this.Controls.Add(this.HideResources);
            this.Controls.Add(this.IncludeSource);
            this.Controls.Add(this.IncludePDB);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximumSize = new System.Drawing.Size(400, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "OtherBuildTxt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto-git.Other.BuildTxt";
            this.Load += new System.EventHandler(this.OtherBuildTxt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Major)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Build)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Revision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IncludePDB;
        private System.Windows.Forms.CheckBox IncludeSource;
        private System.Windows.Forms.CheckBox HideResources;
        private System.Windows.Forms.CheckBox HideCode;
        private System.Windows.Forms.Label BuildVersion;
        private System.Windows.Forms.NumericUpDown Major;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label MajorL;
        private System.Windows.Forms.Label MinorL;
        private System.Windows.Forms.NumericUpDown Minor;
        private System.Windows.Forms.NumericUpDown Build;
        private System.Windows.Forms.Label BuildL;
        private System.Windows.Forms.Label RevisionL;
        private System.Windows.Forms.NumericUpDown Revision;
        private System.Windows.Forms.Button BackDefault;
        private System.Windows.Forms.ToolTip HideCodeT;
        private System.Windows.Forms.ToolTip HideResourcesT;
        private System.Windows.Forms.ToolTip IncludeSourceT;
        private System.Windows.Forms.ToolTip IncludePDBT;
    }
}