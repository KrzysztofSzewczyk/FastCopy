using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace FastCopy
{
    public partial class FastCopy : Form
    {
        static int FileProgress = 0;
        static int TotalProgress = 0;
        static int error = 0;
        static int finished = 1;
        static int ioError = 0;
        static double bps = 0;
        long[] sizes = {512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1024*1024, 1024*1024*2, 1024*1024*4, 1024*1024*8, 1024*1024*16, 1024*1024*32, 1024*1024*64};

        public FastCopy()
        {
            InitializeComponent();
        }

        static int AmountDirectories(string sDir)
        {
            int amount = 0;
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    amount += Directory.GetFiles(d).Length + AmountDirectories(d);
                }
                return amount;
            }
            catch (Exception)
            {
                ioError = 1;
                return -1;
            }
        }

        private void CopyFolder(string sourceFolder, string destFolder)
        {
            long bufferSize = sizes[BufferSizeCombo.SelectedIndex];
            if (!Directory.Exists(destFolder))
                Directory.CreateDirectory(destFolder);
            int current = 0, amount = AmountDirectories(sourceFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                Thread newThread = new Thread(CopyFile);
                object args = new object[3] { file, dest, bufferSize };
                newThread.Start(args);
                if (error == 1)
                {
                    MessageBox.Show(this, "Copy failed. Size mismatch!", "Error!");
                    error = 0;
                    return;
                }
                FastCopy.TotalProgress = (current * 100) / amount;
                FilesList.Items.Add(name);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }

        private void CopyFile(object ow)
        {
            double seconds;
            try
            {
                Array o = new object[3];
                o = (Array)ow;
                long total = 0, current = 0, needed = new FileInfo((string)o.GetValue(0)).Length;
                byte[] buf = new byte[(long)o.GetValue(2)];
                FileStream f = File.Open((string)o.GetValue(0), FileMode.Open);
                FileStream g = File.OpenWrite((string)o.GetValue(1));
                Stopwatch stopwatch = Stopwatch.StartNew();
                for (; ; )
                {
                    current = f.Read(buf, 0, (int)((long)o.GetValue(2)));
                    total += current;
                    if (current == 0) break;
                    g.Write(buf, 0, (int)((long)o.GetValue(2)));
                    FastCopy.FileProgress = (int)((total * 100) / needed);
                    seconds = (((stopwatch.ElapsedMilliseconds + 1) / 1000) + 1);
                    bps = (((double)((long)o.GetValue(2))) / seconds);
                    stopwatch.Reset();
                    stopwatch.Start();
                }
                stopwatch.Stop();
                if (total != new FileInfo((string)o.GetValue(0)).Length)
                {
                    error = 1;
                }
                f.Close();
                g.Close();
                buf = null;
                finished = 0;
            }
            catch (Exception e)
            {
                ioError = 1;
                MessageBox.Show(e.Message);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                RecursiveChkbx.Enabled = false;
                StartBtn.Enabled = false;
                PauseBtn.Enabled = true;
                StopBtn.Enabled = true;
                FilesList.Items.Clear();
                DestinatonPick.Enabled = false;
                SourcePick.Enabled = false;
                BufferSizeCombo.Enabled = false;
                string srcPath, destPath;
                long bufferSize = sizes[BufferSizeCombo.SelectedIndex];
                if (DirectoryChkbx.Checked)
                {
                    srcPath = DirectoryDialog.SelectedPath;
                    destPath = DirectoryDialog2.SelectedPath;
                }
                else
                {
                    srcPath = OpenDialog.FileName;
                    destPath = DestinationDialog.FileName;
                }
                if (srcPath.Equals("") || destPath.Equals(""))
                {
                    MessageBox.Show(this, "Please choose valid destination and source file / directory.", "Error");
                    StopBtn_Click(sender, e);
                    return;
                }
                if (srcPath.Equals(destPath))
                {
                    FilesList.Items.Add(srcPath);
                    FileProgressbar.Value = 100;
                    TotalProgressbar.Value = 100;
                    StopBtn_Click(null, null);
                }
                if (DirectoryChkbx.Checked)
                {
                    if (RecursiveChkbx.Checked)
                    {
                        CopyFolder(srcPath, destPath);
                    }
                    else
                    {
                        FileInfo[] Files = null;
                        try
                        {
                            Files = new DirectoryInfo(srcPath).GetFiles("*.*");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show(this, "Could not read directory: " + srcPath, "Error");
                            StopBtn_Click(sender, e);
                            return;
                        }

                        int current = 0, amount = Files.Length;

                        foreach (FileInfo file in Files)
                        {
                            if (new FileInfo(srcPath).Exists)
                            {
                                Thread newThread = new Thread(CopyFile);
                                object args = new object[3] { srcPath + file.Name, destPath + file.Name, bufferSize };
                                newThread.Start(args);
                                if (error == 1)
                                {
                                    MessageBox.Show(this, "Copy failed. Size mismatch!", "Error!");
                                    error = 0;
                                    return;
                                }
                                FastCopy.TotalProgress = (current * 100) / amount;
                                FilesList.Items.Add(srcPath);
                            }
                            else
                            {
                                MessageBox.Show(this, "Please choose valid destination and source file / directory.", "Error");
                                StopBtn_Click(sender, e);
                                return;
                            }
                            current++;
                        }
                    }
                }
                else
                {
                    if (new FileInfo(srcPath).Exists)
                    {
                        Thread newThread = new Thread(CopyFile);
                        object args = new object[3] { srcPath, destPath, bufferSize };
                        newThread.Start(args);
                        if (error == 1)
                        {
                            MessageBox.Show(this, "Copy failed. Size mismatch!", "Error!");
                            error = 0;
                            return;
                        }
                        FastCopy.TotalProgress = 100;
                        FilesList.Items.Add(srcPath);
                    }
                    else
                    {
                        MessageBox.Show(this, "Please choose valid destination and source file / directory.", "Error");
                        StopBtn_Click(sender, e);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Copy error.", "Error");
                StopBtn_Click(sender, e);
                return;
            }
        }

        private void DestinatonPick_Click(object sender, EventArgs e)
        {
            if (!DirectoryChkbx.Checked)
            {
                if (DestinationDialog.ShowDialog(this) == DialogResult.OK)
                {
                    DestinationLbl.Text = DestinationDialog.FileName;
                    DirectoryChkbx.Enabled = false;
                }
            }
            else if (DirectoryDialog2.ShowDialog(this) == DialogResult.OK)
            {
                DestinationLbl.Text = DirectoryDialog2.SelectedPath;
                DirectoryChkbx.Enabled = false;
            }
        }

        private void Source_Click(object sender, EventArgs e)
        {
            if (!DirectoryChkbx.Checked)
            {
                if (OpenDialog.ShowDialog(this) == DialogResult.OK)
                {
                    SourceLbl.Text = OpenDialog.FileName;
                    DirectoryChkbx.Enabled = false;
                }
            }
            else if (DirectoryDialog.ShowDialog(this) == DialogResult.OK)
            {
                SourceLbl.Text = DirectoryDialog.SelectedPath;
                DirectoryChkbx.Enabled = false;
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            RecursiveChkbx.Enabled = true;
            StartBtn.Enabled = true;
            PauseBtn.Enabled = false;
            StopBtn.Enabled = false;
            DestinatonPick.Enabled = true;
            SourcePick.Enabled = true;
            BufferSizeCombo.Enabled = true;
        }

        private void DirectoryChkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (!DirectoryChkbx.Checked)
            {
                RecursiveChkbx.Checked = false;
                RecursiveChkbx.Enabled = false;
            }
            else {
                RecursiveChkbx.Enabled = true;
            }
        }

        private void ProgressbarUpdateTick_Tick(object sender, EventArgs e)
        {
            FileProgressbar.Value = FastCopy.FileProgress;
            TotalProgressbar.Value = FastCopy.TotalProgress;
            if (finished == 0)
            {
                StopBtn_Click(sender, e);
                finished = 1;
            }
            if (ioError == 1)
            {
                ioError = 0;
                MessageBox.Show(this, "I/O error.", "Error");
                StopBtn_Click(sender, e);
            }
            if (bps < 1000)
            {
                speedLbl.Text = "Speed: " + bps + " BPS";
            }
            else if (bps > 1000 && bps < 1000000)
            {
                speedLbl.Text = "Speed: " + bps / 1000 + " KBPS";
            }
            else
            {
                speedLbl.Text = "Speed: " + bps / 1000000 + " MBPS";
            }
        }

        private void CleanBtn_Click(object sender, EventArgs e)
        {
            DirectoryChkbx.Enabled = true;
            RecursiveChkbx.Enabled = true;
            BufferSizeCombo.SelectedIndex = -1;
            RecursiveChkbx.Checked = false;
            DirectoryChkbx.Checked = false;
            DirectoryDialog.SelectedPath = "";
            DirectoryDialog2.SelectedPath = "";
            OpenDialog.FileName = "";
            DestinationDialog.FileName = "";
            SourceLbl.Text = "Source: ";
            DestinationLbl.Text = "Destination: ";
            FileProgressbar.Value = 0;
            TotalProgressbar.Value = 0;
            TotalProgress = 0;
            FileProgress = 0;

        }
    }
}