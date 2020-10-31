using System.Linq;
using System.Windows.Forms;

namespace Test8
{
    public partial class BuildIgnore : Form
    {
        private readonly string[] BuildIgnoreExtra;

        public BuildIgnore()
        {
            InitializeComponent();
            BuildIgnoreExtra = new string[]
            {
                @".dll",
                @"Ignores/*",
                @"Instantiation/*",
                @"lib/*",
                @"Libraries/*",
                @"Uselesses/*"
            };
        }

        private void BuildIgnore_Load(object sender, System.EventArgs e)
        {
            for (int i = 0; i < IgnoreList.Items.Count; i++)
                IgnoreList.SetItemChecked(i, true);
            IgnoreList.Items.AddRange(BuildIgnoreExtra);
            if (Program.Test8Object.IgnoreListBox != null)
            {
                IgnoreList.Items.Clear();
                for (int i = 0; i < Program.Test8Object.IgnoreListBox.Items.Count; i++)
                {
                    IgnoreList.Items.Add(Program.Test8Object.IgnoreListBox.Items[i]);
                    if (Program.Test8Object.IgnoreListBox.CheckedItems.Contains(Program.Test8Object.IgnoreListBox.Items[i]))
                        IgnoreList.SetItemChecked(i, true);
                }
            }
        }

        private void BackButton_Click(object sender, System.EventArgs e)
        {
            Program.NextType = Program.RunMain;
            Program.Test8Object.IgnoreListBox = IgnoreList;
            Close();
        }

        private void BackDefault_Click(object sender, System.EventArgs e)
        {
            for (int i = 0; i < IgnoreList.Items.Count; i++)
            {
                IgnoreList.SetItemChecked(i, true);
                if (BuildIgnoreExtra.ToList().Contains((string)IgnoreList.Items[i]))
                    IgnoreList.SetItemChecked(i, false);
            }
        }
    }
}