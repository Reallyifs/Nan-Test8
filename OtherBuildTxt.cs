using System;
using System.Windows.Forms;

namespace Test8
{
    public partial class OtherBuildTxt : Form
    {
        public OtherBuildTxt()
        {
            InitializeComponent();
        }

        private void OtherBuildTxt_Load(object sender, EventArgs e)
        {
            if (Program.Test8Object.BuildVersion != null)
            {
                Major.Value = Program.Test8Object.BuildVersion.Major;
                Minor.Value = Program.Test8Object.BuildVersion.Minor;
                Build.Value = Program.Test8Object.BuildVersion.Build;
                Major.Value = Program.Test8Object.BuildVersion.Revision;
            }
            if (Program.Test8Object.BuildCheck != null)
            {
                HideCode.Checked = Program.Test8Object.BuildCheck[0].Checked;
                HideResources.Checked = Program.Test8Object.BuildCheck[1].Checked;
                IncludePDB.Checked = Program.Test8Object.BuildCheck[2].Checked;
                IncludeSource.Checked = Program.Test8Object.BuildCheck[3].Checked;
            }
            HideCodeT.SetToolTip(HideCode, Program.Test8Object.StringTooltip.HideCodeTooltip);
            HideResourcesT.SetToolTip(HideResources, Program.Test8Object.StringTooltip.HideResourcesTooltip);
            IncludePDBT.SetToolTip(IncludePDB, Program.Test8Object.StringTooltip.IncludePDBTooltip);
            IncludeSourceT.SetToolTip(IncludeSource, Program.Test8Object.StringTooltip.IncludeSourceTooltip);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Test8Object.BuildVersion = new Version((int)Major.Value, (int)Minor.Value, (int)Build.Value, (int)Revision.Value);
            Program.Test8Object.BuildCheck = new CheckBox[]
            {
                HideCode,
                HideResources,
                IncludePDB,
                IncludeSource
            };
            Program.NextType = Program.RunOther;
            Close();
        }

        private void BackDefault_Click(object sender, EventArgs e)
        {
            Major.Value = Build.Value = Revision.Value = 0;
            Minor.Value = 1;
            HideCode.Checked = HideResources.Checked = true;
            IncludePDB.Checked = IncludeSource.Checked = false;
        }
    }
}