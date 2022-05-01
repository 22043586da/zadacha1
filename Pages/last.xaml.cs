using System;
using System.Collections.Generic;
using System.IO;
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

namespace задача_1.Pages
{
    /// <summary>
    /// Логика взаимодействия для last.xaml
    /// </summary>
    public partial class last : Page
    {
        public last()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (File.Exists(txName.Text) == true )
                {
                    im.Source = new BitmapImage(new Uri(txName.Text));
                }
                else
                {
                    Exception exception = new ArgumentException();
                    throw exception;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка, подробнее : {ex.Message}");
            }
        }
    }
}
