using FiddlerCoreModule;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;
using UltimateServiceMocker.Infrastructure.Business;

namespace UltimateServiceMocker.Modules
{
    public class FiddlerCoreModule:IModule
    {
        private IUnityContainer _container;
        private  IEventAggregator _eventAggregator;
        public FiddlerCoreModule(IUnityContainer container, IEventAggregator eventAggregator)
        {
            _container = container;
            _eventAggregator = eventAggregator;
            
        }

        public void Initialize()
        {
            _container.RegisterType<IHttpCallsProvider, HttpCallsProvider>(new ContainerControlledLifetimeManager());

            var httpcallsprovider = _container.Resolve<IHttpCallsProvider>();
            httpcallsprovider.StartCapture();
        }
    }
}
