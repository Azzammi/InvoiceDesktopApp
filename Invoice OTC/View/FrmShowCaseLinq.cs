using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Invoice_OTC.Model;

namespace Invoice_OTC.View
{
    public partial class FrmShowCaseLinq : Form
    {
        public FrmShowCaseLinq()
        {
            InitializeComponent();
        }

        private void FrmShowCaseLinq_Load(object sender, EventArgs e)
        {
            //Set the connection
            DataClasses1DataContext db = new DataClasses1DataContext();

            //Get a typed table
            Table<OUTLET> items = db.GetTable<OUTLET>();

            //Get all author
            var allItem = from roti in items select roti;

            foreach (var item in allItem)
            {
                
            }
            outletGenericList<OUTLET> dataOutlet = new outletGenericList<OUTLET>(allItem.ToList());
            //Set binding source datasource to linq select result
            bindingSource1.DataSource = dataOutlet.BindingLists;

            //Set datagridview datasource to binding source
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string message = "The quick brown fox jumps over the lazy DOg";
            string subString = "ump";

            MessageBox.Show(subString + " in the " + message + " was : " + message.Contains(subString,StringComparison.OrdinalIgnoreCase));
        }
    }
}
