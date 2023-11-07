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
using ЮсуповPractic1.Models;
using ЮсуповPractic1.Pages;
using ЮсуповPractic1.Properties;

namespace ЮсуповPractic1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void BEnter_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User1.FirstOrDefault(x => x.Login == Tlogin.Text && x.Password == Password.Password);
            if(user == null )
            {
                MessageBox.Show("Данные неверны");
                return;
            }

            App.user = user;
            NavigationService.Navigate(new DobroPage());
        }

        private void BRegistration_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
