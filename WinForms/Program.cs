using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;

namespace WinForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        public static UnityContainer Container { get; set; }    


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Container = new UnityContainer();

            var nlogConfig = new NLog.Config.LoggingConfiguration();
            nlogConfig.AddRule(LogLevel.Trace, LogLevel.Fatal,
                new NLog.Targets.FileTarget("fileTarget")
                {
                     FileName = "log.txt"
                });

            NLog.LogManager.Configuration = nlogConfig;
            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

            Container.RegisterInstance(logger); 


            Container.RegisterInstance(new Random());

            Container.RegisterType<Services.IRandom, Services.SimpleRandom>();
            
           

            Application.Run(Container.Resolve<Forms.PortalForm>());

           

        }
    }
}
