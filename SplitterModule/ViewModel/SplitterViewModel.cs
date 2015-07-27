using SplitterModule.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UltimateServiceMocker.Infrastructure;


namespace SplitterModule.ViewModel
{
    public class SplitterViewModel : ISplitterViewModel
    {
        public SplitterViewModel(ISplitterUC  view)
        {
            this.View = view;
        }


        public IView View
        {
            get;
            set;
        }
    }
}
