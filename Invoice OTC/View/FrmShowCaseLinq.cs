using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Table<ITEM> items = db.GetTable<ITEM>();

            //Get all author
            var allItem = from roti in items select roti;

            //Set binding source datasource to linq select result
            bindingSource1.DataSource = allItem;

            //Set datagridview datasource to binding source
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
