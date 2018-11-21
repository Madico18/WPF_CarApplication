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

namespace CarApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
      
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.mf.Source = new Uri("Pages/MainPageRef.xaml", UriKind.RelativeOrAbsolute);
            MainPageRef mpr = new MainPageRef();
            MainWindow.mf.NavigationService.Navigate(mpr);            
        }
    }
}
