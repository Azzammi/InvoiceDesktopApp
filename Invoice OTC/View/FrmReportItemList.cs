using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_OTC.Model;
using Invoice_OTC.Controller;

namespace Invoice_OTC.View
{
    public partial class FrmReportItemList : Form
    {
        public FrmReportItemList()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AppController m_AppContoller = new AppController();
            RotiToChooseList m_ItemList;

            CommandGetRoti getRotis = new CommandGetRoti();
            m_ItemList = (RotiToChooseList)m_AppContoller.ExecuteCommand(getRotis);

            rptRoti crReport = new rptRoti();
            crReport.Database.Tables["Invoice_OTC_Model_RotiToChooseItem"].SetDataSource(m_ItemList);

            crystalReportViewer1.ReportSource = crReport;
        }
    }
}
