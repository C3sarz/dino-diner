/* Class: CustomizeCombo.xaml.cs
* Author: Cesar Zavala
*/
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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo combo;
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            this.combo = combo;
        }

        private void Drinks(object sender, RoutedEventArgs e)       ///Missing a way to return here.
        {
            NavigationService.Navigate(new DrinkSelection(combo.Drink));
        }

        private void CustomizeSide(object sender, RoutedEventArgs args)     ///Missing a way to return here.
        {
            NavigationService.Navigate(new SideSelection(combo.Side));
        }
    }
}
