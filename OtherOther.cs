using System;
using System.Windows.Forms;

namespace Test8
{
    public partial class OtherOther : Form
    {
        public OtherOther()
        {
            InitializeComponent();
        }

        private void OtherOther_Load(object sender, EventArgs e)
        {
            if (Program.Test8Object.OK != null)
            {
                OKClose.Checked = Program.Test8Object.OK[0];
                OKOpen.Checked = Program.Test8Object.OK[1];
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Test8Object.OK = new bool[]
            {
                OKClose.Checked,
                OKOpen.Checked
            };
            Program.NextType = Program.RunOther;
            Close();
        }

        private void BackDefault_Click(object sender, EventArgs e)
        {
            OKClose.Checked = false;
            OKOpen.Checked = true;
        }
    }
}