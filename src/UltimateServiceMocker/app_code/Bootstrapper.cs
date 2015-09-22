using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;
using UltimateServiceMocker.Modules;
using Microsoft.Practices.Prism.PubSubEvents;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.app_code;

namespace UltimateServiceMocker
{
    public class Bootstrapper: UnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterType<IRegionManagerHelper, RegionManagerProvider>(new ContainerControlledLifetimeManager());

        }
        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }
        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window)Shell;
            App.Current.MainWindow.Show();
        }
        protected override void ConfigureModuleCatalog()
        {
            Type tabStripModuleType = typeof(UltimateServiceMocker.Modules.TabstripModule);
            ModuleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = tabStripModuleType.Name,
                ModuleType = tabStripModuleType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable,
            });
            Type splitterModuleType = typeof(UltimateServiceMocker.Modules.SplitterModule);
            ModuleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = splitterModuleType.Name,
                ModuleType = splitterModuleType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            });

            Type fiddlerCoreModuleType = typeof(UltimateServiceMocker.Modules.FiddlerCoreModule);
            ModuleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = fiddlerCoreModuleType.Name,
                ModuleType = fiddlerCoreModuleType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            });

            Type gridModuleType = typeof(UltimateServiceMocker.Modules.GridModule);
            ModuleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = gridModuleType.Name,
                ModuleType = gridModuleType.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            });
        }
    }
}
