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

namespace LastTry
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {

        public EditProduct Edit;
        public static db.DemoEntities con = new db.DemoEntities();
        public static db.Product NewProduct { get; set; }
        public static ObservableCollection<db.Product> Products { get; set; }
        public Admin()
        {
            InitializeComponent();
            Products = new ObservableCollection<db.Product>(con.Product.ToList());
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(move.auth);
        }

        private void AddProductClick(object sender, RoutedEventArgs e)
        {
            AddProduct add = new AddProduct();
            add.ShowDialog();
        }

        private void OrderClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(move.orders);
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Edit != null) return;

             var selectedProd = LvProduct.SelectedItem as db.Product;

            Edit = new EditProduct(selectedProd);
            Edit.Closed += close;
            Edit.ShowDialog();


        }

        private void close(object sender, EventArgs e)
        {
            Edit = null;
        }
    }
}
