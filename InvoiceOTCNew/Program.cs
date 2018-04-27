using System;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;

using log4net;

using InvoiceOTCNew.Helper;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]
namespace InvoiceOTCNew
{
    static class Program
    {
        public static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        // Display string representations of numbers for en-us culture
        public static readonly CultureInfo ci = new CultureInfo("en-us");

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
                    Application.Run(new FrmRibbonMenu());
                }
                else
                {
                    spi.RaiseOtherProcess();
                }
            }
        }   
    }
}
