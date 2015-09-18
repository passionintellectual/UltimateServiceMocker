using business;
using Fiddler;
using FiddlerCoreModule;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Unity;
using System.Windows.Input;
using UltimateServiceMocker.Infrastructure.Business;
using UltimateServiceMocker.Infrastructure.Business.Services;
using UltimateServiceMocker.Infrastructure.Core.Persistence;


namespace UltimateServiceMocker.Modules
{
    public class FiddlerCoreModule:IModule
    {
        private IUnityContainer _container;
        private  IEventAggregator _eventAggregator;
        private ICapturingService capturingService;
        public FiddlerCoreModule(IUnityContainer container, IEventAggregator eventAggregator)
        {
            _container = container;
            _eventAggregator = eventAggregator;
            
        }
        private IHttpCallsProvider httpcallsprovider;
        private System.Windows.Input.ICommand startFiddlerCommand;
        private System.Windows.Input.ICommand closeFiddlerCommand;
        private DelegateCommand applicationExitCommand;
        public void Initialize()
        {

            _container.RegisterType<IHttpCallsProvider, HttpCallsProvider>(new ContainerControlledLifetimeManager());

              httpcallsprovider = _container.Resolve<IHttpCallsProvider>();
              _container.RegisterType<IKeyValuePersister<string, string>, AppKeyValuePersister<string>>();

              _container.RegisterType<ICapturingService, CapturingService>();

              startFiddlerCommand = new DelegateCommand(StartFiddler, CanStart);
              closeFiddlerCommand = new DelegateCommand(CloseFiddler, CanClose);
              applicationExitCommand = new DelegateCommand(ApplicationExited, CanApplicationExit);
              GlobalCommands.FiddlerApplicationCloseCommand.RegisterCommand(closeFiddlerCommand);
              GlobalCommands.FiddlerApplicationStartCommand.RegisterCommand(startFiddlerCommand);
            GlobalCommands.ApplicationExitCommand.RegisterCommand(applicationExitCommand);
            _container.RegisterType<ICertificateService, CertificateService>(new ContainerControlledLifetimeManager());
            capturingService = _container.Resolve<ICapturingService>();
              capturingService.Start();


        }

        private void ApplicationExited()
        {
            capturingService.Stop();
        }

        private bool CanApplicationExit()
        {
            return true;
        }

        private bool CanStart()
        {
            return capturingService.CanStart();
        }

        private void StartFiddler()
        {
            capturingService.Start();
            invalidateCommands();

            
        }

        private void invalidateCommands()
        {
            ((DelegateCommandBase)closeFiddlerCommand).RaiseCanExecuteChanged();
            ((DelegateCommandBase)startFiddlerCommand).RaiseCanExecuteChanged();
        }

        public void CloseFiddler()
        {
            capturingService.Stop();
            invalidateCommands();
        }

        public bool CanClose()
        {
            return capturingService.CanStop();
        }
    }
}
