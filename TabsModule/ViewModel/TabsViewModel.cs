using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabsModule.View;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.Infrastructure.CommonControls;

namespace TabsModule.ViewModel
{
    public class TabsViewModel : ViewModelBase, ITabsViewModel
    {

        public TabsViewModel(ITabsUC view):base(view)
        {

        }
    }
}
