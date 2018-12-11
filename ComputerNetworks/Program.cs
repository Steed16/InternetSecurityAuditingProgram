using System;
using System.Windows.Forms;
using System.Threading;
using Titanium.Web.Proxy.Examples.Basic.Helpers;
using Titanium.Web.Proxy.Helpers;

namespace ComputerNetworks
{

    static class Program
    {

        private static readonly ProxyTestController controller = new ProxyTestController();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RandomFactList.MakeTheRandomFactList();

            if (RunTime.IsWindows)
            {
                // fix console hang due to QuickEdit mode
                ConsoleHelper.DisableQuickEditMode();
            }

            // Proteccccc.Protect();

            // Start proxy controller
            controller.StartProxy();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PowerScreen());

            controller.Stop();
        }
    }
}
