using System;
using System.Windows.Forms;
using Invoice_OTC.Controller;
using Invoice_OTC.Controller.Outlet;
using Invoice_OTC.Controller.Invoice;
using Invoice_OTC.Model;
using static Invoice_OTC.View.FormStatusChangedEventArgs;

namespace Invoice_OTC.View
{
    public partial class detailedBindingForm : Form
    {
        #region Declaration
        AppController m_AppController;
        InvoiceList m_InvoiceList;
        outletList m_OutletList;
        RotiToChooseList m_RotiToChooseList;

        miscellanacousFunction m_Control;

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
        public detailedBindingForm(FormStatus value)
        {
            InitializeComponent();

            //Add method event
            frmStatusChanged += DetailedBindingForm_frmStatusChanged;

            //Load the form first
            detailedBindingForm_Load();

            //Set the form Status 
            FrmStatus = value;
        }

        private void DetailedBindingForm_frmStatusChanged(object sender, FormStatusChangedEventArgs e)
        {
            switch (e.FrmStatus)
            {
                case FormStatus.Init:
                    MessageBox.Show("Init");
                    break;
                case FormStatus.OnEditMode:
                    //MessageBox.Show("OnEditMode");
                    tambahBtn.Enabled = false;
                    simpanBtn.Image = Properties.Resources.Save_50px_1;
                    m_Control.EnableInput(this);

                    break;
                case FormStatus.Ready:
                    //MessageBox.Show("Ready");
                    tambahBtn.Enabled = true;
                    simpanBtn.Image = Properties.Resources.Pencil_Tip_50px;
                    m_Control.DisableInput(this);

                    break;
                case FormStatus.NewRecord:
                    //MessageBox.Show("NewRecord");
                    tambahBtn.Enabled = false;
                    simpanBtn.Image = Properties.Resources.Save_50px;
                    m_Control.EnableInput(this);
                    nomorTextBox.Focus();

                    break;
                default:
                    MessageBox.Show("Default");
                    break;
            }
        }
        #endregion

        #region Methods       

        protected void OnStatusChanged(FormStatusChangedEventArgs e)
        {
            //Report Changes
            frmStatusChanged?.Invoke(this, e);
        }
        
        private void tambahBtn_Click(object sender, EventArgs e)
        {
            FrmStatus = FormStatus.NewRecord;
            invoiceItemBindingSource.AddNew();
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {

            if (invoiceItemBindingSource.Current == null) return;
            InvoiceItem currentInvoice = (InvoiceItem)invoiceItemBindingSource.Current;

            switch (FrmStatus)
            {
                case FormStatus.OnEditMode:
                    FrmStatus = FormStatus.Ready;

                    CommandUpdateInvoice updateInvoice = new CommandUpdateInvoice(currentInvoice);
                    m_AppController.ExecuteCommand(updateInvoice);

                    foreach (DataGridViewRow row in itemsDataGridView.Rows)
                    {
                        rotiItem item = row.DataBoundItem as rotiItem;
                        if (item != null)
                        {
                            CommandUpdateItem updateItem = new CommandUpdateItem(item);
                            m_AppController.ExecuteCommand(updateItem);
                        }
                    }
                   
                    break;
                case FormStatus.Ready:
                    FrmStatus = FormStatus.OnEditMode;
                    break;
                case FormStatus.NewRecord:
                    CommandInsertByDetailInvoice newInvoice = new CommandInsertByDetailInvoice(currentInvoice);
                    m_AppController.ExecuteCommand(newInvoice);
                    break;
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

        private void detailedBindingForm_Load()
        {
            m_AppController = new AppController();
            m_Control = new miscellanacousFunction();

            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_InvoiceList = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGetOutlet getOutlets = new CommandGetOutlet();
            m_OutletList = (outletList)m_AppController.ExecuteCommand(getOutlets);

            CommandGetRoti getRoti = new CommandGetRoti();
            m_RotiToChooseList = (RotiToChooseList)m_AppController.ExecuteCommand(getRoti);

            invoiceItemBindingSource.DataSource = m_InvoiceList;
            itemsBindingSource.DataSource = invoiceItemBindingSource;
            itemsBindingSource.DataMember = "Items";

            outletItemBindingSource.DataSource = m_OutletList;
            rotiToChooseItemBindingSource.DataSource = m_RotiToChooseList;

            invoiceItemBindingSource.Position = 0;
        }
        #endregion
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(bindingNavigator1.Visible != true)
            {
                toolStripButton1.Text = "Show Navigator";
                bindingNavigator1.Visible = true;
            }
            else
            {
                toolStripButton1.Text = "Hide Navigator";
                bindingNavigator1.Visible = false;
            }
        }

        private void detailedBindingForm_Load(object sender, EventArgs e)
        {

        }

        private void invoiceItemBindingSource_AddingNew(object sender, System.ComponentModel.AddingNewEventArgs e)
        {
            
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Get author
            InvoiceItem itemToDelete = (InvoiceItem)invoiceItemBindingSource.Current;

            // Confirm Delete
            string invoiceNumber = String.Format("{0}", itemToDelete.Nomor);
            string message = String.Format("Delete Invoice '{0}' and all of its item?", invoiceNumber);
            DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Delete author
            if (result == DialogResult.Yes)
            {
                CommandDeleteInvoice deleteInvoice = new CommandDeleteInvoice(m_InvoiceList, itemToDelete);
                m_AppController.ExecuteCommand(deleteInvoice);
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            FrmStatus = FormStatus.Ready;
        }

        private void itemsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.ToString());
        }
    }
}
