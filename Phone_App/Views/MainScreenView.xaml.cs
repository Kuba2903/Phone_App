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
    /// Interaction logic for MainScreenView.xaml
    /// </summary>
    public partial class MainScreenView : Window
    {
        public MainScreenView()
        {
            InitializeComponent();
            MainScreenViewModel model = new MainScreenViewModel();
            this.DataContext = model;
        }

        private void rbYellow_White_Checked(object sender, RoutedEventArgs e)
        {
            if(rbYellow_White.IsChecked == true)
            {
                var gradientBrush = new LinearGradientBrush();
                gradientBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 0));
                gradientBrush.GradientStops.Add(new GradientStop(Colors.Beige, 1));
                content.Background = gradientBrush;
            }
        }

        private void rbBlue_Red_Checked(object sender, RoutedEventArgs e)
        {
            if(rbBlue_Red.IsChecked == true)
            {
                var gradientBrush = new LinearGradientBrush();
                gradientBrush.GradientStops.Add(new GradientStop(Colors.Blue, 0));
                gradientBrush.GradientStops.Add(new GradientStop(Colors.Red, 1));
                content.Background = gradientBrush;
            }
        }

        private void rbViolet_Checked(object sender, RoutedEventArgs e)
        {
            if(rbViolet.IsChecked == true)
            {
                content.Background = Brushes.Violet;
            }
            
        }
    }
}
