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

namespace задача_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            Frame.Margin = new Thickness(((this.Width / 100) * 5), ((this.Height / 100) * 5), ((this.Width / 100) * 5), ((this.Height / 100) * 5));
            controll.MainWindow = this;
            controll.Pages.Add(new Pages.Hello());
            controll.Pages.Add(new Pages.main());
            controll.Pages.Add(new Pages.next());
            controll.Pages.Add(new Pages.last());
            Frame.Navigate(controll.Pages[0]);
        }
    }
}
