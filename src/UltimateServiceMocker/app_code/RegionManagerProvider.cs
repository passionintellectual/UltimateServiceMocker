using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UltimateServiceMocker.Infrastructure;

namespace UltimateServiceMocker.app_code
{
    public class RegionManagerProvider : IRegionManagerHelper
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;
        public RegionManagerProvider(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void AddView(string regionName, IViewModel vm)
        {
            if (vm != null && vm.View != null)
            _regionManager.Regions[regionName].Add(vm.View);
        }





    }
}
