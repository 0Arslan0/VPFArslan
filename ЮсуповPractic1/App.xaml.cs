using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ЮсуповPractic1.Models;

namespace ЮсуповPractic1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static YusupovBDEntities DB = new YusupovBDEntities();
        
        public static User1 user { get; internal set; }
    }
}
