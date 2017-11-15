using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_OTC.Controller.Outlet;
using Invoice_OTC.Controller;
using Invoice_OTC.Model;

namespace Invoice_OTC.View
{
    public partial class dgBindingFrm : Form
    {
        #region Declaration
        AppController m_AppController;
        InvoiceList m_Invoices;
        outletList m_OutletList;
        RotiToChooseList m_RotiList;
        #endregion
        public dgBindingFrm()
        {
            InitializeComponent();
        }

        private void dgBindingFrm_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Customer List
            CommandGettingOutlet getOutlets = new CommandGettingOutlet();
            m_OutletList = (outletList)m_AppController.ExecuteCommand(getOutlets);

            // Get invoices List
            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_Invoices = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            CommandGetRoti getRoti = new CommandGetRoti();
            m_RotiList = (RotiToChooseList)m_AppController.ExecuteCommand(getRoti);

            //Bind Grids            
            outletItemBindingSource.DataSource = m_OutletList;
            rotiToChooseItemBindingSource.DataSource = m_RotiList;

            bindingInvoice.DataSource = m_Invoices;
            bindingItem.DataSource = bindingInvoice;
            bindingItem.DataMember = "Items";
        }            

        private void bindingInvoice_ListChanged(object sender, ListChangedEventArgs e)
        {
             // Exit if no project list
            if (m_Invoices == null) return;

            // Get the item affected
            int index = e.NewIndex;
            InvoiceItem changedInvoice = null;
            if ((index > -1) && (index < m_Invoices.Count))
            {
                changedInvoice = m_Invoices[index];
            }
            
            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            /* We only need to respond to two types of changes here; updates
             * and moves. Adds are handled by bindingSourceProjects_AddingNew(),
             * and deletes are handled by menuItemAuthorsDelete_Click(). */

            // Dispatch a change handler
            
            switch (changeType)
            {
                case ListChangedType.ItemChanged:                     
                    if(changedInvoice.Nomor != null)
                    {
                        CommandUpdateInvoice updateAuthor = new CommandUpdateInvoice(changedInvoice);
                        m_AppController.ExecuteCommand(updateAuthor);
                    }
                    else
                    {
                        CommandDeleteInvoice deleteInvoice = new CommandDeleteInvoice(m_Invoices, changedInvoice);
                        m_AppController.ExecuteCommand(deleteInvoice);
                    }                    
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }

            decimal totalValue = 0;
            foreach(InvoiceItem item in m_Invoices)
            {
                totalValue += item.Total;
            }

            toolStripLabel1.Text = "Total Tagihan : " + string.Format("{0:n0}",totalValue);
            toolStripLabel2.Text = "Count : " + string.Format("{0:n0}",m_Invoices.Count);
        }

        private void bindingInvoice_AddingNew(object sender, AddingNewEventArgs e)
        {
            /* This event will be called several times during form initialization.
             * We don't want to do anything with it until the runtime authors
             * list has been passed in. */

            // Exit if no project list
            if (m_Invoices == null) return;

            // Create a new project
            commandInsertInvoice createInvoice = new commandInsertInvoice();
            InvoiceItem newInvoice = (InvoiceItem)m_AppController.ExecuteCommand(createInvoice);

            /* Since the BindingSource is managing the collection, we pass the new 
             * author to the BindingSource, using the NewObject property of the 
             * event args. The BindingSource will add the new author to the 
             * AuthorList for us. */

            // Add it to theAuthors list
            e.NewObject = newInvoice;
        }

        private void bindingItem_AddingNew(object sender, AddingNewEventArgs e)
        {
            //Create a new book
            InvoiceItem parent = (InvoiceItem)bindingInvoice.Current;

            CommandAddItem createItem = new CommandAddItem(parent.InvoiceID);
            rotiItem newItem = (rotiItem)m_AppController.ExecuteCommand(createItem);

            //Add it to the booklist
            e.NewObject = newItem;
        }

        private void bindingItem_ListChanged(object sender, ListChangedEventArgs e)
        {
            /* This event will be called several times during form initialization.
             * We don't want to do anything with it until the runtime author
             * list has been passed in. */

            // Exit if no parent
            InvoiceItem parent = (InvoiceItem)bindingInvoice.Current;
            if (parent == null) return;

            // Get the item affected
            int index = e.NewIndex;
            rotiItem changedItem = null;
            if ((index > -1) && (index < parent.Items.Count))
            {
                changedItem = parent.Items[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            /* We only need to respond to two types of changes here; updates
             * and moves. Adds are handled by bindingSourceAuthors_AddingNew(),
             * and deletes are handled by menuItemBooksDelete_Click(). */

            // Dispatch a change handler
            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    if(changedItem.ItemCode != null)
                    {
                        CommandUpdateItem updateItem = new CommandUpdateItem(changedItem);
                        m_AppController.ExecuteCommand(updateItem);
                    }
                    else
                    {
                        CommandDeleteItem deleteItem = new CommandDeleteItem(changedItem);
                        m_AppController.ExecuteCommand(deleteItem);
                    }
                    
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }

            m_Invoices.ResetBindings();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
             // Confirm Delete 
            string message = String.Format("Delete Invoices and all of its item?");
            DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Delete author
            if (result == DialogResult.Yes)
            {                
                foreach (DataGridViewRow row in dgInvoice.SelectedRows)
                {
                    InvoiceItem item = row.DataBoundItem as InvoiceItem;
                    if (item != null)
                    {
                        CommandDeleteInvoice deleteInvoice = new CommandDeleteInvoice(m_Invoices, item);
                        m_AppController.ExecuteCommand(deleteInvoice);
                    }

                }
            }
        }

        private void deleteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Get Item Roti
            InvoiceItem parent = (InvoiceItem)bindingInvoice.Current;            

            //Confirm Delete
            string message = String.Format("Delete Items ? ");
            DialogResult result = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Delete Item
            if(result == DialogResult.Yes)
            {             
                foreach (DataGridViewRow row in dgItem.SelectedRows)
                {
                    rotiItem item = row.DataBoundItem as rotiItem;
                    if (item != null)
                    {
                        CommandDeleteItem deleteItem = new CommandDeleteItem(parent, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }

        private void findStrip1_ItemFound(object sender, ItemFoundEventArgs e)
        {
            //If value found, select row
            if (e.Index >= 0)
            {
                this.dgInvoice.ClearSelection();
                this.dgInvoice.Rows[e.Index].Selected = true;

                //Change current list data source item
                //To ensure currency accross all controls
                //bound to this data source
                this.bindingInvoice.Position = e.Index;
            }
        }

        private void dgInvoice_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(e.Exception.ToString());
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InvoiceItem nomorValue = (InvoiceItem)bindingInvoice.Current;

            FrmInvoicePrint form = new FrmInvoicePrint(nomorValue.Nomor);
            form.ShowDialog();
        }
        
        private void bindingItem_CurrentChanged(object sender, EventArgs e)
        {
            if (m_Invoices == null) return;
            //rotiItem checkEmpty = (rotiItem)bindingItem.Current;

            //if(checkEmpty.Code == null)
            //{
            //    CommandDeleteItem deleteItem = new CommandDeleteItem(checkEmpty);
            //    m_AppController.ExecuteCommand(deleteItem);
            //}            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
