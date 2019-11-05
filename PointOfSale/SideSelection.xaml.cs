/* Class: SideSelection.xaml.cs
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        private Side side;
        private CretaceousCombo combo;

        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            this.side = side;
        }
        public SideSelection(Side side, CretaceousCombo combo)
        {
            InitializeComponent();
            this.side = side;
            this.combo = combo;
        }

        private void selectFryceritops(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    DDSize oldSize = combo.Size;
                    combo.Side = new Fryceritops();
                    combo.Side.Size = oldSize;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new Fryceritops();
                    order.Add(side);
                    NavigationService.Navigate(new MenuCategorySelection());
                }

            }
        }

        private void selectMnC(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    DDSize oldSize = combo.Size;
                    combo.Side = new MeteorMacAndCheese();
                    combo.Side.Size = oldSize;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new MeteorMacAndCheese();
                    order.Add(side);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        private void selectTriceritots(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    DDSize oldSize = combo.Size;
                    combo.Side = new Triceritots();
                    combo.Side.Size = oldSize;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new Triceritots();
                    order.Add(side);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        private void selectMSticks(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (combo != null)
                {
                    DDSize oldSize = combo.Size;
                    combo.Side = new MezzorellaSticks();
                    combo.Side.Size = oldSize;
                    NavigationService.Navigate(new CustomizeCombo(combo));
                }
                else
                {
                    side = new MezzorellaSticks();
                    order.Add(side);
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                side.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());
            }
        }
    }
}
