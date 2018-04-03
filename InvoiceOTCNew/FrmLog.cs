using System;
using System.Linq;
using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;

using InvoiceOTCNew.Helper;
using System.Windows.Forms;
using InvoiceOTC.Controller;
using System.Collections.Generic;

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
            logData = log4netRepo.GetAll();

            PageOffsetList offsetList = new PageOffsetList();
            offsetList.TotalRecords = logData.Count;
            totalRecords = logData.Count;

            logsBindingNavigator.BindingSource = logsBindingSource;
            logsBindingSource.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            logsBindingSource.DataSource = offsetList;
        }

        private IList<Logs> logData;
        private int totalRecords = 0;
        private const int pageSize = 10;
        

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            // The desired page has changed, so fetch the page of records using the "Current" offset 
            int offset = (int)logsBindingSource.Current;
            var records = new List<Logs>();
            for (int i = offset; i < offset + pageSize && i < totalRecords; i++)
                records.Add(logData[i]);
            logsDataGridView.DataSource = records;
        }

        /// <summary>
        /// This Class was used to get pageoffset and set it to bindingsource
        /// </summary>
        class PageOffsetList : System.ComponentModel.IListSource
        {
            public bool ContainsListCollection { get; protected set; }
            public int TotalRecords { get;  set; }
            
            public System.Collections.IList GetList()
            {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < TotalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }

        private void logsBindingSource_CurrentChanged(object sender, EventArgs e)
        {            
            //MessageBox.Show(log.LogDate.ToString());
        }
    }
}
