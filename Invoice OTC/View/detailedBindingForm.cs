using System;
using System.Windows.Forms;
using Invoice_OTC.Controller;
using Invoice_OTC.Model;
using static Invoice_OTC.View.FormStatusChangedEventArgs;

namespace Invoice_OTC.View
{
    public partial class detailedBindingForm : Form
    {
        #region Declaration
        AppController m_AppController;
        InvoiceList m_InvoiceList;
        CustomerList m_CustomerList;
        RotiToChooseList m_RotiToChooseList;

        private FormStatus frmStatus;
        private event FormStatusChangedEventHandles frmStatusChanged;
        #endregion

        #region Properties
        public FormStatus FrmStatus
        {
            get { return frmStatus; }
            set
            {
                this.frmStatus = value;
                //Call Method Event
                this.OnStatusChanged(new FormStatusChangedEventArgs(value));
            }
        }
        #endregion

        #region Constructor
        public detailedBindingForm()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods       

        protected void OnStatusChanged(FormStatusChangedEventArgs e)
        {
            //Report Changes
            frmStatusChanged?.Invoke(this, e);
        }

        protected void StatusChanged(object sender, FormStatusChangedEventArgs e)
        {
            switch (e.FrmStatus)
            {
                case FormStatus.Init:
                    break;
                case FormStatus.OnEditMode:
                    break;
                case FormStatus.Ready:
                    break;
                case FormStatus.NewRecord:
                    break;
                default:
                    break;
            }
        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            invoiceItemBindingSource.AddNew();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            if (invoiceItemBindingSource.Current == null) return;

            InvoiceItem currentInvoice = (InvoiceItem) invoiceItemBindingSource.Current;
            CommandUpdateInvoice updateInvoice = new CommandUpdateInvoice(currentInvoice);
            m_AppController.ExecuteCommand(updateInvoice);

            foreach(DataGridViewRow row in itemsDataGridView.Rows)
            {
                rotiItem item = row.DataBoundItem as rotiItem;
                if(item != null)
                {
                    CommandUpdateItem updateItem = new CommandUpdateItem(item);
                    m_AppController.ExecuteCommand(updateItem);
                }
            }
        }

        private void findStrip1_ItemFound(object sender, ItemFoundEventArgs e)
        {
            //If value found, select row
            if (e.Index >= 0)
            {
                //Change current list data source item
                //To ensure currency accross all controls
                //bound to this data source
                this.invoiceItemBindingSource.Position = e.Index;
            }
        }

        private void detailedBindingForm_Load(object sender, EventArgs e)
        {
            m_AppController = new AppController();

            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_InvoiceList = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGetCustomer getCustomers = new CommandGetCustomer();
            m_CustomerList = (CustomerList)m_AppController.ExecuteCommand(getCustomers);

            CommandGetRoti getRoti = new CommandGetRoti();
            m_RotiToChooseList = (RotiToChooseList)m_AppController.ExecuteCommand(getRoti);

            invoiceItemBindingSource.DataSource = m_InvoiceList;
            itemsBindingSource.DataSource = invoiceItemBindingSource;
            itemsBindingSource.DataMember = "Items";

            customerListBindingSource.DataSource = m_CustomerList;
            rotiToChooseItemBindingSource.DataSource = m_RotiToChooseList;

            invoiceItemBindingSource.Position = 0;
        }
        #endregion
    }
}
