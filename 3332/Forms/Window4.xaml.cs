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
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        MainWindow mainWindow;

        public Window4(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void ButtonActivator(bool _bool)
        {
            button.IsEnabled = _bool;
            button1.IsEnabled = _bool;
            button2.IsEnabled = _bool;
            button3.IsEnabled = _bool;
        }

        private async void Sleep(int deltaTime, int deltaMoney)
        {
            ButtonActivator(false);
            await Task.Delay(deltaTime);
            mainWindow.MoneyMethod(deltaMoney);
            ButtonActiveToStart();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sleep(1000, 25);
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Sleep(5000, 200);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Sleep(3000, 500);
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Sleep(5000, 1500);
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
