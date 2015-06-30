using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TabstripModule.ViewModel;
using UltimateServiceMocker.Infrastructure;

namespace TabstripModule
{
    /// <summary>
    /// Interaction logic for TabstripUC.xaml
    /// </summary>
    public partial class TabstripUC : UserControl, TabstripModule.View.ITabstripUC
    {
        public TabstripUC()
        {
            InitializeComponent();
        }



        public IViewModel ViewModel
        {
            get
            {
                return (TabstripViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}
