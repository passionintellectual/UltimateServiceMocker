using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UltimateServiceMocker.Infrastructure;
using Microsoft.Practices.Prism.Regions;
namespace SplitterModule
{
    public class SplitterRegionManager : ISplitterRegionManager
    {
        private IRegionManager _mgr;

        public SplitterRegionManager(IRegionManager mgr)
        {
            _mgr = mgr;
        }
        public SplitterRegionManager()
        {

        }


        public IRegionManager CreateRegionManager()
        {
            return _mgr.CreateRegionManager();
        }

        public IRegionCollection Regions
        {
            get { return _mgr.Regions; }
        }
    }
}
