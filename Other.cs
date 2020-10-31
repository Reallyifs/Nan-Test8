using System;
using System.Windows.Forms;

namespace Test8
{
    public partial class Other : Form
    {
        public Other()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e) => TypeChange(Program.RunMain);

        private void BuildTxtButton_Click(object sender, EventArgs e) => TypeChange(Program.RunOtherBuildTxt);

        private void TypeChange(string typeTo)
        {
            Program.NextType = typeTo;
            Close();
        }

        private void NewFileButton_Click(object sender, EventArgs e) => TypeChange(Program.RunOtherNewFile);

        private void OtherButton_Click(object sender, EventArgs e) => TypeChange(Program.RunOtherOther);

        private void OldMainButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要切换吗？你所做的一切都不会被保存！", "草", MessageBoxButtons.YesNo) == DialogResult.Yes)
                TypeChange(Program.RunOldMain);
        }
    }
}