using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateServiceMocker.Infrastructure.Domain
{
    public interface IHttpCall
    {
         string FullUrl { get; set; }
    }
}
