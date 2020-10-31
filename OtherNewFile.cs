using System;
using System.Windows.Forms;

namespace Test8
{
    public partial class OtherNewFile : Form
    {
        public OtherNewFile()
        {
            InitializeComponent();
        }

        private void OtherNewFile_Load(object sender, EventArgs e)
        {
            if (Program.Test8Object.NewFile != null)
            {
                NewBuild.Checked = Program.Test8Object.NewFile[0];
                NewDescription.Checked = Program.Test8Object.NewFile[1];
                NewGitignore.Checked = Program.Test8Object.NewFile[2];
                NewREADME.Checked = Program.Test8Object.NewFile[3];
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Test8Object.NewFile = new bool[]
            {
                NewBuild.Checked,
                NewDescription.Checked,
                NewGitignore.Checked,
                NewREADME.Checked
            };
            Program.NextType = Program.RunOther;
            Close();
        }

        private void BackDefault_Click(object sender, EventArgs e)
        {
            NewBuild.Checked = NewDescription.Checked = false;
            NewGitignore.Checked = true;
        }
    }
}