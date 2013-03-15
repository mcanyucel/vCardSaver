using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace vCardSaver
{
    public partial class frmSource : Form
    {
        bool xlsx = false;


        public frmSource()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofdExcel.ShowDialog();
        }

        private void ofdExcel_FileOk(object sender, CancelEventArgs e)
        {
            if (ofdExcel.FileName.Trim()!="")
            {   
                lblFileName.Text = ofdExcel.FileName;
                xlsx = Path.GetExtension(lblFileName.Text) == ".xls" ? false : true;
                if (xlsx)
                {
                    MessageBox.Show(".xlsx dosyaları henüz desteklenmemektedir.");
                }
                else
                    ParseExcelFile(); 
            }
        }

        private void ParseExcelFile()
        {
            GetSheetNames();
        }

        private void GetSheetNames()
        {
            try
            {
                OleDbConnection excelConnection;
                DataTable dtSheets = null;

                if (xlsx)
                {
                    excelConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblFileName.Text + "';Extended Properties=Excel 12.0 Xml;HDR=YES");
                }
                else
                {
                    excelConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + lblFileName.Text + "';Extended Properties=Excel 8.0;");
                }
                
                excelConnection.Open();
                dtSheets = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                cmbSheets.Items.Clear();

                foreach (DataRow item in dtSheets.Rows)
                {
                    cmbSheets.Items.Add(item["TABLE_NAME"].ToString());
                }

                excelConnection.Close();

                if (cmbSheets.Items.Count>0)
                {
                    cmbSheets.SelectedIndex = 0;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                
            }
        }

        private void cmbSheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreviewSheet(cmbSheets.SelectedItem.ToString());
        }

        private void PreviewSheet(string sheetName)
        {
            try
            {
                OleDbConnection excelConnection;
                DataSet excelDataset;
                OleDbDataAdapter excelAdapter;
                if (xlsx)
                {
                    excelConnection = new OleDbConnection(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + lblFileName.Text + "';Extended Properties=Excel 12.0 Xml;HDR=YES");
                }
                else
                {
                    excelConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + lblFileName.Text + "';Extended Properties=Excel 8.0;");
                }
                excelAdapter = new OleDbDataAdapter("select * from [" + sheetName + "]", excelConnection);
                excelDataset = new DataSet();

                excelAdapter.Fill(excelDataset);
                dgvExcel.DataSource = excelDataset.Tables[0];

                cmbAddress.Items.Clear();
                cmbName.Items.Clear();

                foreach (DataColumn column in excelDataset.Tables[0].Columns)
                {
                    cmbName.Items.Add(column.ColumnName);
                    cmbAddress.Items.Add(column.ColumnName);
                }

                excelConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblFileName.Text == "Dosya seçilmedi")
            {
                MessageBox.Show("Dosya seçiniz.");
            }
            else if (cmbName.SelectedIndex == -1 || cmbAddress.SelectedIndex == -1)
            {
                MessageBox.Show("İsim ve adres sütunlarını seçiniz.");
            }
            else
            {
                Form1 parentForm = this.Owner as Form1;

                parentForm.filePath = lblFileName.Text;
                parentForm.nameColumn = cmbName.SelectedItem.ToString();
                parentForm.addressColumn = cmbAddress.SelectedItem.ToString();
                parentForm.sheetName = cmbSheets.SelectedItem.ToString();
                
                this.Close();
            }
        }

        private void frmSource_Load(object sender, EventArgs e)
        {
            Form1 parentForm = this.Owner as Form1;
            if (parentForm.filePath!= null)
            {
                lblFileName.Text = parentForm.filePath;
                GetSheetNames();

                cmbSheets.SelectedItem = parentForm.sheetName;

                cmbName.SelectedItem = parentForm.nameColumn;
                cmbAddress.SelectedItem = parentForm.addressColumn;


            }
        }
    }
}
