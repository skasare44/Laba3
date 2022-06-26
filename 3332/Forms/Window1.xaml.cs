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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        MainWindow mainWindow;

        public Window1(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void WorkWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ButtonActiveToStart();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.status.salary = 300;
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            mainWindow.status.salary = 1000;
            this.Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            mainWindow.status.salary = 7000;
            this.Close();
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            mainWindow.status.salary = 15000;
            this.Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            ButtonActiveToStart();
        }

        private void ButtonActiveToStart()
        {
            if (mainWindow.status.isPet && mainWindow.status.isMarried && mainWindow.status.isTraining)
            {
                button1.IsEnabled = true;
                button2.IsEnabled = true;
                button3.IsEnabled = true;
            }
            else if (mainWindow.status.isPet && mainWindow.status.isMarried)
            {
                button1.IsEnabled = true;
                button2.IsEnabled = true;
            }
            else if (mainWindow.status.isPet)
            {
                button1.IsEnabled = true;
            }

            button.IsEnabled = true;
        }
    }
}
