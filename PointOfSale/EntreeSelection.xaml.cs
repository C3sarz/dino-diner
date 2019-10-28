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
using DDSize = DinoDiner.Menu.Size;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;

        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree e)
        {
            InitializeComponent();
            entree = e;
        }

        private void selectBWurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new Brontowurst();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        private void selectNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                order.Add(entree);
                NavigationService.Navigate(new DrinkSelection());
            }
        }
        private void selectPPBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                order.Add(entree);
                NavigationService.Navigate(new DrinkSelection());
            }
        }
        private void selectPWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new DrinkSelection());
            }
        }
        private void selectStkBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                order.Add(entree);
                NavigationService.Navigate(new DrinkSelection());
            }
        }
        private void selectTRexKBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                order.Add(entree);
                NavigationService.Navigate(new DrinkSelection());
            }
        }
        private void selectVWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                order.Add(entree);
                NavigationService.Navigate(new DrinkSelection());
            }
        }
    }
}
