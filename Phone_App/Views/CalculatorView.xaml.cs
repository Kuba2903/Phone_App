using Phone_App.ViewModels;
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
    /// Interaction logic for CalculatorView.xaml
    /// </summary>
    public partial class CalculatorView : Window
    {
        public CalculatorView()
        {
            InitializeComponent();
        }

        public int I { get; set; } = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Content.ToString();
            numbers.Text += number;
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            if (result.Text.Length > 0)
                numbers.Text = result.Text;
            else
            {
                double temp = double.Parse(numbers.Text);
                result.Text += temp;
            }
            numbers.Text = string.Empty;

            Button button = (Button)sender;
            switch (button.Content)
            {
                case "+":
                    I = 1;
                    sign.Text = "+";
                    break;
                case "-":
                    I = 2;
                    sign.Text = "-";
                    break;
                case "*":
                    I = 3;
                    sign.Text = "*";
                    break;
                case "/":
                    I = 4;
                    sign.Text = "/";
                    break;
            }

        }

        private void Button_ClickEquals(object sender, RoutedEventArgs e)
        {
            try
            {

                double equals = 0;
                switch (I)
                {
                    case 1:
                        equals = double.Parse(result.Text) + double.Parse(numbers.Text);
                        break;
                    case 2:
                        equals = double.Parse(result.Text) - double.Parse(numbers.Text);
                        break;
                    case 3:
                        equals = double.Parse(result.Text) * double.Parse(numbers.Text);
                        break;
                    case 4:
                        equals = double.Parse(result.Text) / double.Parse(numbers.Text);
                        break;
                }

                result.Text = equals.ToString();

                numbers.Text = string.Empty;
                sign.Text = string.Empty;
            }
            catch (Exception ex)
            {

            }
        }

        private void Button_ClickReset(object sender, RoutedEventArgs e)
        {
            I = 0;
            numbers.Text = string.Empty;
            result.Text = string.Empty;
            sign.Text = string.Empty;
        }

        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            if (numbers.Text.Length > 0)
                numbers.Text = numbers.Text.Remove(numbers.Text.Length - 1);
        }

        private void Button_ClickSign(object sender, RoutedEventArgs e)
        {
            try
            {
                double num = double.Parse(numbers.Text);
                num = num * -1;
                numbers.Text = num.ToString();
            }
            catch (Exception ex) { }
        }

        private void Button_Clickfloat(object sender, RoutedEventArgs e)
        {
            numbers.Text += ",";
        }
    }
}
