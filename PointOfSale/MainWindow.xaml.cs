using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Order order = DataContext as Order;
            Order.NavigationService = OrderUI.NavigationService;
        }

        private void passDataContentToPage()
        {
            if (OrderUI.Content is Page page)   //could either be frameworkelement (parent) or page (further down the inheritance chain)
            {
                page.DataContext = OrderUI.DataContext;

            }

        }

        private void OnLoadCompleted(object sender, NavigationEventArgs args)
        {
            passDataContentToPage();
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            passDataContentToPage();
        }

        private void OnReturnToCategorySelection(object sender, RoutedEventArgs e)
        {
            OrderUI.NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
