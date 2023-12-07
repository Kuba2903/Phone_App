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
using Phone_App.Views;

namespace Phone_App.ViewModels
{
    public class MainScreenViewModel : MainScreenModel
    {

        public ICommand OpenContactsCommand { get; set; }
        public ICommand OpenCalculatorCommand { get; set; }
        public ICommand OpenAudioPlayerCommand { get; set; }
        public ICommand OpenTicTacToeCommand { get; set; }
        public ICommand OpenWebBrowserCommand { get; set; }
        public ICommand OpenHangManCommand { get; set; }
        public MainScreenViewModel()
        {
            Date = DateTime.Now.Date;
            UpdateTime();
            StartTimer();
            OpenContactsCommand = new RelayCommand(OpenContactsBook, CanOpenContactsBook);
            OpenCalculatorCommand = new RelayCommand(OpenCalculator, CanOpenCalculator);
            OpenAudioPlayerCommand = new RelayCommand(OpenAudioPlayer, CanOpenAudioPlayer);
            OpenTicTacToeCommand = new RelayCommand(OpenTicTacToe, CanOpenTicTacToe);
            OpenWebBrowserCommand = new RelayCommand(OpenWebBrowser, CanOpenWebBrowser);
            OpenHangManCommand = new RelayCommand(OpenHangman, CanOpenHangMan);
        }


        private bool CanOpenHangMan(object obj) => true;

        private bool CanOpenWebBrowser(object obj) => true;

        private bool CanOpenTicTacToe(object obj) => true;

        private bool CanOpenAudioPlayer(object obj) => true;

        private bool CanOpenCalculator(object obj) => true;

        private bool CanOpenContactsBook(object obj) => true;

        private void OpenHangman(object obj)
        {
            HangManView view = new HangManView();
            view.ShowDialog();
        }

        private void OpenWebBrowser(object obj)
        {
            WebBrowserView view = new WebBrowserView();
            view.ShowDialog();
        }

        private void OpenTicTacToe(object obj)
        {
            TicTacToeView view = new TicTacToeView();
            view.ShowDialog();
        }
        private void OpenAudioPlayer(object obj)
        {
            AudioPlayerView view = new AudioPlayerView();
            view.ShowDialog();
        }
        private void OpenCalculator(object obj)
        {
            CalculatorView view = new CalculatorView();
            view.ShowDialog();
        }

        private void OpenContactsBook(object obj)
        {
            ContactsBookView view = new ContactsBookView();
            view.ShowDialog();
        }

        private void UpdateTime() => Time = $"{DateTime.Now.Hour:D2}:{DateTime.Now.Minute:D2}";
        

        private void StartTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) => UpdateTime();
    }
}
