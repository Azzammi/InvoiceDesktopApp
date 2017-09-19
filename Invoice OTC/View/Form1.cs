using Invoice_OTC.Controller;
using Invoice_OTC.Model;
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
    public partial class Form1 : Form
    {

        #region Declarations        

        AppController m_AppController;
        InvoiceList m_Invoices;        

        CustomerList m_Customer;

        private string itemCode;
        private string itemName;

        #endregion

        #region Properties
        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
            //cekKondisi(0);            
        }

        //private void addListOfMonth()
        //{
        //    string[] monthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;
        //    periodeCmb.Items.AddRange(monthName);
        //}

        //private void addListOfYear()
        //{
        //    //string[] year;
        //    int i = 2000;
        //    do
        //    {
        //        i += 1;
        //        tahunCmb.Items.Add(i);
        //    } while (i < 2100);
        //}

        //private void addListOfRome()
        //{
        //    string[] rome = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };
        //    bulanCmb.Items.AddRange(rome);
        //}
        private void cekKondisi(int kondisi)//Enable, Disable Conctrol
        {
            ClsSupport clsSupport = new ClsSupport();
            if (kondisi == 0) //Kondisi awal, mendisable semua control
            {
                clsSupport.EmptyText(this);
                nomorTxt.Enabled = false;
                namaInstitusiCmb.Enabled = false;
                issuedDt.Enabled = false;
                totalKotorTxt.Enabled = false;
                ppnTxt.Enabled = false;
                totalBersihTxt.Enabled = false;

                //dataGridView1.DataSource = null;
                dataGridView1.Enabled = false;

            }
            else if (kondisi == 1) //Kondisi jika nomor invoice sudah terdaftar
            {
                nomorTxt.Enabled = false;
                namaInstitusiCmb.Enabled = false;
                issuedDt.Enabled = false;
                totalKotorTxt.Enabled = false;
                ppnTxt.Enabled = true;
                totalBersihTxt.Enabled = false;

                //dataGridView1.DataSource = null;
                dataGridView1.Enabled = true;


                dataGridView1.Focus();
                MessageBox.Show("Nomor invoice sudah terpakai, anda hanya bisa mengedit Qty & PPN Roti disini", "Invoice Has Been Created", MessageBoxButtons.OK);
            }
            else //Kondisi input
            {
                clsSupport.EmptyText(this);
                nomorTxt.Enabled = true;
                namaInstitusiCmb.Enabled = true;
                issuedDt.Enabled = true;
                totalKotorTxt.Enabled = true;
                ppnTxt.Enabled = true;
                totalBersihTxt.Enabled = true;

                //dataGridView1.DataSource = null;
                dataGridView1.Enabled = true;


                nomorTxt.Focus();
            }
        }
        private void tambahBtn_Click(object sender, EventArgs e)
        {
            cekKondisi(2);
            bindingCustomer.AddNew();
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah anda yakin ingin membatalkan record ini?", "Pembatalan Record", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (pesan == DialogResult.Yes)
            {
                cekKondisi(0);
            }
        }

        private void simpanBtn_Click(object sender, EventArgs e)
        {
            var pesan = MessageBox.Show("Apakah anda yakin ingin menyimpan record ini?", "Penyimpanan Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {                
                cekKondisi(0);
                /* This event will be called several times during form initialization.
                * We don't want to do anything with it until the runtime authors
                * list has been passed in. */

                // Exit if no project list
                if (m_Invoices == null) return;

                // Get the item affected
              
                InvoiceItem changedInvoice = null;             
               
                    changedInvoice = (InvoiceItem)bindingInvoice.Current;
                                      
                CommandUpdateInvoice updateInvoice = new CommandUpdateInvoice(changedInvoice);
                m_AppController.ExecuteCommand(updateInvoice);
                    
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            // Get invoices List
            CommandGetInvoices getInvoices = new CommandGetInvoices();
            m_Invoices = (InvoiceList)m_AppController.ExecuteCommand(getInvoices);

            //Get Customer List
            CommandGetCustomer getCustomer = new CommandGetCustomer();
            m_Customer = (CustomerList)m_AppController.ExecuteCommand(getCustomer);

            //Bind Grids
            bindingInvoice.DataSource = m_Invoices;
            bindingItems.DataSource = bindingInvoice;
            bindingItems.DataMember = "Items";

            namaInstitusiCmb.DataSource = m_Customer;
            bindingCustomer.DataSource = m_Customer;
        }

        private void browseRotiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(itemFrm item = new itemFrm())
            {               
                item.ShowDialog();
                
            }
            foreach (DataGridViewRow dataRow in dataGridView1.SelectedRows)
            {
                dataRow.Cells[1].Value = itemCode;
                dataRow.Cells[2].Value = itemName;
            }
        }

        private void bindingItems_AddingNew(object sender, AddingNewEventArgs e)
        {
            //Create a new book
            InvoiceItem parent = (InvoiceItem)bindingInvoice.Current;
            CommandAddItem createItem = new CommandAddItem(parent.InvoiceID);
            rotiItem newItem = (rotiItem)m_AppController.ExecuteCommand(createItem);

            //Add it to the booklist
            e.NewObject = newItem;
        }

        private void bindingItems_ListChanged(object sender, ListChangedEventArgs e)
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
                    CommandUpdateItem updateItem = new CommandUpdateItem(changedItem);
                    m_AppController.ExecuteCommand(updateItem);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        private void findStrip1_ItemFound(object sender, ItemFoundEventArgs e)
        {
            //If value found, select row
            if (e.Index >= 0)
            {
                //this.dgInvoice.ClearSelection();
               // this.dgInvoice.Rows[e.Index].Selected = true;

                //Change current list data source item
                //To ensure currency accross all controls
                //bound to this data source
                this.bindingInvoice.Position = e.Index;

                cekKondisi(1);
            }
        }

        private void bindingInvoice_ListChanged(object sender, ListChangedEventArgs e)
        {
          //  /* This event will be called several times during form initialization.
          //* We don't want to do anything with it until the runtime authors
          //* list has been passed in. */

          //  // Exit if no project list
          //  if (m_Invoices == null) return;

          //  // Get the item affected
          //  int index = e.NewIndex;
          //  InvoiceItem changedInvoice = null;
          //  if ((index > -1) && (index < m_Invoices.Count))
          //  {
          //      changedInvoice = m_Invoices[index];
          //  }
            
          //  // Get the type of change that occured
          //  ListChangedType changeType = e.ListChangedType;

          //  /* We only need to respond to two types of changes here; updates
          //   * and moves. Adds are handled by bindingSourceProjects_AddingNew(),
          //   * and deletes are handled by menuItemAuthorsDelete_Click(). */

          //  // Dispatch a change handler

          //  switch (changeType)
          //  {
          //      case ListChangedType.ItemChanged:
          //          CommandUpdateInvoice updateInvoice = new CommandUpdateInvoice(changedInvoice);
          //          m_AppController.ExecuteCommand(updateInvoice);
          //          break;

          //      case ListChangedType.ItemMoved:
          //          // Not supported in this app
          //          break;
          //  }

        }

        private void namaInstitusiCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label3.Text = namaInstitusiCmb.SelectedValue.ToString();
            //namaInstitusiCmb.Text = namaInstitusiCmb.SelectedValue.ToString();
        }
    }
}
