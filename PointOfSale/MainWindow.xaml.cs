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
            ObservableCollection<IOrderItem> list = new ObservableCollection<IOrderItem>();
            list.Add(new PrehistoricPBJ());
            list.Add(new Fryceritops());
            list.Add(new Sodasaurus());
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            list.Add(sb);
            order.Items = list;
            DataContext = order;
        }
    }
}
