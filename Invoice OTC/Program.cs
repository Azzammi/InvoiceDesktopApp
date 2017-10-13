using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoice_OTC.View;

namespace Invoice_OTC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DialogResult dialogResult = MessageBox.Show("Press Enter to view in grid mode, No to view in detailed mode", "Choose View", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult != DialogResult.No)
            //{
            //    Application.Run(new dgBindingFrm());
            //}
            //else
            //{
            //    Application.Run(new detailedBindingForm(FormStatus.Ready));
            //}           

            Application.Run(new RibbonForm1("User","Level"));
        }
    }
}
