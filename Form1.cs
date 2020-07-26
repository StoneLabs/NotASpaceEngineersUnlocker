using SpaceEngineersUnlocker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NotASpaceEngineersUnlocker
{
    public partial class MainForm : Form
    {
        string[] files = { };

        public MainForm()
        {
            InitializeComponent();
        }

        private void PathOpen_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                    SearchOption option = SearchOption.TopDirectoryOnly;

                    DialogResult dialogResult = MessageBox.Show("Would you like to look for sbc files in sub folders?", "Recursive Search", MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                        option = SearchOption.AllDirectories;
                    else if (dialogResult != DialogResult.No)
                    {
                        System.Windows.Forms.MessageBox.Show($"Operation aboted!");
                        return;
                    }

                    files = Directory.GetFiles(fbd.SelectedPath, "*.sbc", option).Where(f => f.EndsWith(".sbc")).ToArray();
                    PathText.Text = fbd.SelectedPath;

                    ConfirmButton.Enabled = true;

                    System.Windows.Forms.MessageBox.Show(
                        $"{files.Length} Space Engineers .sbc files found in directory (non-recursive).\n" +
                        $"Press Unlock to start.");
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                int total = files.Length;
                int current = 0;
                foreach (var file in files)
                {
                    // Replace string
                    string text = File.ReadAllText(file);
                    text = Regex.Replace(text, @"<(dlc|DLC)>[\w\d\s]*<\/(dlc|DLC)>", "");
                    File.WriteAllText(file, text);

                    // Update progress bar
                    current++;
                    ThreadHelperClass.SetValue(this, progressBar, current * 100 / total );
                }
                System.Windows.Forms.MessageBox.Show($"{files.Length} files changed. You can now close the application.");
            }).Start();

        }
    }
}
