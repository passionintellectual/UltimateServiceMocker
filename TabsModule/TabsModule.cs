using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabsModule.View;
using UltimateServiceMocker.Infrastructure;

namespace TabsModule
{
    public class TabsModule:ModuleBase
    {
        
        public TabsModule(UnityContainer container,  IRegionManagerHelper regionManagerProvider) : base(container)
        {

        }
        public override void Initialize()
        {
            _container.RegisterType<ITabsUC, TabsUC>();
        }
    }
}
