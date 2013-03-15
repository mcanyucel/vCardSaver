using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace vCardSaver
{
    public partial class Form1 : Form
    {
        public string filePath { get; set; }
        public string sheetName { get; set; }
        public string nameColumn { get; set; }
        public string addressColumn { get; set; }
        Dictionary<string, string> contactInfos;


        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            frmSource sourceForm = new frmSource();
            sourceForm.ShowDialog(this);
            lblSource.Text = filePath == null ? "Kaynak dosya seçilmedi" : filePath;
        }

        private void btnTargetFolder_Click(object sender, EventArgs e)
        {
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lblTargetFolder.Text = fbd.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lblSource.Text == "Kaynak dosya seçilmedi" || lblTargetFolder.Text == "Hedef klasör seçilmedi")
            {
                MessageBox.Show("Önce kaynak dosya ve hedef klasör seçin");
            }
            else
            {
                lblStatus.Text = "İşleniyor";
                prb.Value = 0;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void ProcessExcelSheet()
        {
            try
            {
                OleDbConnection excelConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + lblSource.Text + "';Extended Properties=Excel 8.0;");
                excelConnection.Open();

                OleDbCommand cmd = new OleDbCommand(@"SELECT " + nameColumn + ", " + addressColumn + " FROM [" + sheetName + "]", excelConnection);

                OleDbDataAdapter adp = new OleDbDataAdapter();
                adp.SelectCommand = cmd;
                DataTable dt = new DataTable();
                adp.FillSchema(dt, SchemaType.Source);
                adp.Fill(dt);

                contactInfos = new Dictionary<string, string>();
                int totalContacts = dt.Rows.Count;
                int counter = 0;

                if (rdbSeperate.Checked)
                {
                    foreach (DataRow nextRow in dt.Rows)
                    {
                        string nextFileName = Path.Combine(lblTargetFolder.Text, nextRow[nameColumn].ToString() + ".vcf");


                        using (StreamWriter sw = new StreamWriter(nextFileName))
                        {
                            sw.WriteLine("BEGIN:VCARD");
                            sw.WriteLine("FN:" + nextRow[nameColumn].ToString());
                            sw.WriteLine("EMAIL; Internet:" + nextRow[addressColumn].ToString());
                            sw.WriteLine("REV:20130315T065518");
                            sw.WriteLine("VERSION:2.1");
                            sw.WriteLine("END:VCARD");
                        }

                        int percentage = Convert.ToInt16((double)counter / (double)totalContacts * 100);
                        backgroundWorker1.ReportProgress(percentage);
                    }
                }
                else
                {
                    string nextFileName = Path.Combine(lblTargetFolder.Text, "all.vcf");
                    
                    using (StreamWriter sw = new StreamWriter(nextFileName))
                    {
                        foreach (DataRow nextRow in dt.Rows)
                        {
                            sw.WriteLine("BEGIN:VCARD");
                            sw.WriteLine("FN:" + nextRow[nameColumn].ToString());
                            sw.WriteLine("EMAIL; Internet:" + nextRow[addressColumn].ToString());
                            sw.WriteLine("REV:20130315T065518");
                            sw.WriteLine("VERSION:2.1");
                            sw.WriteLine("END:VCARD");

                            int percentage = Convert.ToInt16((double)counter / (double)totalContacts * 100);
                            backgroundWorker1.ReportProgress(percentage);
                        } 
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ProcessExcelSheet();
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prb.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Tamamlandı";
        }
    }
}
