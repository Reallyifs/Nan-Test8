using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Test8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
                control.Visible = false;
            checkedListBox1.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
                control.Visible = true;
            foreach (Control control in Controls)
            {
                if (control.Name.Contains("checkBox"))
                    control.Visible = false;
            }
            checkedListBox1.Visible = false;
            button2.Visible = false;
            label6.Visible = false;
            textBox5.Visible = false;
            linkLabel2.Visible = false;
            linkLabel3.Visible = false;
            button5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Location = new Point((Width / 2) - (button2.Width / 2), (int)(((Height / 2) - (button2.Height / 2)) * 1.5));
            button3.Location = new Point((Width / 2) - (button3.Width / 2), (int)(((Height / 2) - (button3.Height / 2)) * 1.5));
            linkLabel2.Location = new Point((Width / 2) - (linkLabel2.Width / 2), ((Height / 2) - (linkLabel2.Height / 2)) / 2);
            linkLabel3.Location = new Point((Width / 2) - (linkLabel3.Width / 2), (Height / 2) - (linkLabel3.Height / 2));
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
            checkedListBox1.Items.AddRange(new object[]
            {
                @"Ignores/*",
                @"Instantiation/*",
                @"Libraries/*",
                @"Uselesses/*"
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                Description = "选择存放的文件夹，默认运行目录",
                SelectedPath = Directory.GetCurrentDirectory(),
                ShowNewFolderButton = true
            };
            dialog.ShowDialog();
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (!char.IsLetterOrDigit(textBox1.Text[i]))
                {
                    string s1 = textBox1.Text.Substring(0, i);
                    string s2 = textBox1.Text.Substring(i + 1);
                    textBox1.Text = s1 + s2;
                    i = 0;
                }
            }
            if (!Version.TryParse(textBox5.Text, out _))
                textBox5.Text = "0.1.0.0";
            File.WriteAllLines($@"{dialog.SelectedPath}\README.md", new string[]
            {
                $"# {textBox1.Text}",
                $"",
                $"{textBox4.Text}",
                $"",
                $"Author: {textBox3.Text}",
                $"",
                $"Homepage: {textBox2.Text}"
            });
            if (checkBox2.Checked)
            {
                List<string> ignoreText = new List<string>();
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    string s3 = checkedListBox1.CheckedItems[i].ToString();
                    if (s3 != "README.md" && s3 != @".git/*" && s3 != ".gitignore")
                        ignoreText.Add(checkedListBox1.CheckedItems[i].ToString());
                }
                File.WriteAllLines($@"{dialog.SelectedPath}\.gitignore", ignoreText.ToArray());
            }
            if (checkBox3.Checked)
            {
                File.WriteAllLines($@"{dialog.SelectedPath}\description.txt", new string[]
                {
                    $"{textBox4.Text}",
                    $"Author: {textBox3.Text}"
                });
            }
            if (checkBox4.Checked)
            {
                string ignoreText = "";
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    if (i != 0)
                        ignoreText += ", ";
                    ignoreText += checkedListBox1.CheckedItems[i];
                }
                File.WriteAllLines($@"{dialog.SelectedPath}\build.txt", new string[]
                {
                    $@"author = {textBox3.Text}",
                    $@"version = {textBox5.Text}",
                    $@"hideCode = {checkBox6.Checked.ToString().ToLower()}",
                    $@"homepage = {textBox2.Text}",
                    $@"includePDB = {checkBox8.Checked.ToString().ToLower()}",
                    $@"buildIgnore = {ignoreText.Replace('/', '\\')}",
                    $@"displayName = {textBox4.Text}",
                    $@"hideResources = {checkBox7.Checked.ToString().ToLower()}",
                    $@"includeSource = {checkBox9.Checked.ToString().ToLower()}"
                });
            }
            if (checkBox1.Checked)
                Process.Start(dialog.SelectedPath);
            if (checkBox5.Checked)
                Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Control control in Controls)
                control.Visible = false;
            linkLabel2.Visible = true;
            linkLabel3.Visible = true;
            button2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
                control.Visible = false;
            foreach (Control control in Controls)
            {
                if (control.Name.Contains("checkBox"))
                    control.Visible = true;
            }
            button2.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
            button5.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/Reallyifs/Nan-Test8");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://reallyifs.coding.net/public/Nan-Test8/master/git/files");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0.1.0.2";
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox5.Checked = false;
            checkBox4.Checked = false;
            checkBox6.Checked = true;
            checkBox8.Checked = false;
            checkBox7.Checked = true;
            checkBox9.Checked = false;
        }
    }
}