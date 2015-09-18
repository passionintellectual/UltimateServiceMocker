using Fiddler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure.Core.Persistence;
using UltimateServiceMocker.Infrastructure.Business.Services;
namespace business
{
    public class CertificateService : ICertificateService
    { 
        public IKeyValuePersister<string, string> _persistingService { get; set; }
        public CertificateService(IKeyValuePersister<string, string> persistingService)
        {
            _persistingService = persistingService;
        }
        public   bool InstallCertificate()
        {
            if (!CertMaker.rootCertExists())
            {
                if (!CertMaker.createRootCert())
                    return false;

                if (!CertMaker.trustRootCert())
                    return false;



                _persistingService.Save("Cert" ,FiddlerApplication.Prefs.GetStringPref("fiddler.certmaker.bc.cert", null));
                _persistingService.Save("Key" , FiddlerApplication.Prefs.GetStringPref("fiddler.certmaker.bc.key", null));
            }

            return true;
        }

        public   bool UninstallCertificate()
        {
            if (CertMaker.rootCertExists())
            {
                if (!CertMaker.removeFiddlerGeneratedCerts(true))
                    return false;
            }

            _persistingService.Save("Cert", null);
            _persistingService.Save("Key", null);
            return true;
        }
    }
}
