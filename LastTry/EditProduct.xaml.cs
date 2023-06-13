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
using System.Windows.Shapes;

namespace LastTry
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        public EditProduct Edit;
        public static db.DemoEntities con = new db.DemoEntities();
        public static db.Product EditProd { get; set; }
        public static ObservableCollection<db.Product> Products { get; set; }
        public EditProduct(db.Product prod)
        {
            InitializeComponent();
            EditProd = prod;
            DataContext = this;

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            Admin.con.Product.Remove(EditProd);
            Admin.con.SaveChanges();
            Admin.Products.Remove(EditProd);
            MessageBox.Show("Detele good ;)");
            Close();

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            Admin.con.SaveChanges();
            MessageBox.Show("Update good ;)");
        }
    }
}
