using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Test8
{
    static class Program
    {
        public static string NextType;

        public const string RunOut = "Get Out";
        public const string RunMain = "Run Mian";
        public const string RunOldMain = "Wanna Cheees";
        public const string RunBuildIgnore = "Damn Ignore";
        public const string RunLink = "I want to take your source";
        public const string RunOther = "Ni Zhi Dao Ma";
        public const string RunOtherOther = "Wo Bu Zhi Dao";
        public const string RunOtherNewFile = "New File FFF";
        public const string RunOtherBuildTxt = "Build Txt Please";
        public const string RunSureAboutThat = "Hvnny vp";

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            typeof(Test8Object).GetFields().ToList().ForEach(delegate (FieldInfo info) { info.SetValue(null, null); });

            RunMain:
            Application.Run(new Main());
            goto NextGet;

            RunOldMain:
            Application.Run(new Cheees());
            goto NextGet;

            RunBuildIgnore:
            Application.Run(new BuildIgnore());
            goto NextGet;

            RunLink:
            Application.Run(new Link());
            goto NextGet;

            RunOther:
            Application.Run(new Other());
            goto NextGet;

            RunOtherOther:
            Application.Run(new OtherOther());
            goto NextGet;

            RunOtherNewFile:
            Application.Run(new OtherNewFile());
            goto NextGet;

            RunOtherBuildTxt:
            Application.Run(new OtherBuildTxt());
            goto NextGet;

            NextGet:
            switch (NextType)
            {
                case RunOut:
                    return;
                case RunMain:
                    goto RunMain;
                case RunOldMain:
                    goto RunOldMain;
                case RunBuildIgnore:
                    goto RunBuildIgnore;
                case RunLink:
                    goto RunLink;
                case RunOther:
                    goto RunOther;
                case RunOtherOther:
                    goto RunOtherOther;
                case RunOtherNewFile:
                    goto RunOtherNewFile;
                case RunOtherBuildTxt:
                    goto RunOtherBuildTxt;
                case RunSureAboutThat:
                    {
                        FolderBrowserDialog dialog = new FolderBrowserDialog()
                        {
                            Description = "选择存放的文件夹，默认运行目录",
                            SelectedPath = Directory.GetCurrentDirectory(),
                            ShowNewFolderButton = true
                        };
                        dialog.ShowDialog();
                        if (Test8Object.NewFile[2])
                        {
                            List<string> ignoreText = new List<string>();
                            for (int i = 0; i < Test8Object.IgnoreListBox.CheckedItems.Count; i++)
                            {
                                string iText = Test8Object.IgnoreListBox.CheckedItems[i].ToString();
                                if (iText != "README.md" && iText != @".git/*" && iText != ".gitignore" && iText != ".gitattributes")
                                    ignoreText.Add(iText);
                            }
                            File.WriteAllLines($@"{dialog.SelectedPath}\.gitignore", ignoreText.ToArray(), Encoding.UTF8);
                        }
                        if (Test8Object.NewFile[3])
                        {
                            string[] READ = new string[]
                            {
                                $"# {Test8Object.Information[0]}",
                                $"Made by {Test8Object.Information[1]}",
                                $"",
                                $"Homepage: {Test8Object.Information[2]}"
                            };
                            File.WriteAllLines($@"{dialog.SelectedPath}\README.md", READ, Encoding.UTF8);
                        }
                        if (Test8Object.NewFile[1])
                        {
                            File.WriteAllLines($@"{dialog.SelectedPath}\description.txt", new string[]
                            {
                                $"{Test8Object.Information[0]}",
                                $"Author: {Test8Object.Information[1]}",
                                $"Version: {Test8Object.BuildVersion}"
                            }, Encoding.UTF8);
                        }
                        if (Test8Object.NewFile[0])
                        {
                            string ignoreText = "";
                            for (int i = 0; i < Test8Object.IgnoreListBox.CheckedItems.Count; i++)
                            {
                                if (i != 0)
                                    ignoreText += ", ";
                                ignoreText += Test8Object.IgnoreListBox.CheckedItems[i];
                            }
                            File.WriteAllLines($@"{dialog.SelectedPath}\build.txt", new string[]
                            {
                                $@"author = {Test8Object.Information[1]}",
                                $@"version = {Test8Object.BuildVersion}",
                                $@"hideCode = {Test8Object.BuildCheck[0].Checked.ToString().ToLower()}",
                                $@"homepage = {Test8Object.Information[2]}",
                                $@"includePDB = {Test8Object.BuildCheck[2].ToString().ToLower()}",
                                $@"buildIgnore = {ignoreText.Replace('/', '\\')}",
                                $@"displayName = {Test8Object.Information[0]}",
                                $@"hideResources = {Test8Object.BuildCheck[1].Checked.ToString().ToLower()}",
                                $@"includeSource = {Test8Object.BuildCheck[3].Checked.ToString().ToLower()}"
                            }, Encoding.UTF8);
                        }
                        if (Test8Object.OK[1])
                            Process.Start(dialog.SelectedPath);
                        if (Test8Object.OK[0])
                            return;
                        break;
                    }
            }
        }

        public static class Test8Object
        {
            public static bool[] OK;
            public static bool[] NewFile;
            public static string[] Information;
            public static Version BuildVersion;
            public static CheckBox[] BuildCheck;
            public static CheckedListBox IgnoreListBox;

            public static class StringTooltip
            {
                public const string HideCodeTooltip = "If true, the unpacked mod that results from using the extract mod option will not include .dll files (compiled code) or .cs files (source code).\n" +
                    "如果此项设置为 true，则使用解压缩Mod选项生成的源码将不包括任何.dll文件（编译代码）和.cs文件（源代码）。";
                public const string HideResourcesTooltip = "If true, the unpacked mod that results from using the extract mod option will not include resource files, such as .png files and .wav files.\n" +
                    "Do not use this if you would like to have your sounds and images freely available to other modders.\n" +
                    "Note that this does not apply to .dll or .cs files (use hideCode and includeSource).\n" +
                    "如果此项设置为 true，则使用解压缩Mod选项生成的源码将不包括资源文件，例如.png文件和.wav文件。\n" +
                    "如果您不想让其他制作Mod的人免费使用你的声音和图像，请使用此功能。\n" +
                    "请注意，这不适用于.dll或.cs文件（使用hideCode和includeSource）。";
                public const string IncludePDBTooltip = "If true, line numbers in exceptions and stack traces will appear if the mod experiences problems.\n" +
                    "Also, Edit and Continue using Visual Studio is possible.\n" +
                    "如果此项设置为 true，则在Mod遇到问题时将显示异常和堆栈跟踪中的行号。\n" +
                    "此外，还可以使用Visual Studio继续编辑。";
                public const string IncludeSourceTooltip = "If true, the unpacked mod that results from using the extract mod option will include .cs files.\n" +
                    "Use this if you would like to share your code freely (make sure to set hideCode to false).\n" +
                    "如果此项设置为 true，则使用解压缩Mod选项生成的源码将包括.cs文件。\n" +
                    "如果您想自由共享代码（请确保将hideCode设置为false），请使用此选项。";
            }
        }
    }
}