using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateServiceMocker.Infrastructure.Core.PrismHelper
{
    public class ModuleBase :IModule
    {
        protected IUnityContainer _container;
        protected IRegionManagerHelper _regionManagerHelper;
        public ModuleBase(IUnityContainer container, IRegionManagerHelper manager)
        {
            _container = container;
            _regionManagerHelper = manager;
        }

        public virtual void Initialize()
        {
 
        }
    }
}
