using FiddlerCoreModule;
using Microsoft.Practices.Prism.Commands;
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
        private IHttpCallsProvider httpcallsprovider;
        public void Initialize()
        {
               //GlobalCommands.FiddlerApplicationCloseCommand.RegisterCommand(new DelegateCommand(CloseFiddler, CanClose));

            _container.RegisterType<IHttpCallsProvider, HttpCallsProvider>(new ContainerControlledLifetimeManager());

              httpcallsprovider = _container.Resolve<IHttpCallsProvider>();
            httpcallsprovider.StartCapture();

        }

        public void CloseFiddler()
        {
            httpcallsprovider.StopCapture();
        }

        public bool CanClose()
        {
            return true;
        }
    }
}
