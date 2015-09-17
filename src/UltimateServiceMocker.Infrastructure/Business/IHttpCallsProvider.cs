using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure.Domain;

namespace UltimateServiceMocker.Infrastructure.Business
{
    public interface IHttpCallsProvider
    {
          IEnumerable<IHttpCall> getHttpCalls();

          IEnumerable<IHttpCall> HttpCalls { get; set; }
          void StartCapture();
          void StopCapture();
    }
}
