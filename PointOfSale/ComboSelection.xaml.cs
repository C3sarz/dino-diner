/* Class: ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }

        private void selectBWurstCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
                NavigationService.Navigate(new CustomizeCombo(combo));
                order.Add(combo);
            }
        }
        private void selectNuggetsCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
                NavigationService.Navigate(new CustomizeCombo(combo));
                order.Add(combo);
            }
        }
        private void selectPPBJCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PrehistoricPBJ());
                NavigationService.Navigate(new CustomizeCombo(combo));
                order.Add(combo);
            }
        }
        private void selectPWingsCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new PterodactylWings());
                NavigationService.Navigate(new CustomizeCombo(combo));
                order.Add(combo);
            }
        }
        private void selectStkBurgerCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new SteakosaurusBurger());
                NavigationService.Navigate(new CustomizeCombo(combo));
                order.Add(combo);
            }
        }
        private void selectTRexKBurgerCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new TRexKingBurger());
                NavigationService.Navigate(new CustomizeCombo(combo));
                order.Add(combo);
            }
        }
        private void selectVWrapCombo(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CretaceousCombo combo = new CretaceousCombo(new VelociWrap());
                NavigationService.Navigate(new CustomizeCombo(combo));
                order.Add(combo);
            }
        }
    }
}
