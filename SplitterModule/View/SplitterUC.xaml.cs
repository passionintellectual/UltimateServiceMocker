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
using SplitterModule.ViewModel;
using SplitterModule.View;

namespace SplitterModule
{
    /// <summary>
    /// Interaction logic for SplitterUC.xaml
    /// </summary>
    public partial class SplitterUC : UserControl , ISplitterUC
    {
        public SplitterUC()
        {
            InitializeComponent();
        }

        public UltimateServiceMocker.Infrastructure.IViewModel ViewModel
        {
            get
            {
                return (SplitterViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}
