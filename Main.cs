using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test8
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Program.NextType = Program.RunOut;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SureAboutThat.Location = new Point(Width / 2 - SureAboutThat.Width / 2, (int)((Height / 2 - SureAboutThat.Height / 2) * 1.625));
        }

        private void BuildIgnoreButton_Click(object sender, EventArgs e) => TypeChange(Program.RunBuildIgnore);

        private void TypeChange(string typeTo)
        {
            Program.NextType = typeTo;
            Close();
        }

        private void OtherButton_Click(object sender, EventArgs e) => TypeChange(Program.RunOther);

        private void SourceLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => TypeChange(Program.RunLink);

        private void SureAboutThat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认开始吗？", "Ah-bliskKata", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.Test8Object.Information = new string[]
                {
                    DisplayName.Text,
                    Author.Text,
                    Homepage.Text
                };
                TypeChange(Program.RunSureAboutThat);
            }
        }
    }
}