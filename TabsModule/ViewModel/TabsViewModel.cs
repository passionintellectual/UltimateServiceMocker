using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure;
using UltimateServiceMocker.Infrastructure.CommonControls;

namespace TabsModule.ViewModel
{
    public class TabsViewModel : ViewModelBase, ITabsViewModel
    {
        public TabsViewModel(IView view):base(view)
        {

        }
    }
}
