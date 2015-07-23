using GridModule.View;
using GridModule.ViewModel;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure;
namespace GridModule
{
    public class GridModule : IModule
    {
        private IUnityContainer _container;
        private IRegionManager _manager;

        public GridModule(IUnityContainer container, IRegionManager manager)
        {
            _container = container;
            _manager = manager;
        }

        public void Initialize()
        {
            _container.RegisterType<GridUC>();
            _container.RegisterType<IGridViewModel, GridViewModel>();
            _container.RegisterType<IGridUC, GridUC>();



            IViewModel vm = _container.Resolve<IGridViewModel>();

            _manager.Regions[RegionNames.ContentRegion].Add(vm.View);
        }
    }
}
