using Phone_App.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Phone_App.ViewModels
{
    public class TicTacToeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public bool SwitchPlayer { get; set; }
        private bool isbuttonenabled;

        public bool IsButtonEnabled
        {
            get { return isbuttonenabled; }
            set { isbuttonenabled = value;
                OnPropertyChanged(nameof(IsButtonEnabled)); }
        }

        private char[] _board;
        public char[] Board
        {
            get { return _board; }
            set
            {
                _board = value;
                OnPropertyChanged(nameof(Board));
            }
        }

        public ICommand ButtonClickedCommand00 { get; set; }
        public ICommand ButtonClickedCommand01 { get; set; }
        public ICommand ButtonClickedCommand02 { get; set; }
        public ICommand ButtonClickedCommand03 { get; set; }
        public ICommand ButtonClickedCommand04 { get; set; }
        public ICommand ButtonClickedCommand05 { get; set; }
        public ICommand ButtonClickedCommand06 { get; set; }
        public ICommand ButtonClickedCommand07 { get; set; }
        public ICommand ButtonClickedCommand08 { get; set; }
        public ICommand ButtonClickedCommand09 { get; set; }
        public ICommand ButtonResetCommand { get; set; }

        public TicTacToeViewModel()
        {
            InitializeBoard();
            ButtonClickedCommand00 = new RelayCommand(ButtonClicked00, TryButtonClicked00);
            ButtonClickedCommand01 = new RelayCommand(ButtonClicked01, TryButtonClicked01);
            ButtonClickedCommand02 = new RelayCommand(ButtonClicked02, TryButtonClicked02);
            ButtonClickedCommand03 = new RelayCommand(ButtonClicked03, TryButtonClicked03);
            ButtonClickedCommand04 = new RelayCommand(ButtonClicked04, TryButtonClicked04);
            ButtonClickedCommand05 = new RelayCommand(ButtonClicked05, TryButtonClicked05);
            ButtonClickedCommand06 = new RelayCommand(ButtonClicked06, TryButtonClicked06);
            ButtonClickedCommand07 = new RelayCommand(ButtonClicked07, TryButtonClicked07);
            ButtonClickedCommand08 = new RelayCommand(ButtonClicked08, TryButtonClicked08);
            ButtonClickedCommand09 = new RelayCommand(ButtonClicked09, TryButtonClicked09);
            ButtonResetCommand = new RelayCommand(ResetCommand, TryResetCommand);
            SwitchPlayer = false;
            isbuttonenabled = true;
        }

        private void ResetCommand(object obj)
        {
            InitializeBoard();
            SwitchPlayer = false;
            isbuttonenabled = true;
        }

        private bool TryResetCommand(object obj) => true;

        private bool TryButtonClicked02(object obj) => true;
        private bool TryButtonClicked05(object obj) => true;
        private bool TryButtonClicked06(object obj) => true;
        private bool TryButtonClicked07(object obj) => true;
        private bool TryButtonClicked08(object obj) => true;
        private bool TryButtonClicked09(object obj) => true;

        private bool TryButtonClicked04(object obj) => true;

        private bool TryButtonClicked03(object obj) => true;
        private bool TryButtonClicked01(object obj) => true;

        private bool TryButtonClicked00(object obj) => true;

        private void ButtonClicked09(object obj)
        {
            SwitchPlayers(9);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked08(object obj)
        {
            SwitchPlayers(8);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked07(object obj)
        {
            SwitchPlayers(7);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked06(object obj)
        {
            SwitchPlayers(6);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked05(object obj)
        {
            SwitchPlayers(5);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked04(object obj)
        {
            SwitchPlayers(4);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked03(object obj)
        {
            SwitchPlayers(3);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked02(object obj)
        {
            SwitchPlayers(2);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked01(object obj)
        {
            SwitchPlayers(1);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }

        private void ButtonClicked00(object obj)
        {
            SwitchPlayers(0);
            OnPropertyChanged(nameof(Board));
            CheckGameWinner('X');
            CheckGameWinner('O');
        }
        private void InitializeBoard()
        {
            Board = new char[9];
            for (int i = 0; i < Board.Length; i++)
            {
                Board[i] = ' ';
            }
        }

        private bool CheckGameWinner(char player)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (Board[i * 3] == player && Board[i * 3 + 1] == player && Board[i * 3 + 2] == player)
                {
                    DisableButtons();
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (Board[i] == player && Board[i + 3] == player && Board[i + 6] == player)
                {
                    DisableButtons();
                    return true;
                }
            }

            // Check diagonals
            if (Board[0] == player && Board[4] == player && Board[8] == player)
            {
                DisableButtons();
                return true;
            }

            if (Board[2] == player && Board[4] == player && Board[6] == player)
            {
                DisableButtons();
                return true;
            }

            return false;
        }

        private void DisableButtons()
        {
            IsButtonEnabled = false;
            OnPropertyChanged(nameof(IsButtonEnabled));
        }

        private void SwitchPlayers(int rows)
        {
            if(SwitchPlayer)
            {
                SwitchPlayer = false;
                Board[rows] = 'X';
            }
            else
            {
                SwitchPlayer = true;
                Board[rows] = 'O';
            }
        }
    }
}
