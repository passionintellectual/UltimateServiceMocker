using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateServiceMocker.Infrastructure.Core.PrismHelper
{
    public class RegionManagerHelper : IRegionManagerHelper
    {
        private IUnityContainer _container;
        private IRegionManager _regionManager;
        public RegionManagerHelper(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
        public void AddView(string regionName, IViewModel vm)
        {
           // if(vm.IsNotNull() && vm.View.IsNotNull())
            _regionManager.AddToRegion(regionName, vm.View);
        }

        public void AddScopedRegionView(string regionName, IViewModel vm)
        {
            var instance = _regionManager.AddToR(regionName, vm.View, true);
            
            _container.RegisterInstance<IRegionManager>(regionName, instance);


        }
    }
}
