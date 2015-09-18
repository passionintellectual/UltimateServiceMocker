using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure.Business.Services;
using UltimateServiceMocker.Infrastructure.Core.Persistence;
namespace business
{
    public class CapturingService :   ICapturingService
    {
        IKeyValuePersister<string, string> _persister;
        ICertificateService _certificateService;
        public CapturingService(ICertificateService certificateService, IKeyValuePersister<string,string> persister)
        {
            _persister = persister;
            _certificateService = certificateService;
        }

        public void Start()
        {
            if (!FiddlerApplication.IsStarted())
            {
                

                FiddlerApplication.Startup(0, FiddlerCoreStartupFlags.Default);
                FiddlerApplication.Prefs.SetStringPref("fiddler.certmaker.bc.key",  _persister.Get("Key"));
                FiddlerApplication.Prefs.SetStringPref("fiddler.certmaker.bc.cert", _persister.Get("Cert"));
                /*
                 * In order for these setting to be used you have to also load the configuration settings into the Fiddler preferences *before* a call to rootCertExists() is made. I do this in the capture form’s constructor:
                 * */
                _certificateService.InstallCertificate();
            }
        }

        public void Stop()
        {
            FiddlerApplication.Shutdown();
        }

        public bool CanStart()
        {
            return !FiddlerApplication.IsStarted();
        }

        public bool CanStop()
        {
            return FiddlerApplication.IsStarted();
        }
    }
}

