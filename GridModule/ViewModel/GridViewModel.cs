using GridModule.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UltimateServiceMocker.Infrastructure;

namespace GridModule.ViewModel
{
     
   public class GridViewModel:   IGridViewModel
    {

        public GridViewModel(IGridUC view)
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
