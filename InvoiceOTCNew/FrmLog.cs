using System;
using System.Linq;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
using System.Windows.Forms;
using InvoiceOTC.Controller;

namespace InvoiceOTCNew
{
    public partial class FrmLog : Form
    {
        #region Declaration
        private ILog4NetRepository log4netRepo;
        #endregion

        public FrmLog()
        {
            InitializeComponent();

            log4netRepo = new Log4NetRepository();
            logsBindingSource.DataSource = log4netRepo.GetAll();
        }
    }
}
