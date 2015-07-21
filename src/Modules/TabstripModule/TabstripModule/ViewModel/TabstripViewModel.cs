using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure;
using TabstripModule.ViewModel;
using TabstripModule.View;

namespace TabstripModule.ViewModel
{
    public class TabstripViewModel:   ITabstripViewModel
    {

        public TabstripViewModel(ITabstripUC view)
        {
            this.View = view;
        }


        public IView  View
        {
            get;
            set;
        }
    }
}
