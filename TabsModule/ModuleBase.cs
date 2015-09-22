using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateServiceMocker.Infrastructure
{
    public class ModuleBase :IModule
    {
        protected UnityContainer _container;
        public ModuleBase(UnityContainer container)
        {
            _container = container;
        }
        public virtual void Initialize()
        {
             
        }
    }
}
