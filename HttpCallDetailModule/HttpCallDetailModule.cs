using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.Infrastructure.CommonControls;

namespace UltimateServiceMocker.Modules
{
    public class HttpCallDetailModule : UltimateServiceMocker.Infrastructure.Core.PrismHelper.ModuleBase
    {
        private IRegionManager _manager;
        public HttpCallDetailModule(IUnityContainer container, IRegionManagerHelper regionManagerHelper):base(container, regionManagerHelper)
        {

        }

        public   void Initialise(){

            var tabVM = _container.Resolve<ITabsViewModel>();
            _regionManagerHelper.AddChildView(RegionNames.SplitterRegionManager, RegionNames.SplitterRegion2, tabVM);
            
        }
    }
}
