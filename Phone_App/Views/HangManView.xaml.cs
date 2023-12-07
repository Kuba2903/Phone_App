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

namespace Phone_App.Views
{
    /// <summary>
    /// Interaction logic for HangManView.xaml
    /// </summary>
    public partial class HangManView : Window
    {
        public HangManView()
        {
            InitializeComponent();
            RandomWord();
        }

        public string letter { get; set; }

        string[] words = { "rhino", "mouse", "horse", "elephant", "giraffe" };

        public string Word { get; set; }

        char[] empty;

        public void RandomWord()
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 5);
            Word = words[random];

            var parts = Word.ToCharArray();

            char[] empty = new char[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {

                empty[i] = '-';
            }




            int position = rnd.Next(0, Word.Length);
            int position2 = rnd.Next(0, Word.Length);

            if (position2 == position)
                position2++;

            for (int i = 0; i < Word.Length; i++)
            {
                if (i == position)
                {
                    empty[i] = Word[i];
                }
                if (i == position2)
                {
                    empty[i] = Word[i];
                }
            }

            this.empty = empty;
            foreach (char c in empty)
            {
                this.word.Text += c;
            }


        }
        private int pic_num = 0;



        private void btnClick(object sender, RoutedEventArgs e)
        {
            bool is_all_words_guessed = false;


            Button button = (Button)sender;
            letter = button.Content.ToString();
            letter = letter.ToLower();


            bool isGuessed = false;


            char guess = letter[0];


            for (int i = 0; i < Word.Length; i++)
            {
                if (guess == Word[i])
                {
                    empty[i] = Word[i];
                    this.word.Text = new string(empty);
                    isGuessed = true;
                    button.IsEnabled = false;
                }

            }

            if (!isGuessed)
            {
                //button.IsEnabled = false;
                pic_num++;
                pic.Visibility = Visibility.Visible;
                pic.Source = new BitmapImage(new Uri($"C:/Users/bigie/source/repos/HangMan/grafika/{pic_num}.jpg"));
            }

            if (pic_num == 4)
            {
                this.word.Text = "Game end!";
                DisableAllButtons();
                again.Visibility = Visibility.Visible;
            }

            if (!empty.Contains('-'))
                is_all_words_guessed = true;

            if (is_all_words_guessed)
            {
                DisableAllButtons();
                again.Visibility = Visibility.Visible;
            }

        }

        private void DisableAllButtons()
        {
            foreach (UIElement element in container.Children)
            {
                if (element is Button button)
                {
                    button.IsEnabled = false;
                }
            }
            again.IsEnabled = true;
        }

        private void EnableAllButtons()
        {
            foreach (UIElement element in container.Children)
            {
                if (element is Button button)
                {
                    button.IsEnabled = true;
                }
            }
        }

        private void again_Click(object sender, RoutedEventArgs e)
        {
            word.Text = string.Empty;
            pic_num = 0;
            RandomWord();
            EnableAllButtons();
            pic.Visibility = Visibility.Hidden;
            again.Visibility = Visibility.Collapsed;
        }
    }
}
