using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var nlogConfig = new NLog.Config.LoggingConfiguration();
            nlogConfig.AddRule(LogLevel.Trace, LogLevel.Fatal,
                new NLog.Targets.FileTarget("fileTarget")
                {
                     FileName = "log.txt"
                });

            NLog.LogManager.Configuration = nlogConfig;
            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
            logger = NLog.LogManager.GetCurrentClassLogger();


            Application.Run(new Forms.Calc(logger));

           

        }
    }
}
