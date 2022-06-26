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
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        MainWindow mainWindow;

        public Window3(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(0);
            mainWindow.MoodMethod(10, 0);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(-500);
            mainWindow.MoodMethod(30, 500);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(-5000);
            mainWindow.MoodMethod(50, 5000);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            mainWindow.MoneyMethod(-15000);
            mainWindow.MoodMethod(100, 15000);
        }
    }
}
