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

namespace ЮсуповPractic1.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
            DGCatalog.ItemsSource = App.DB.Furniture.ToList();
        }

        private void BDelet_Click(object sender, RoutedEventArgs e)
        
        {
          var selClient = DGCatalog.SelectedItem as Furniture;
          if (selClient != null)
          {
                App.DB.Furniture.Remove(selClient);
                App.DB.SaveChanges();
          }
           else MessageBox.Show("Ничего не выбрано");
            DGCatalog.ItemsSource = App.DB.Furniture.ToList();
        }


            private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }
    }
}
