namespace FastCopy
{
    partial class FastCopy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastCopy));
            this.SourceLbl = new System.Windows.Forms.Label();
            this.SourceFileLbl = new System.Windows.Forms.Label();
            this.SourcePick = new System.Windows.Forms.Button();
            this.DestinatonPick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationLbl = new System.Windows.Forms.Label();
            this.RecursiveChkbx = new System.Windows.Forms.CheckBox();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.FileProgressbar = new System.Windows.Forms.ProgressBar();
            this.TotalProgressbar = new System.Windows.Forms.ProgressBar();
            this.StartBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.DestinationDialog = new System.Windows.Forms.OpenFileDialog();
            this.DirectoryChkbx = new System.Windows.Forms.CheckBox();
            this.DirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.BufferSizeCombo = new System.Windows.Forms.ComboBox();
            this.ProgressbarUpdateTick = new System.Windows.Forms.Timer(this.components);
            this.CleanBtn = new System.Windows.Forms.Button();
            this.speedLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ElevatePriorityChkbx = new System.Windows.Forms.CheckBox();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.GCTask = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SourceLbl
            // 
            this.SourceLbl.AutoSize = true;
            this.SourceLbl.Location = new System.Drawing.Point(90, 9);
            this.SourceLbl.Name = "SourceLbl";
            this.SourceLbl.Size = new System.Drawing.Size(44, 13);
            this.SourceLbl.TabIndex = 0;
            this.SourceLbl.Text = "Source:";
            // 
            // SourceFileLbl
            // 
            this.SourceFileLbl.AutoSize = true;
            this.SourceFileLbl.Location = new System.Drawing.Point(140, 9);
            this.SourceFileLbl.Name = "SourceFileLbl";
            this.SourceFileLbl.Size = new System.Drawing.Size(0, 13);
            this.SourceFileLbl.TabIndex = 1;
            // 
            // SourcePick
            // 
            this.SourcePick.Location = new System.Drawing.Point(12, 4);
            this.SourcePick.Name = "SourcePick";
            this.SourcePick.Size = new System.Drawing.Size(75, 23);
            this.SourcePick.TabIndex = 2;
            this.SourcePick.Text = "Pick ...";
            this.SourcePick.UseVisualStyleBackColor = true;
            this.SourcePick.Click += new System.EventHandler(this.Source_Click);
            // 
            // DestinatonPick
            // 
            this.DestinatonPick.Location = new System.Drawing.Point(12, 33);
            this.DestinatonPick.Name = "DestinatonPick";
            this.DestinatonPick.Size = new System.Drawing.Size(75, 23);
            this.DestinatonPick.TabIndex = 5;
            this.DestinatonPick.Text = "Pick ...";
            this.DestinatonPick.UseVisualStyleBackColor = true;
            this.DestinatonPick.Click += new System.EventHandler(this.DestinatonPick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // DestinationLbl
            // 
            this.DestinationLbl.AutoSize = true;
            this.DestinationLbl.Location = new System.Drawing.Point(90, 38);
            this.DestinationLbl.Name = "DestinationLbl";
            this.DestinationLbl.Size = new System.Drawing.Size(63, 13);
            this.DestinationLbl.TabIndex = 3;
            this.DestinationLbl.Text = "Destination:";
            // 
            // RecursiveChkbx
            // 
            this.RecursiveChkbx.AutoSize = true;
            this.RecursiveChkbx.Enabled = false;
            this.RecursiveChkbx.Location = new System.Drawing.Point(15, 58);
            this.RecursiveChkbx.Name = "RecursiveChkbx";
            this.RecursiveChkbx.Size = new System.Drawing.Size(74, 17);
            this.RecursiveChkbx.TabIndex = 6;
            this.RecursiveChkbx.Text = "Recursive";
            this.RecursiveChkbx.UseVisualStyleBackColor = true;
            // 
            // FilesList
            // 
            this.FilesList.FormattingEnabled = true;
            this.FilesList.Items.AddRange(new object[] {
            ""});
            this.FilesList.Location = new System.Drawing.Point(15, 81);
            this.FilesList.Name = "FilesList";
            this.FilesList.ScrollAlwaysVisible = true;
            this.FilesList.Size = new System.Drawing.Size(307, 82);
            this.FilesList.TabIndex = 7;
            // 
            // FileProgressbar
            // 
            this.FileProgressbar.Location = new System.Drawing.Point(15, 169);
            this.FileProgressbar.Name = "FileProgressbar";
            this.FileProgressbar.Size = new System.Drawing.Size(307, 17);
            this.FileProgressbar.TabIndex = 8;
            // 
            // TotalProgressbar
            // 
            this.TotalProgressbar.Location = new System.Drawing.Point(15, 192);
            this.TotalProgressbar.Name = "TotalProgressbar";
            this.TotalProgressbar.Size = new System.Drawing.Size(307, 17);
            this.TotalProgressbar.TabIndex = 9;
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(15, 215);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(74, 23);
            this.StartBtn.TabIndex = 10;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Enabled = false;
            this.PauseBtn.Location = new System.Drawing.Point(95, 215);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(68, 23);
            this.PauseBtn.TabIndex = 11;
            this.PauseBtn.Text = "Pause";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Enabled = false;
            this.StopBtn.Location = new System.Drawing.Point(252, 215);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(70, 23);
            this.StopBtn.TabIndex = 12;
            this.StopBtn.Text = "Stop";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.RestoreDirectory = true;
            // 
            // DestinationDialog
            // 
            this.DestinationDialog.CheckFileExists = false;
            this.DestinationDialog.CheckPathExists = false;
            this.DestinationDialog.RestoreDirectory = true;
            // 
            // DirectoryChkbx
            // 
            this.DirectoryChkbx.AutoSize = true;
            this.DirectoryChkbx.Location = new System.Drawing.Point(95, 58);
            this.DirectoryChkbx.Name = "DirectoryChkbx";
            this.DirectoryChkbx.Size = new System.Drawing.Size(68, 17);
            this.DirectoryChkbx.TabIndex = 13;
            this.DirectoryChkbx.Text = "Directory";
            this.DirectoryChkbx.UseVisualStyleBackColor = true;
            this.DirectoryChkbx.CheckedChanged += new System.EventHandler(this.DirectoryChkbx_CheckedChanged);
            // 
            // BufferSizeCombo
            // 
            this.BufferSizeCombo.FormattingEnabled = true;
            this.BufferSizeCombo.Items.AddRange(new object[] {
            "512 B",
            "1 kB",
            "2 kB",
            "4 kB",
            "8 kB",
            "16 kB",
            "32 kB",
            "64 kB",
            "128 kB",
            "256 kB",
            "512 kB",
            "1 MB",
            "2 MB",
            "4 MB",
            "8 MB",
            "16 MB",
            "32 MB",
            "64 MB",
            "128 MB",
            "256 MB"});
            this.BufferSizeCombo.Location = new System.Drawing.Point(15, 244);
            this.BufferSizeCombo.Name = "BufferSizeCombo";
            this.BufferSizeCombo.Size = new System.Drawing.Size(307, 21);
            this.BufferSizeCombo.TabIndex = 14;
            this.BufferSizeCombo.Text = "Buffer Size";
            // 
            // ProgressbarUpdateTick
            // 
            this.ProgressbarUpdateTick.Enabled = true;
            this.ProgressbarUpdateTick.Interval = 10;
            this.ProgressbarUpdateTick.Tick += new System.EventHandler(this.ProgressbarUpdateTick_Tick);
            // 
            // CleanBtn
            // 
            this.CleanBtn.Location = new System.Drawing.Point(169, 215);
            this.CleanBtn.Name = "CleanBtn";
            this.CleanBtn.Size = new System.Drawing.Size(77, 23);
            this.CleanBtn.TabIndex = 15;
            this.CleanBtn.Text = "Clean";
            this.CleanBtn.UseVisualStyleBackColor = true;
            this.CleanBtn.Click += new System.EventHandler(this.CleanBtn_Click);
            // 
            // speedLbl
            // 
            this.speedLbl.AutoSize = true;
            this.speedLbl.Location = new System.Drawing.Point(12, 268);
            this.speedLbl.Name = "speedLbl";
            this.speedLbl.Size = new System.Drawing.Size(0, 13);
            this.speedLbl.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Made by Kamila Szewczyk. Copyright (C) 2018";
            // 
            // ElevatePriorityChkbx
            // 
            this.ElevatePriorityChkbx.AutoSize = true;
            this.ElevatePriorityChkbx.Location = new System.Drawing.Point(166, 58);
            this.ElevatePriorityChkbx.Name = "ElevatePriorityChkbx";
            this.ElevatePriorityChkbx.Size = new System.Drawing.Size(170, 17);
            this.ElevatePriorityChkbx.TabIndex = 18;
            this.ElevatePriorityChkbx.Text = "Elevate IO priority (faster copy)";
            this.ElevatePriorityChkbx.UseVisualStyleBackColor = true;
            this.ElevatePriorityChkbx.CheckedChanged += new System.EventHandler(this.ElevatePriorityChkbx_CheckedChanged);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Location = new System.Drawing.Point(14, 314);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.ErrorLbl.TabIndex = 19;
            // 
            // GCTask
            // 
            this.GCTask.Enabled = true;
            this.GCTask.Interval = 10000;
            this.GCTask.Tick += new System.EventHandler(this.GCTask_Tick);
            // 
            // FastCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 331);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.ElevatePriorityChkbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.speedLbl);
            this.Controls.Add(this.CleanBtn);
            this.Controls.Add(this.BufferSizeCombo);
            this.Controls.Add(this.DirectoryChkbx);
            this.Controls.Add(this.StopBtn);
            this.Controls.Add(this.PauseBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.TotalProgressbar);
            this.Controls.Add(this.FileProgressbar);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.RecursiveChkbx);
            this.Controls.Add(this.DestinatonPick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DestinationLbl);
            this.Controls.Add(this.SourcePick);
            this.Controls.Add(this.SourceFileLbl);
            this.Controls.Add(this.SourceLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 370);
            this.MinimumSize = new System.Drawing.Size(350, 370);
            this.Name = "FastCopy";
            this.Text = "FastCopy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceLbl;
        private System.Windows.Forms.Label SourceFileLbl;
        private System.Windows.Forms.Button SourcePick;
        private System.Windows.Forms.Button DestinatonPick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DestinationLbl;
        private System.Windows.Forms.CheckBox RecursiveChkbx;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.ProgressBar FileProgressbar;
        private System.Windows.Forms.ProgressBar TotalProgressbar;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.OpenFileDialog DestinationDialog;
        private System.Windows.Forms.CheckBox DirectoryChkbx;
        private System.Windows.Forms.FolderBrowserDialog DirectoryDialog;
        private System.Windows.Forms.FolderBrowserDialog DirectoryDialog2;
        private System.Windows.Forms.ComboBox BufferSizeCombo;
        private System.Windows.Forms.Timer ProgressbarUpdateTick;
        private System.Windows.Forms.Button CleanBtn;
        private System.Windows.Forms.Label speedLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ElevatePriorityChkbx;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.Timer GCTask;
    }
}

