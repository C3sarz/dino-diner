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
using DDSize = DinoDiner.Menu.Size;

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
            if (combo.Entree is PterodactylWings) CustomEntree.IsEnabled = false;
        }

        private void Drinks(object sender, RoutedEventArgs e)       ///Missing a way to return here.
        {
            NavigationService.Navigate(new DrinkSelection(combo.Drink, combo));
        }

        private void CustomizeSide(object sender, RoutedEventArgs args)     ///Missing a way to return here.
        {
            NavigationService.Navigate(new SideSelection(combo.Side,combo));
        }

        private void CustomizeEntree(object sender, RoutedEventArgs args)     ///Missing a way to return here.
        {
            if(combo.Entree is Brontowurst)
            {
                NavigationService.Navigate(new CustomizeBrontowurst(combo.Entree as Brontowurst));
            }
            else if (combo.Entree is DinoNuggets)
            {
                NavigationService.Navigate(new CustomizeNuggets(combo.Entree as DinoNuggets));
            }
            else if (combo.Entree is PrehistoricPBJ)
            {
                NavigationService.Navigate(new CustomizePrehistoricPBJ(combo.Entree as PrehistoricPBJ));
            }
            else if (combo.Entree is SteakosaurusBurger)
            {
                NavigationService.Navigate(new CustomizeSteakosaurusBurger(combo.Entree as SteakosaurusBurger));
            }
            else if (combo.Entree is TRexKingBurger)
            {
                NavigationService.Navigate(new CustomizeTrexBurger(combo.Entree as TRexKingBurger));
            }
            else if (combo.Entree is VelociWrap)
            {
                NavigationService.Navigate(new CustomizeWrap(combo.Entree as VelociWrap));
            }
        }

        private void OnChangeSize(object sender, RoutedEventArgs args)
        {
            if (sender is FrameworkElement element)
            {
                combo.Size = (DDSize)Enum.Parse(typeof(DDSize), element.Tag.ToString());

            }
        }
    }
}
