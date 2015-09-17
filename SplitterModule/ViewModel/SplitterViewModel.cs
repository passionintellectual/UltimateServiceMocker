using SplitterModule.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UltimateServiceMocker.Infrastructure;


namespace SplitterModule.ViewModel
{
    public class SplitterViewModel : ViewModelBase,  ISplitterViewModel
    {
        public SplitterViewModel(ISplitterUC  view)
            : base(view)
        {
           
        }



    }
}
