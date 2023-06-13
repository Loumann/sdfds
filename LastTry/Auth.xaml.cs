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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {


        db.DemoEntities con = new db.DemoEntities();



        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string log = LoginBox.Text;
            string pas = PasswordBox.Text;
            if (log.Length == 0 && pas.Length == 0)
            {
                MessageBox.Show("Заполните все поля");
            }
            var roles = con.User.Where(u => u.Login == log && u.Password == pas).FirstOrDefault();
            if (roles != null)
            {
                switch (roles.Role)
                {
                    case 1:
                        MessageBox.Show("Admin");
                        NavigationService.Navigate(move.admin);
                        break;
                    case 2:
                        MessageBox.Show("Admin");
                        NavigationService.Navigate(move.admin);
                        break;
                    case 3:
                        MessageBox.Show("Admin");
                        NavigationService.Navigate(move.admin);
                        break;
                }

            }
        }

    }
}
