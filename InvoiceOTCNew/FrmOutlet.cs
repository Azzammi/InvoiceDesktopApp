using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceOTC.Model;
using InvoiceOTC.Repository.API;
using InvoiceOTC.Repository.Service;
using FSCollections;

namespace InvoiceOTCNew
{
    public partial class FrmOutlet : Form
    {
        #region Declaration
        private IOutletRepository m_Outlet;
        private FSBindingList<Outlet> outletList;
        #endregion

        public FrmOutlet()
        {
            InitializeComponent();

            m_Outlet = new OutletRepository();
        }

        public void BindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            
        }

        public void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            // Exit if no project list
            if (outletList == null) return;

            // Get the item affected
            int index = e.NewIndex;
            Outlet changedOutlet = null;
            if ((index > -1) && (index < outletList.Count))
            {
                changedOutlet = outletList[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            // Dispatch a change handler

            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    var result = m_Outlet.Update(changedOutlet);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        private void FrmOutlet_Load(object sender, EventArgs e)
        {
            outletList = m_Outlet.GetAllSorted();
            outletBindingSource.DataSource = outletList;
        }

        private void outletBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outletBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Outlet newOutlet = (Outlet)outletBindingSource.Current;
            var result = m_Outlet.Save(newOutlet);

            if(result != 0) { MessageBox.Show("Berhasil"); }
            button1.PerformClick();
        }
    }
}
