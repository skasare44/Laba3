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
using System.Windows.Shapes;

namespace Laba3.Forms
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MainWindow mainWindow;

        public Window2(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(0);
            mainWindow.HungryMethod(1, 0);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(-100);
            mainWindow.HungryMethod(10, 100);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(-500);
            mainWindow.HungryMethod(30, 500);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(-5000);
            mainWindow.HungryMethod(50, 5000);
        }
    }
}
