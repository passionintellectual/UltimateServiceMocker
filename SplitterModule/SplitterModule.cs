using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using SplitterModule;
using SplitterModule.View;
using SplitterModule.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure;

namespace UltimateServiceMocker.Modules
{
   public class SplitterModule: IModule
    {
         private IUnityContainer _container;
         private IRegionManagerHelper _manager;

        
        public SplitterModule(IUnityContainer container, IRegionManagerHelper manager)
        {
            _container = container;
            _manager = manager;
        }

       
        public void Initialize()
        {
            
            _container.RegisterType<ISplitterViewModel, SplitterViewModel>();
            _container.RegisterType<ISplitterUC, SplitterUC>();


            IViewModel vm = _container.Resolve<ISplitterViewModel>();

           
            _manager.AddScopedRegionView(RegionNames.SplitterRegionManager , RegionNames.ContentRegion, vm);

        } 
    }
}
