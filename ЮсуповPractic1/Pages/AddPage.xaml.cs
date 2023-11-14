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
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
        }


        private void BAdd_Click(object sender, RoutedEventArgs e)
        {
            string errormessage = "";

            var user = new Furniture();
            user.Name = TBName.Text;
            user.Material = TBMaterial.Text;
            user.Type = TBType.Text;
            user.Style = TBStyle.Text;
            user.Quantity_in_stock = TBQuantity_in_stock.Text;
            if (string.IsNullOrWhiteSpace(user.Name))
            {
                errormessage += "Введите название";
            }
            if (string.IsNullOrWhiteSpace(user.Material))
            {
                errormessage += "Введите материал";
            }
            if (string.IsNullOrWhiteSpace(user.Type))
            {
                errormessage += "Введите тип";
            }
            if (string.IsNullOrWhiteSpace(user.Style))
            {
                errormessage += "Введите стиль";
            }
            if (string.IsNullOrWhiteSpace(user.Quantity_in_stock))
            {
                errormessage += "Введите количество";
            }
            App.DB.Furniture.Add(user);
            App.DB.SaveChanges();
            App.DB.Furniture.Remove(user);
            NavigationService.Navigate(new CatalogPage());
        }
    }
}
