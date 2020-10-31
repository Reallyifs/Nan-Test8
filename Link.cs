using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Test8
{
    public partial class Link : Form
    {
        public Link()
        {
            InitializeComponent();
        }

        private void Link_Load(object sender, EventArgs e)
        {
            GithubLink.Location = new Point((Width / 2) - (GithubLink.Width / 2), (((Height / 2) - (GithubLink.Height / 2)) / 2) - 50);
            CodingLink.Location = new Point((Width / 2) - (CodingLink.Width / 2), (Height / 2) - (CodingLink.Height / 2) - 50);
            L1.Text = "由实弑一人开发";
            L1.Font = new Font(L1.Font.FontFamily, 20);
            L1.Location = new Point((Width / 2) - (L1.Width / 2), (int)(((Height / 2) - (L1.Height / 2)) * 1.5) - 50);
            L2.Text = "怎么可能会有人帮嘛.jpg";
            L2.Font = new Font(L2.Font.FontFamily, 5);
            L2.Location = new Point((Width / 2) - (L2.Width / 2), L1.Location.Y + L1.Height);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.NextType = Program.RunMain;
            Close();
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Reallyifs/Nan-Test8");
        }

        private void CodingLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://reallyifs.coding.net/public/Nan-Test8/master/git/files");
        }
    }
}