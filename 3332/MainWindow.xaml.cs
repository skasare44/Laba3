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
using System.Windows.Threading;

namespace Laba3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Classes.Status status;
        public DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StartMethod();
        }

        private void StartMethod()
        {
            status = new Classes.Status(this);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            switch (status.month)
            {
                case 1:
                    DaysMethod(31);
                    break;
                case 2:
                    DaysMethod(28);
                    break;
                case 3:
                    DaysMethod(31);
                    break;
                case 4:
                    DaysMethod(30);
                    break;
                case 5:
                    DaysMethod(31);
                    break;
                case 6:
                    DaysMethod(30);
                    break;
                case 7:
                    DaysMethod(31);
                    break;
                case 8:
                    DaysMethod(31);
                    break;
                case 9:
                    DaysMethod(30);
                    break;
                case 10:
                    DaysMethod(31);
                    break;
                case 11:
                    DaysMethod(30);
                    break;
                case 12:
                    DaysMethod(31);
                    break;
            }
        }

        private void DaysMethod(int MonthLenght)
        {
            if(status.day < MonthLenght)
            {
                status.day++;
                HungryMethod(-1, 0);
                MoodMethod(-1, 0);
            }
            else if (status.month < 12)
            {
                status.month++;
                status.day = 1;
                MoneyMethod(status.salary);
                HungryMethod(-1, 0);
                MoodMethod(-1, 0);
            }
            else
            {
                status.year++;
                status.month = 1;
                status.day = 1;
                MoneyMethod(status.salary);
                HungryMethod(-1, 0);
                MoodMethod(-1, 0);
            }
            DataLabel.Content = string.Format("{0:00}/{1:00}/{2}", status.day, status.month, status.year);
        }

        public void MoneyMethod(int deltaMoney)
        {
            status._money += deltaMoney;
        }

        public void HungryMethod(int deltaHungry, int moneyNeed)
        {
            if(moneyNeed <= status._money)
                status._hungry += deltaHungry;
        }

        public void MoodMethod(int deltaMood, int moneyNeed)
        {
            if(moneyNeed <= status._money)
                status._mood += deltaMood;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Forms.Window1 window1 = new Forms.Window1(this);
            window1.Show();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Forms.Window2 window2 = new Forms.Window2(this);
            window2.Show();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Forms.Window3 window3 = new Forms.Window3(this);
            window3.Show();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            Forms.Window4 window4 = new Forms.Window4(this);
            window4.Show();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (status._money >= 1000)
            {
                MoneyMethod(-1000);
                FindOwner.IsEnabled = false;
                Status.Content = "Домашний";
                status.isPet = true;
            }
            else
                MessageBox.Show("Недостаточно денег");
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            if (status._money >= 7000)
            {
                MoneyMethod(-7000);
                FindFemale.IsEnabled = false;
                Sp.Content = "Женат";
                status.isMarried = true;
            }
            else
                MessageBox.Show("Недостаточно денег");
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            if (status._money >= 30000)
            {
                MoneyMethod(-30000);
                Training.IsEnabled = false;
                Dres.Content = "Дрессирован";
                status.isTraining = true;
            }
            else
                MessageBox.Show("Недостаточно денег");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            status.SaveMethod();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            status.ClearMethod();
            status.LoadMethod();
            newGame.Visibility = Visibility.Hidden;
            LoadGame.Visibility = Visibility.Hidden;
            MainPanel.Visibility = Visibility.Hidden;
            timer.Start();
        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {
            status.LoadMethod();
            newGame.Visibility = Visibility.Hidden;
            LoadGame.Visibility = Visibility.Hidden;
            MainPanel.Visibility = Visibility.Hidden;
            timer.Start();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            newGame.Visibility = Visibility.Visible;
            LoadGame.Visibility = Visibility.Visible;
            MainPanel.Visibility = Visibility.Visible;
        }
    }
}
