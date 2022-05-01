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
    /// Логика взаимодействия для main.xaml
    /// </summary>
    public partial class main : Page
    {
        public main()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                if (txName.Text != "")
                {
                    controll.NameUser = int.Parse(txName.Text);
                    controll.MainWindow.Frame.Navigate(controll.Pages[2]);
                }
                else
                {
                    Exception exception = new ArgumentException();
                    throw exception;
                }
            }
            catch (Exception ex)
            {
                d.Text = "Для начала введи сколько тебе лет";
                MessageBox.Show($"Ой, внутренняя ошибка попробуйте снова\nCведения : {ex.Message}", "ERROR");
            }
            
        }

    }
}
