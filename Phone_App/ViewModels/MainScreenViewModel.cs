using Phone_App.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Phone_App.Models;
using System.ComponentModel;
using System.Windows.Threading;

namespace Phone_App.ViewModels
{
    public class MainScreenViewModel : MainScreenModel
    {
        public MainScreenViewModel()
        {
            Date = DateTime.Now.Date;
            UpdateTime();
            StartTimer();
        }

        private void UpdateTime()
        {
            Time = $"{DateTime.Now.Hour:D2}:{DateTime.Now.Minute:D2}";
        }

        private void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }
    }
}
