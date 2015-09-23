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

        public void AddChildView(string regionManagerName, string regionName, IViewModel vm)
        {
            var mgr = _container.Resolve<IRegionManager>(regionManagerName);
            mgr.AddToRegion(regionName, vm.View);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scopedRegionManagerName"></param>
        /// <param name="regionName"></param>
        /// <param name="vm"></param>
        /// <returns></returns>
        public IRegionManager AddScopedRegionView(string scopedRegionManagerName, string regionName, IViewModel vm)
        {
            var instance = _regionManager.Regions[regionName].Add(vm.View, null, true);

            _container.RegisterInstance<IRegionManager>(scopedRegionManagerName, instance);

            return instance;
        }
    }
}
