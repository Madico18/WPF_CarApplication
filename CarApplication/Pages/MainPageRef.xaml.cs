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
using CarApplication.Pages;

namespace CarApplication.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageRef.xaml
    /// </summary>
    public partial class MainPageRef : Page
    {
        public MainPageRef()
        {
            InitializeComponent();
        }       

        
        private void tbxVIN_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbxVIN.Text = null;
            tbxVIN.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbx1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbx1.Text = null;
            tbx1.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void tbx2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tbx2.Text = null;
            tbx2.Foreground = new SolidColorBrush(Colors.Black);
        }
    }


}
