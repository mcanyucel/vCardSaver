namespace vCardSaver
{
    partial class Form1
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
            this.btnSource = new System.Windows.Forms.Button();
            this.btnTargetFolder = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.prb = new System.Windows.Forms.ToolStripProgressBar();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rdbSeperate = new System.Windows.Forms.RadioButton();
            this.rdbSingle = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(15, 12);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(360, 23);
            this.btnSource.TabIndex = 0;
            this.btnSource.Text = "Kaynak Dosya Seç";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(12, 86);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(359, 23);
            this.btnTargetFolder.TabIndex = 1;
            this.btnTargetFolder.Text = "Hedef Klasör Seç";
            this.btnTargetFolder.UseVisualStyleBackColor = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // lblSource
            // 
            this.lblSource.Location = new System.Drawing.Point(12, 38);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(363, 45);
            this.lblSource.TabIndex = 2;
            this.lblSource.Text = "Kaynak dosya seçilmedi";
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.Location = new System.Drawing.Point(12, 112);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(359, 53);
            this.lblTargetFolder.TabIndex = 2;
            this.lblTargetFolder.Text = "Hedef klasör seçilmedi";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(296, 166);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "BAŞLA";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.prb});
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(383, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 17);
            this.lblStatus.Text = "Hazır";
            // 
            // prb
            // 
            this.prb.Name = "prb";
            this.prb.Size = new System.Drawing.Size(240, 16);
            // 
            // fbd
            // 
            this.fbd.Description = "Hedef klasör";
            this.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // rdbSeperate
            // 
            this.rdbSeperate.AutoSize = true;
            this.rdbSeperate.Checked = true;
            this.rdbSeperate.Location = new System.Drawing.Point(12, 169);
            this.rdbSeperate.Name = "rdbSeperate";
            this.rdbSeperate.Size = new System.Drawing.Size(119, 17);
            this.rdbSeperate.TabIndex = 6;
            this.rdbSeperate.TabStop = true;
            this.rdbSeperate.Text = "Ayrı vCard Dosyaları";
            this.rdbSeperate.UseVisualStyleBackColor = true;
            // 
            // rdbSingle
            // 
            this.rdbSingle.AutoSize = true;
            this.rdbSingle.Location = new System.Drawing.Point(137, 169);
            this.rdbSingle.Name = "rdbSingle";
            this.rdbSingle.Size = new System.Drawing.Size(115, 17);
            this.rdbSingle.TabIndex = 6;
            this.rdbSingle.Text = "Tek vCard Dosyası";
            this.rdbSingle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 221);
            this.Controls.Add(this.rdbSingle);
            this.Controls.Add(this.rdbSeperate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTargetFolder);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnTargetFolder);
            this.Controls.Add(this.btnSource);
            this.Name = "Form1";
            this.Text = "Toplu Olarak vCard Kaydetme";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnTargetFolder;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prb;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbSeperate;
        private System.Windows.Forms.RadioButton rdbSingle;
    }
}

