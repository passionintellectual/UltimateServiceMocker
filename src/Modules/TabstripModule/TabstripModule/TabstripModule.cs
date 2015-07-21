using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabstripModule;
using TabstripModule.View;
using TabstripModule.ViewModel;
using UltimateServiceMocker.Infrastructure;

namespace UltimateServiceMocker.Modules
{
    public class TabstripModule:IModule
    {
        private IUnityContainer _container;
        private IRegionManager _manager;

        public TabstripModule(IUnityContainer container, IRegionManager     manager)
        {
            _container = container;
            _manager = manager;
        }

        public void Initialize()
        {
            _container.RegisterType<TabstripUC>();
            _container.RegisterType<ITabstripViewModel, TabstripViewModel>();
            _container.RegisterType<ITabstripUC, TabstripUC>();



            IViewModel vm = _container.Resolve<ITabstripViewModel>();

            _manager.Regions[RegionNames.ToolbarRegion].Add(vm.View);
        }
    }
}
