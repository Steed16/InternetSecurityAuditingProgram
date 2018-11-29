using System;
using System.Threading;
using System.Windows.Forms;

namespace ComputerNetworks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Thread(() => {
                new Monitor();
            }).Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PowerScreen());
        }
    }
}
