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
    }
}
