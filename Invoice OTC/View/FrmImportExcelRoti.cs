using System;
using System.Data;
using System.Windows.Forms;
using Invoice_OTC.Controller;
using Invoice_OTC.Controller.Roti_Item;
using Invoice_OTC.Model;
using System.Data.OleDb;

namespace Invoice_OTC.View
{
    public partial class FrmImportExcelRoti : Form
    {
        #region Declaration
        AppController m_AppController;
        #endregion

        public FrmImportExcelRoti()
        {
            InitializeComponent();
        }

        private void FrmImportExcelRoti_Load(object sender, EventArgs e)
        {
            m_AppController = new AppController();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();

            switch (opd.ShowDialog())
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    sourceTxt.Text = opd.FileName;
                    break;
            }
        }

        private void prosesBtn_Click(object sender, EventArgs e)
        {
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                       "'" + sourceTxt.Text + "'" +
                       ";Extended Properties='Excel 8.0;HDR=YES;';";

            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand oconn = new OleDbCommand("Select * From [" + sheetTxt.Text + "$]", con);
            con.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;
            if (sourceTxt.Text == "" && sheetTxt.Text == "") return;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[7].Value.ToString() != null)
                {
                    RotiToChooseItem myItem = new RotiToChooseItem();
                    myItem.ItemCode = row.Cells[0].Value.ToString();
                    myItem.ItemName = row.Cells[1].Value.ToString();
                    myItem.ItemSort = row.Cells[2].Value.ToString();
                    myItem.Brand = row.Cells[3].Value.ToString();
                    myItem.Jenis = row.Cells[4].Value.ToString();
                    myItem.Category = row.Cells[5].Value.ToString();
                    myItem.SubCategory = row.Cells[6].Value.ToString();
                    myItem.Price = Convert.ToDecimal(row.Cells[7].Value);

                    CommandInsertRoti importData = new CommandInsertRoti(myItem);
                    m_AppController.ExecuteCommand(importData);
                }
            }
        }
    }
}
