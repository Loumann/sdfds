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
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {

        public static db.DemoEntities con = new db.DemoEntities();
        public static db.Product NewProduct { get; set; }
        public static ObservableCollection<db.Product> Products { get; set; }
        public AddProduct()
        {
            InitializeComponent();
            DataContext = this;
            NewProduct = new db.Product();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            con.Product.Add(NewProduct);
            int result = con.SaveChanges();
            if (result != 0)
            {
                con.Product.Add(NewProduct);
                NewProduct = new db.Product();
                MessageBox.Show("All good :)");
                Close();
            }
            else
            {
                MessageBox.Show("All bad :(");

            }


        }
    }
}
