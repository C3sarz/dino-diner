/* Class: EntreeSelection.xaml.cs
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

        //public EntreeSelection(Entree e,CretaceousCombo combo)
        //{
        //    InitializeComponent();
        //    entree = e;
        //    this.combo = combo;
        //}

        private void selectBWurst(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                    entree = new Brontowurst();
                    NavigationService.Navigate(new CustomizeBrontowurst(entree as Brontowurst));
                    order.Add(entree);
            }
        }
        private void selectNuggets(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new DinoNuggets();
                NavigationService.Navigate(new CustomizeNuggets(entree as DinoNuggets));
                order.Add(entree);
            }
        }
        private void selectPPBJ(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PrehistoricPBJ();
                NavigationService.Navigate(new CustomizePrehistoricPBJ((entree as PrehistoricPBJ)));
                order.Add(entree);
            }
        }
        private void selectPWings(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new PterodactylWings();
                order.Add(entree);
                NavigationService.Navigate(new MenuCategorySelection());
            }
        }
        private void selectStkBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new SteakosaurusBurger();
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(entree as SteakosaurusBurger));
                order.Add(entree);
            }
        }
        private void selectTRexKBurger(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new TRexKingBurger();
                NavigationService.Navigate(new CustomizeTrexBurger(entree as TRexKingBurger));
                order.Add(entree);
            }
        }
        private void selectVWrap(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                entree = new VelociWrap();
                NavigationService.Navigate(new CustomizeWrap(entree as VelociWrap));
                order.Add(entree);
            }
        }

    }
}
