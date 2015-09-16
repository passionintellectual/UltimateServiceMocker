using Microsoft.Practices.Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure.Domain;

namespace UltimateServiceMocker.Infrastructure.Business.HttpCaptureEvents
{
    public class AfterSessionCompleteEvent: CompositePresentationEvent<IHttpCall>
    {
    }
}
