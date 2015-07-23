using GridModule.ViewModel;
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
using UltimateServiceMocker.Infrastructure;

namespace GridModule.View
{
    /// <summary>
    /// Interaction logic for Grid.xaml
    /// </summary>
    public partial class GridUC : UserControl, IGridUC
    {
        public GridUC()
        {
            InitializeComponent();
        }

        public IViewModel ViewModel
        {
            get
            {
                return (GridViewModel)DataContext;
            }
            set
            {
                DataContext = value;
            }
        }
    }
}
