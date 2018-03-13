using System;
using System.Windows.Forms;

namespace InvoiceOTCNew.Helper
{
    public interface IMainMenu
    {
        #region Reference & Miscellanacious
        void logs_Show(object sender, EventArgs e);
        void products_Show(object sender, EventArgs e);
        void outlets_Show(object sender, EventArgs e);
        void about_Show(object sender, EventArgs e);
        #endregion

        #region Invoice
        void invoices_Show(object sender, EventArgs e);
        #endregion

        #region Print/Report
        void invoicePrint_Show(object sender, EventArgs e);
        void productsPrint_Show(object sender, EventArgs e);
        void outletsPrint_Show(object sender, EventArgs e);
        void rekapInvoice_Show(object sender, EventArgs e);
        #endregion

        void timer1_tick(object sender, EventArgs e);

        void CheckExistingForm(Form frm);
        void Form_Load(object sender, EventArgs e);
        void Form_Closing(object sender, FormClosingEventArgs e);

        void CheckSession();        

        #region Application Information Properties
        string AssemblyProduct();
        string AssemblyCopyright();
        #endregion
    }
}
