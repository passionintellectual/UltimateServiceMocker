using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UltimateServiceMocker ;
using UltimateServiceMocker.Infrastructure.Business;

namespace UltimateServiceMocker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Bootstrapper bootstrapper = new Bootstrapper();
            bootstrapper.Run();
            GlobalCommands.ApplicationStartCommand.Execute(null);

        }
        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            GlobalCommands.ApplicationExitCommand.Execute(null);

        }
    }
}
