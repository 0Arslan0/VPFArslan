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
using ЮсуповPractic1;

namespace ЮсуповPractic1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void BExit_Click(object sender, RoutedEventArgs e)
        {
            var dialog = MessageBox.Show("Вы уверены?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (dialog == MessageBoxResult.Yes)
            {
                Close();
            }

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            if (Window.CanGoBack)
            {
                Window.GoBack();


            }
            else
                MessageBox.Show("Отступать некуда");
        }

        private void settings_Click(object sender, RoutedEventArgs e)
        {
            Window.Navigate(new Pages.SattingPage());
        }
    }
}
