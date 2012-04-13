using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace SteamExtend
{
       
    public partial class Form1 : Form
    {
        DirectoryInfo Source, Dest;

        public Form1()
        {
            InitializeComponent();
        }

        private void updateTextBox()
        {
            if (Source != null)
            {
                textBoxSteamSource.Text = Source.FullName;
            }
            else
            {
                textBoxSteamSource.Text = "";
            }
            if (Dest != null)
            {
                textBoxSteamDest.Text = Dest.FullName;
            }
            else
            {
                textBoxSteamDest.Text = "";
            }
        }

        private void buttonSteamSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Source = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            }
            updateTextBox();
        }
        private void buttonSteamDest_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Dest = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            }
            updateTextBox();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult confirm = 
                MessageBox.Show("Are you sure you want to continue? "+
            "Make sure you have backed up your SteamApps", "Confirm action", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (Source == null || !Source.Exists)
                {
                    MessageBox.Show("Source directory doesn't exist");
                    return;
                }

                if (!File.Exists(Source.FullName+"\\Steam.exe"))
                {
                    MessageBox.Show("Steam.exe wasn't found in the source directory");
                    return;
                }
                DirectoryInfo SourceApps;
                if (!Directory.Exists(Source.FullName + "\\SteamApps"))
                {
                    MessageBox.Show("SteamApps wasn't found in the source directory");
                    return;
                } else {
                    SourceApps = new DirectoryInfo(Source.FullName + "\\SteamApps");
                }
                if (SourceApps == null || !SourceApps.Exists)
                {
                    MessageBox.Show("An error ocurred while retrieving the SteamApps folder");
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                if (Dest == null)
                {
                    MessageBox.Show("You must specify a destination");
                    return;
                }
                if (!Dest.Exists)
                {
                    Directory.CreateDirectory(Dest.FullName);
                }
                
                File.Copy(Source.FullName + "\\Steam.exe", Dest.FullName + "\\Steam.exe");
                DirectoryInfo DestApps = Directory.CreateDirectory(Dest.FullName + "\\SteamApps");
               
                foreach (FileInfo file in SourceApps.GetFiles()) {
                    Process mklink = new Process();
                    mklink.StartInfo.FileName = "cmd";
                    mklink.StartInfo.Arguments = "/C mklink \"" + DestApps.FullName + "\\" + file.Name + "\" \"" + file.FullName + "\"";
                    mklink.Start();
                }
                foreach (DirectoryInfo dir in SourceApps.GetDirectories()) {
                    if (dir.Name != "common")
                    {
                        Process mklink = new Process();
                        mklink.StartInfo.FileName = "cmd";
                        mklink.StartInfo.Arguments = "/C mklink /D \"" + DestApps.FullName + "\\" + dir.Name + "\" \"" + dir.FullName + "\"";
                        mklink.Start();
                    }
                    else
                    {
                        DirectoryInfo DestCommon = Directory.CreateDirectory(DestApps.FullName + "\\common");
                        foreach (FileInfo subfile in dir.GetFiles()) {
                            Process mklink = new Process();
                            mklink.StartInfo.FileName = "cmd";
                            mklink.StartInfo.Arguments = "/C mklink \"" + DestCommon.FullName + "\\" + subfile.Name + "\" \"" + subfile.FullName + "\"";
                            mklink.Start();
                        }
                        foreach (DirectoryInfo subdir in dir.GetDirectories())
                        {
                            Process mklink = new Process();
                            mklink.StartInfo.FileName = "cmd";
                            mklink.StartInfo.Arguments = "/C mklink /D \"" + DestCommon.FullName + "\\" + subdir.Name + "\" \"" + subdir.FullName + "\"";
                            mklink.Start();
                        }
                    }
                }

                MessageBox.Show("Task completed.");
                Cursor.Current = Cursors.Default;

            }
        }
    }
}
