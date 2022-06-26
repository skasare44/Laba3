using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba3.Classes
{
    public class Status
    {
        MainWindow mainWindow;

        private int hungry = 100;
        private int mood = 100;
        private int money = 100;

        public bool isPet = false;
        public bool isTraining = false;
        public bool isMarried = false;
        public int salary = 0;
        public int day = 1;
        public int month = 1;
        public int year = 2000;

        public Status(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        public void LoadMethod()
        {
            _hungry = Properties.Settings.Default.hungry;
            _money = Properties.Settings.Default.money;
            _mood = Properties.Settings.Default.mood;
            isPet = Properties.Settings.Default.isPet;
            if (isPet)
                mainWindow.Status.Content = "Домашний";
            isTraining = Properties.Settings.Default.isTraining;
            if (isPet)
                mainWindow.Sp.Content = "Женат";
            isMarried = Properties.Settings.Default.isMarried;
            if (isPet)
                mainWindow.Dres.Content = "Дрессирован";
            salary = Properties.Settings.Default.salary;
            day = Properties.Settings.Default.day;
            month = Properties.Settings.Default.month;
            year = Properties.Settings.Default.year;
        }

        public void SaveMethod()
        {
            Properties.Settings.Default.hungry = _hungry;
            Properties.Settings.Default.money = _money;
            Properties.Settings.Default.mood = _mood;
            Properties.Settings.Default.isPet = isPet;
            Properties.Settings.Default.isTraining = isTraining;
            Properties.Settings.Default.isMarried = isMarried;
            Properties.Settings.Default.salary = salary;
            Properties.Settings.Default.day = day;
            Properties.Settings.Default.month = month;
            Properties.Settings.Default.year = year;
            Properties.Settings.Default.Save();
        }

        public void ClearMethod()
        {
            mainWindow.timer.Stop();
            hungry = 100;
            mood = 100;
            money = 100;

            isPet = false;
            isTraining = false;
            isMarried = false;
            salary = 0;
            day = 1;
            month = 1;
            year = 2000;
            Properties.Settings.Default.hungry = _hungry;
            Properties.Settings.Default.money = _money;
            Properties.Settings.Default.mood = _mood;
            Properties.Settings.Default.isPet = isPet;
            Properties.Settings.Default.isTraining = isTraining;
            Properties.Settings.Default.isMarried = isMarried;
            Properties.Settings.Default.salary = salary;
            Properties.Settings.Default.day = day;
            Properties.Settings.Default.month = month;
            Properties.Settings.Default.year = year;
            Properties.Settings.Default.Save();
        }

        public int _hungry
        {
            get
            {
                return hungry;
            }
            set
            {
                if (hungry > 0 && value <= 0)
                    hungry = value;
                else if (value >= 0)
                    hungry = value;
                mainWindow.HungryLabel.Content = hungry;
                if(hungry <= 0)
                {
                    MessageBox.Show("You Died");
                    ClearMethod();
                    mainWindow.Close();
                }
            }
        }

        public int _mood
        {
            get
            {
                return mood;
            }
            set
            {
                if(mood > 0 && value <= 0)
                    mood = value;
                else if (value >= 0)
                    mood = value;
                mainWindow.MoodLabel.Content = mood;
                if (mood <= 0)
                {
                    MessageBox.Show("You Died");
                    ClearMethod();
                    mainWindow.Close();
                }
            }
        }

        public int _money
        {
            get
            {
                return money;
            }
            set
            {
                if (value >= 0) 
                    money = value;
                else if ((money > 0) && (value <= 0))
                    money = value;
                else if (value > money)
                    MessageBox.Show("Недостаточно денег");

                mainWindow.MoneyLabel.Content = money;
            }
        }

    }
}
