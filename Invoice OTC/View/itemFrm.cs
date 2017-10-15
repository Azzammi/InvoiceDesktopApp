using Invoice_OTC.Controller;
using Invoice_OTC.Model;
using Invoice_OTC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_OTC
{
    public partial class itemFrm : Form
    {
        #region Declarations
        AppController m_AppController;
        RotiToChooseList m_rotis;
        Form1 m_motherForm;
        #endregion
        public itemFrm()
        {
            InitializeComponent();
        }

        public itemFrm(Form1 motherForm)
        {
            m_motherForm = motherForm;
        }

        private void itemFrm_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            // Get invoices List          

            CommandGetRoti getRotis = new CommandGetRoti();
            m_rotis = (RotiToChooseList)m_AppController.ExecuteCommand(getRotis);


            //Bind Grids
            bindingSource1.DataSource = m_rotis;            
            
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmImportExcelRoti form = new FrmImportExcelRoti();
            form.ShowDialog();
        }
    }
}
