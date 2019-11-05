/* Class: DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// Holds the current drink.
        /// </summary>
        private Drink drink;
        private CretaceousCombo combo;

        public DrinkSelection()
        {
            InitializeComponent();
            HoldIce.IsEnabled = false;
            Lemon.IsEnabled = false;
            Special.IsEnabled = false;
        }

        public DrinkSelection(Drink d)
        {
            InitializeComponent();
            drink = d;
        }

        public DrinkSelection(Drink d, CretaceousCombo combo)
        {
            InitializeComponent();
            drink = d;
            this.combo = combo;
        }

        /// <summary>
        /// Handles the size changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                drink.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
                if (combo != null) combo.Drink = drink;
            }
        }

        private void selectSoda(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    drink = new Sodasaurus();
                    combo.Drink = drink;
                }
                else
                {
                    drink = new Sodasaurus();
                    order.Add(drink);
                }
                HoldIce.IsEnabled = true;
                Special.IsEnabled = true;
                Lemon.IsEnabled = false;
            }
        }
        private void selectTea(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    drink = new Tyrannotea();
                    combo.Drink = drink;
                }
                else
                {
                    drink = new Tyrannotea();
                    order.Add(drink);
                }
                Special.IsEnabled = true;
                HoldIce.IsEnabled = true;
                Lemon.IsEnabled = true;
            }
        }
        private void selectJJava(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    drink = new JurassicJava();
                    combo.Drink = drink;
                }
                else
                {
                    drink = new JurassicJava();
                    order.Add(drink);
                }
            }
            Lemon.IsEnabled = false;
            HoldIce.IsEnabled = false;
            Special.IsEnabled = true;
        }
        private void selectWater(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    drink = new Water();
                    combo.Drink = drink;
                }
                else
                {
                    drink = new Water();
                    order.Add(drink);

                }
                Special.IsEnabled = false;
                HoldIce.IsEnabled = true;
                Lemon.IsEnabled = true;
            }
        }

        private void OnSelectSpecial(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                if (drink is JurassicJava coffee)
                {
                    coffee.Decaf = true;
                    combo.Drink = drink;
                }
                if (drink is Tyrannotea tea)
                {
                    tea.Sweet = true;
                    combo.Drink = drink;
                }
                if (drink is Sodasaurus soda)
                {
                    NavigationService.Navigate(new FlavorSelection(combo.Drink as Sodasaurus));
                }
            }
            else
            {
                if (drink is JurassicJava coffee)
                {
                    coffee.Decaf = true;
                }
                if (drink is Tyrannotea tea)
                {
                    tea.Sweet = true;
                }
                if (drink is Sodasaurus soda)
                {
                    NavigationService.Navigate(new FlavorSelection(soda));
                }
            }
        }

        private void OnSelectHoldIce(object sender, RoutedEventArgs e)
        {
            if (drink is Water water)
            {
                water.HoldIce();
                if(combo != null) combo.Drink = drink;
            }
            if (drink is Tyrannotea tea)
            {
                tea.HoldIce();
                if (combo != null) combo.Drink = drink;
            }
            if (drink is Sodasaurus soda)
            {
                soda.HoldIce();
                if (combo != null) combo.Drink = drink;
            }
        }
        private void OnSelectAddLemon(object sender, RoutedEventArgs e)
        {
            if (drink is Water water)
            {
                water.AddLemon();
                if (combo != null) combo.Drink = drink;
            }
            if (drink is Tyrannotea tea)
            {
                tea.AddLemon();
                if (combo != null) combo.Drink = drink;
            }
        }

        private void OnDone(object sender, RoutedEventArgs e)
        {
            if (combo != null)
            {
                NavigationService.Navigate(new CustomizeCombo(combo));
            }
            else NavigationService.Navigate(new MenuCategorySelection());
        }

    }
}
