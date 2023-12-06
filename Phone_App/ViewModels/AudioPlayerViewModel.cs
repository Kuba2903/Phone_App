using Microsoft.Win32;
using Phone_App.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Phone_App.Views;
using System.ComponentModel;

namespace Phone_App.ViewModels
{
    public class AudioPlayerViewModel : INotifyPropertyChanged
    {
        private MediaPlayer player = new MediaPlayer();
        private DispatcherTimer timer;
        private bool IsSliderDragged = false;
        public string Song { get; set; }
        public string Time { get; set; }

        private bool isPlayEnabled;
        public bool IsPlayEnabled
        {
            get { return isPlayEnabled; }
            set
            {
                if (isPlayEnabled != value)
                {
                    isPlayEnabled = value;
                    OnPropertyChanged(nameof(IsPlayEnabled));
                }
            }
        }

        private bool isPauseEnabled;
        public bool IsPauseEnabled
        {
            get { return isPauseEnabled; }
            set
            {
                if (isPauseEnabled != value)
                {
                    isPauseEnabled = value;
                    OnPropertyChanged(nameof(IsPauseEnabled));
                }
            }
        }

        private bool isStopEnabled;


        public bool IsStopEnabled
        {
            get { return isStopEnabled; }
            set
            {
                if (isStopEnabled != value)
                {
                    isStopEnabled = value;
                    OnPropertyChanged(nameof(IsStopEnabled));
                }
            }
        }

        public int PBMaximum { get; set; }
        public double SLMaximum { get; set; }
        private double pbValue;
        public double PBValue
        {
            get { return pbValue; }
            set
            {
                if (pbValue != value)
                {
                    pbValue = value;
                    OnPropertyChanged(nameof(PBValue));
                }
            }
        }

        private double slValue;
        public double SLValue
        {
            get { return slValue; }
            set
            {
                if (slValue != value)
                {
                    slValue = value;
                    OnPropertyChanged(nameof(SLValue));
                }
            }
        }
        public ICommand PickASongCommand { get; set; }
        public ICommand PlayMusicCommand { get; set; }
        public ICommand StopMusicCommand { get; set; }
        public ICommand PauseMusicCommand { get; set; }
        public ICommand SliderDragStartedCommand { get; set; }
        public ICommand SliderDragCompletedCommand { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public AudioPlayerViewModel()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Tick += TimerTick;
           

            PickASongCommand = new RelayCommand(PickASong,TryPickASong);
            PlayMusicCommand = new RelayCommand(PlayMusic, TryPlayMusic);
            StopMusicCommand = new RelayCommand(StopMusic, TryStopMusic);
            PauseMusicCommand = new RelayCommand(PauseMusic, TryPauseMusic);
            SliderDragStartedCommand = new RelayCommand(SliderDragStarted, TrySliderDragStarted);
            SliderDragCompletedCommand = new RelayCommand(SliderDragCompleted, TrySliderDragCompleted);
        }

        private bool TrySliderDragCompleted(object obj) => true;

        private bool TrySliderDragStarted(object obj) => true;
        private bool TryPauseMusic(object obj) => true;

        private bool TryStopMusic(object obj) => true;

        private bool TryPlayMusic(object obj) => true;

        private bool TryPickASong(object obj) => true;

        private void SliderDragStarted(object obj)
        {
            IsSliderDragged = true;
            OnPropertyChanged(nameof(SLValue));
        }

        private void SliderDragCompleted(object obj)
        {
            IsSliderDragged = false;
            player.Position = TimeSpan.FromMilliseconds(SLValue);
            OnPropertyChanged(nameof(SLValue));
        }
        private void PickASong(object obj)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                player.Open(new Uri(dialog.FileName));
                isPauseEnabled = true;
                isStopEnabled = true;
                isPlayEnabled = true;
                Song = dialog.FileName;
                timer.Start();

                OnPropertyChanged(nameof(IsPauseEnabled));
                OnPropertyChanged(nameof(IsStopEnabled));
                OnPropertyChanged(nameof(IsPlayEnabled));
                OnPropertyChanged(nameof(Song));
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if(player.Source != null && player.NaturalDuration.HasTimeSpan && !IsSliderDragged)
            {
                Time = TimeSpan.FromSeconds(player.Position.TotalSeconds).ToString(@"mm\:ss");
                TimeSpan ts = player.NaturalDuration.TimeSpan;
                PBMaximum = 100;
                pbValue = ((double)player.Position.TotalMilliseconds / ts.TotalMilliseconds) * 100;
                SLMaximum = player.NaturalDuration.TimeSpan.TotalMilliseconds;
                slValue = player.Position.TotalMilliseconds;

                OnPropertyChanged(nameof(SLMaximum));
                OnPropertyChanged(nameof(SLValue));
                OnPropertyChanged(nameof(PBValue));
            }
        }


        private void PlayMusic(object obj) => player.Play();
        private void PauseMusic(object obj) => player.Pause();
        private void StopMusic(object obj) => player.Stop();
    }
}
