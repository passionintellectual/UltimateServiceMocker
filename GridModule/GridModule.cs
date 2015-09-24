using GridModule.View;
using GridModule.ViewModel;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.Infrastructure.Core.PrismHelper;
namespace UltimateServiceMocker.Modules
{
    public class GridModule : ModuleBase
    {
        private IUnityContainer _container;
        private IRegionManagerHelper _mgrHelper;
        
        public GridModule(IUnityContainer container, IRegionManagerHelper regionMgrHelper):base(container, regionMgrHelper)
        {
            _container = container;
            _mgrHelper = regionMgrHelper;
                     }

        public override void Initialize()
        {
           
            _container.RegisterType<GridUC>();
            _container.RegisterType<IGridViewModel, GridViewModel>();
            _container.RegisterType<IGridUC, GridUC>();
            IViewModel vm = _container.Resolve<IGridViewModel>();
            // _manager.Regions[RegionNames.SplitterRegion2].Add(vm.View);
            // SplitterModule.mgr.Regions[RegionNames.SplitterRegion2].Add(vm.View);
            //_mgrHelper.Regions[RegionNames.SplitterRegion1].Add(vm.View);
            _mgrHelper.AddChildView(RegionNames.SplitterRegionManager, RegionNames.SplitterRegion1, vm);
        }
    }
}
