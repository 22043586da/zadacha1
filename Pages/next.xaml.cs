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

namespace задача_1.Pages
{
    /// <summary>
    /// Логика взаимодействия для next.xaml
    /// </summary>
    public partial class next : Page
    {
        public next()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> s = new List<string>() { "Й", "Ц", "У", "К", "Е", "Н", "Ы", "В", "Ф", "А", "Я", "Ч", "С", "Х", "М", "Л", "О", "Р", "П" };
            string a = "k";
            try
            {
                int index = int.Parse(txName.Text.ToString());
                if (s[index] != "П")
                {
                    Exception exception = new ArgumentException();
                    throw exception;
                }
                else
                {
                    a = s[index];
                    controll.MainWindow.Frame.Navigate(controll.Pages[3]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"вы сделали ошибку, подробнее : {ex.Message}");
            }

        }
    }
}
