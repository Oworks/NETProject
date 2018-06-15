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

namespace displayProduit.Views
{
    /// <summary>
    /// Logique d'interaction pour ListeProd.xaml
    /// </summary>
    public partial class ListeProd : UserControl
    {
        public ListeProd()
        {
            InitializeComponent();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DetailProd_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
