using System;
namespace UltimateServiceMocker.Infrastructure.Business.Services
{
    public interface ICertificateService
    {
        bool InstallCertificate();
        bool UninstallCertificate();
    }
}
