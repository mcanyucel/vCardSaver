namespace vCardSaver
{
    partial class frmSource
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.cmbSheets = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.dgvExcel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dosya Seç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adreslerin Olduğu Excel Sayfası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İsim Sütunu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres Sütunu:";
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(8, 48);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(290, 36);
            this.lblFileName.TabIndex = 1;
            this.lblFileName.Text = "Dosya seçilmedi";
            // 
            // cmbSheets
            // 
            this.cmbSheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSheets.FormattingEnabled = true;
            this.cmbSheets.Location = new System.Drawing.Point(173, 81);
            this.cmbSheets.Name = "cmbSheets";
            this.cmbSheets.Size = new System.Drawing.Size(121, 21);
            this.cmbSheets.TabIndex = 2;
            this.cmbSheets.SelectedIndexChanged += new System.EventHandler(this.cmbSheets_SelectedIndexChanged);
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(178, 268);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(121, 21);
            this.cmbName.TabIndex = 2;
            // 
            // cmbAddress
            // 
            this.cmbAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Location = new System.Drawing.Point(178, 301);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(121, 21);
            this.cmbAddress.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(287, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Kaydet && Kapat";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ofdExcel
            // 
            this.ofdExcel.Filter = "2003-2007 Excel Dosyası|*.xls|2010-2013 Excel Dosyası|*.xlsx";
            this.ofdExcel.Title = "Kaynak dosyayı seçin...";
            this.ofdExcel.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdExcel_FileOk);
            // 
            // dgvExcel
            // 
            this.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcel.Location = new System.Drawing.Point(11, 108);
            this.dgvExcel.Name = "dgvExcel";
            this.dgvExcel.Size = new System.Drawing.Size(288, 150);
            this.dgvExcel.TabIndex = 4;
            // 
            // frmSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 369);
            this.Controls.Add(this.dgvExcel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbSheets);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "frmSource";
            this.Text = "Kaynak Dosya";
            this.Load += new System.EventHandler(this.frmSource_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ComboBox cmbSheets;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.ComboBox cmbAddress;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.DataGridView dgvExcel;
    }
}