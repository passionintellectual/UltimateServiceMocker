using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabstripModule;

namespace UltimateServiceMocker.Modules
{
    public class TabstripModule:IModule
    {
        private IUnityContainer _container;

        public TabstripModule(IUnityContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterType<TabstripUC>();
         
        }
    }
}
