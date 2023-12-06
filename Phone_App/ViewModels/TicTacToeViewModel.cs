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
        public bool IsButtonEnabled { get; set; }
        private char character;

        public char Character
        {
            get { return character; }
            set { character = value; 
                    OnPropertyChanged(nameof(Character));}
        }

        public ICommand ButtonClickedCommand { get; set; }

        public TicTacToeViewModel()
        {
            ButtonClickedCommand = new RelayCommand(ButtonClicked, TryButtonClicked);
            SwitchPlayer = false;
        }

        private bool TryButtonClicked(object obj) => true;

        private void ButtonClicked(object obj)
        {
            SwitchPlayers();
        }

        private void SwitchPlayers()
        {
            if(SwitchPlayer)
            {
                SwitchPlayer = false;
                Character = 'X';
            }
            else
            {
                SwitchPlayer = true;
                Character = 'O';
            }
        }
    }
}
