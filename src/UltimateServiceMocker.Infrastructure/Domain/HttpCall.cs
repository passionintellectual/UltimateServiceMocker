using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure.Domain;

namespace UltimateServiceMocker.Infrastructure.Domain
{
    public class HttpCall : IHttpCall
    {
        public string FullUrl { get; set; }
    }
}
