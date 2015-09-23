using Microsoft.Practices.Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UltimateServiceMocker.Infrastructure
{
    public interface IRegionManagerHelper
    {
        void AddView(string regionName, IViewModel vm);

        void AddChildView(string regionManagerName, string regionName, IViewModel vm);
        IRegionManager AddScopedRegionView(string scopedRegionManagerName, string regionManager, IViewModel vm);
    }
}
