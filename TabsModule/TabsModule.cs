using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabsModule.View;
using TabsModule.ViewModel;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.Infrastructure.CommonControls;
using UltimateServiceMocker.Infrastructure.Core.PrismHelper;

namespace UltimateServiceMocker.Modules
{
    public class TabsModule:ModuleBase
    {

        public TabsModule(IUnityContainer container, IRegionManagerHelper regionManagerProvider)
            : base(container, regionManagerProvider)
        {

        }
        public override void Initialize()
        {
            _container.RegisterType<ITabsUC, TabsUC>();
            _container.RegisterType<ITabsViewModel, TabsViewModel>();
        }
    }
}
