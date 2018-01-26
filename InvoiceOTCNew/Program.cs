using System;
using System.Windows.Forms;
using InvoiceOTCNew.Helper;

using log4net;
using System.Reflection;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]
namespace InvoiceOTCNew
{
    static class Program
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            

            /* Use this block code to prevent opening same program */
            using (SingleProgramInstanceHelper spi = new SingleProgramInstanceHelper("x5k6yz"))
            {
                if (spi.IsSingleInstance)
                {
                    Application.Run(new FrmMiniMenu());
                }
                else
                {
                    spi.RaiseOtherProcess();
                }
            }
        }        
    }
}
