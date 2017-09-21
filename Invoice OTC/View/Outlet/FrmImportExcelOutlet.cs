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
using Invoice_OTC.Controller.Outlet;
using Invoice_OTC.Model;
using Invoice_OTC.Controller;

namespace Invoice_OTC.View
{
    public partial class FrmImportExcelOutlet : Form
    {
        #region Declaration
        AppController m_AppController;
        #endregion

        public FrmImportExcelOutlet()
        {
            InitializeComponent();
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

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[0].Value != null)
                {
                    outletItem myItem = new outletItem();
                    myItem.OutletCode = row.Cells[2].Value.ToString();
                    myItem.OutletName = row.Cells[3].Value.ToString();
                    myItem.SlsmCode = row.Cells[0].Value.ToString();
                    myItem.OutletAddress = row.Cells[4].Value.ToString();
                    myItem.OutletRoute = row.Cells[5].Value.ToString();
                    myItem.OutletStatus = true;

                    CommandCRUOutlet importData = new CommandCRUOutlet();
                    m_AppController.ExecuteCommand(importData);
                }
            }
        }

        private void FrmImportExcelOutlet_Load(object sender, EventArgs e)
        {
            m_AppController = new AppController();
        }
    }
}
