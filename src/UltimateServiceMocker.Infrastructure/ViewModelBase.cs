using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateServiceMocker.Infrastructure
{
    public class ViewModelBase: IViewModel, INotifyPropertyChanged
    {
        public IView View { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public ViewModelBase(IView view)
        {
            View = view;
            View.ViewModel = this;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
         

    }
}
