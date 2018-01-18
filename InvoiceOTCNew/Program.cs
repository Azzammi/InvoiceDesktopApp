using System;
using System.Windows.Forms;

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
            // TODO: ganti dengan user/operator pada saat login
            GlobalContext.Properties["UserName"] = "Admin";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMiniMenu());
        }
    }
}
