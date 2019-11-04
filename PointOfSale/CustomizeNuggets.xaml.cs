/* Class: CustomizeNuggets.xaml.cs
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
    /// Interaction logic for CustomizeNuggets.xaml
    /// </summary>
    public partial class CustomizeNuggets : Page
    {
        private DinoNuggets dn;
        public CustomizeNuggets(DinoNuggets dn)
        {
            InitializeComponent();
            this.dn = dn;
        }

        /// <summary>
        /// Adds a nugget.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void AddNugget(object sender, RoutedEventArgs args)
        {
            dn.AddNugget();
        }

        /// <summary>
        /// Takes you to the previous page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnDone(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }
    }
}
