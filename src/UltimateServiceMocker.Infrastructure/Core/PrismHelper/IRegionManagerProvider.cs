using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateServiceMocker.Infrastructure
{
    public interface IRegionManagerHelper
    {
        void AddView(string regionName, IViewModel vm);
    }
}
