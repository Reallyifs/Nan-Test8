using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Test8
{
    public partial class Form1 : Form
    {
        private List<Control> Main;
        private List<Control> buildIgnore;
        private object[] buildIgnore_Extra;
        private List<Control> Other;
        private List<Control> Other_New;
        private List<Control> Other_buildtxt;
        private List<Control> Other_Other;
        private List<Control> Link;
        private List<Control> Link_Developer;

        private int Maintype = 0;

        public Form1()
        {
            InitializeComponent();
            Main = new List<Control>()
            {
                label1,
                label2,
                label3,
                label4,
                label5,
                linkLabel1,
                button1,
                button3,
                button4,
                textBox1,
                textBox2,
                textBox3,
                textBox4
            };
            buildIgnore = new List<Control>()
            {
                checkedListBox1,
                button5
            };
            buildIgnore_Extra = new object[]
            {
                @"Ignores/*",
                @"Instantiation/*",
                @"Libraries/*",
                @"Uselesses/*"
            };
            Other = new List<Control>()
            {
                button6,
                button8,
                button9
            };
            Other_buildtxt = new List<Control>()
            {
                checkBox6,
                checkBox7,
                checkBox8,
                checkBox9,
                label6,
                textBox5,
                button5
            };
            Other_New = new List<Control>()
            {
                checkBox2,
                checkBox3,
                checkBox4,
                button5
            };
            Other_Other = new List<Control>()
            {
                checkBox1,
                checkBox5,
                button5
            };
            Link = new List<Control>()
            {
                linkLabel2,
                linkLabel3,
                button7
            };
            Link_Developer = new List<Control>()
            {
                label7,
                label8
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            typeChange(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            typeChange(0, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Location = new Point((Width / 2) - (button2.Width / 2), (int)(((Height / 2) - (button2.Height / 2)) * 1.5));
            button3.Location = new Point((Width / 2) - (button3.Width / 2), (int)(((Height / 2) - (button3.Height / 2)) * 1.5));
            linkLabel2.Location = new Point((Width / 2) - (linkLabel2.Width / 2), ((Height / 2) - (linkLabel2.Height / 2)) / 3);
            linkLabel3.Location = new Point((Width / 2) - (linkLabel3.Width / 2), ((Height / 2) - (linkLabel3.Height / 2)) * 2 / 3);
            button7.Location = new Point((Width / 2) - (button7.Width / 2), (Height / 2) - (button7.Height / 2));
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
            checkedListBox1.Items.AddRange(buildIgnore_Extra);
            label7.Font = new Font(label7.Font.FontFamily, 20);
            label7.Text = "由实弑一人开发";
            label7.Location = new Point((Width / 2) - (label7.Width / 2), ((Height / 2) - (label7.Height / 2)) / 2);
            label8.Text = "什么\n你居然真的觉得会有人帮我吗\n草";
            label8.Location = new Point((Width / 2) - (label8.Width / 2), (Height / 2) - (label8.Height / 2));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chicken();
            FolderBrowserDialog dialog = new FolderBrowserDialog()
            {
                Description = "选择存放的文件夹，默认运行目录",
                SelectedPath = Directory.GetCurrentDirectory(),
                ShowNewFolderButton = true
            };
            dialog.ShowDialog();
            File.WriteAllLines($@"{dialog.SelectedPath}\README.md", new string[]
            {
                $"# {textBox1.Text}",
                $"",
                $"{textBox4.Text}",
                $"",
                $"Author: {textBox3.Text}",
                $"",
                $"Homepage: {textBox2.Text}"
            }, Encoding.UTF8);
            if (checkBox2.Checked)
            {
                List<string> ignoreText = new List<string>();
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    string s3 = checkedListBox1.CheckedItems[i].ToString();
                    if (s3 != "README.md" && s3 != @".git/*" && s3 != ".gitignore"&&s3!= ".gitattributes")
                        ignoreText.Add(checkedListBox1.CheckedItems[i].ToString());
                }
                File.WriteAllLines($@"{dialog.SelectedPath}\.gitignore", ignoreText.ToArray(), Encoding.UTF8);
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
                }, Encoding.UTF8);
            }
            if (checkBox1.Checked)
                Process.Start(dialog.SelectedPath);
            if (checkBox5.Checked)
                Close();
        }

        private void Chicken()
        {
            foreach(char c in textBox1.Text)
            {
                if (!char.IsLetterOrDigit(c))
                    throw new ArgumentException("Mod Name为你Mod的内部名称，请勿填写除数字和英文外的其他字符");
            }
            if (checkBox4.Checked)
            {
                if (!Version.TryParse(textBox5.Text, out _))
                    throw new ArgumentException("version不可转换，请重新填写");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            typeChange(0b10000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            typeChange(0b1000);
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
            switch (Maintype)
            {
                case 1:
                    {
                        for (int i = 0; i < buildIgnore_Extra.Length; i++)
                            checkedListBox1.Items.Remove(buildIgnore_Extra[i]);
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                            checkedListBox1.SetItemChecked(i, true);
                        checkedListBox1.Items.AddRange(buildIgnore_Extra);
                        break;
                    }
                case 0b1100:
                    {
                        checkBox6.Checked = checkBox7.Checked = true;
                        checkBox8.Checked = checkBox9.Checked = false;
                        textBox5.Text = "0.1.0.3";
                        break;
                    }
                case 0b1010:
                    {
                        checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = false;
                        break;
                    }
                case 0b1001:
                    {
                        checkBox1.Checked = checkBox5.Checked = false;
                        break;
                    }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            typeChange(0b1010);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            typeChange(0b1100);
        }

        private void typeChange(int maintype, bool button2Click = false)
        {
            foreach (Control control in Controls)
                control.Visible = false;
            if (button2Click)
            {
                switch (Maintype)
                {
                    case 1:
                    case 0b10000:
                        {
                            maintype = 0;
                            break;
                        }
                    case 0b1100:
                    case 0b1010:
                    case 0b1001:
                        {
                            maintype = 0b1000;
                            break;
                        }
                    case 0b11000:
                        {
                            maintype = 0b10000;
                            break;
                        }
                }
            }
            switch (maintype)
            {
                case 0:
                    {
                        foreach (Control control in Main)
                            control.Visible = true;
                        break;
                    }
                case 1:
                    {
                        foreach (Control control in buildIgnore)
                            control.Visible = true;
                        break;
                    }
                case 0b1000:
                    {
                        foreach (Control control in Other)
                            control.Visible = true;
                        break;
                    }
                case 0b1100:
                    {
                        foreach (Control control in Other_buildtxt)
                            control.Visible = true;
                        break;
                    }
                case 0b1010:
                    {
                        foreach (Control control in Other_New)
                            control.Visible = true;
                        break;
                    }
                case 0b1001:
                    {
                        foreach (Control control in Other_Other)
                            control.Visible = true;
                        break;
                    }
                case 0b10000:
                    {
                        foreach (Control control in Link)
                            control.Visible = true;
                        break;
                    }
                case 0b11000:
                    {
                        foreach (Control control in Link_Developer)
                            control.Visible = true;
                        break;
                    }
            }
            Maintype = maintype;
            button2.Visible = maintype != 0;
            button3.Visible = maintype == 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            typeChange(0b1001);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            typeChange(0b11000);
        }
    }
}