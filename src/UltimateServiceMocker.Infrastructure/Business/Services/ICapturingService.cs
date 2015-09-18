using System;
namespace UltimateServiceMocker.Infrastructure.Business.Services
{
    public interface ICapturingService
    {
        bool CanStart();
        bool CanStop();
        void Start();
        void Stop();
    }
}
