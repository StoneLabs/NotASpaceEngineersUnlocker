using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SpaceEngineersUnlocker
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
                    PathText.Text = fbd.SelectedPath;

                    files = Directory.GetFiles(fbd.SelectedPath, "*.sbc", SearchOption.AllDirectories);

                    System.Windows.Forms.MessageBox.Show($"{files.Length} Space Engineers files found. Press Unlock to start.");
                }
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
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
                progressBar.Value = current / total * 100;
            }

            System.Windows.Forms.MessageBox.Show($"{files.Length} files changed. You can now close the application.");
        }
    }
}
