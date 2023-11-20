using Phone_App.Models;
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
    /// Interaction logic for NewContactView.xaml
    /// </summary>
    public partial class NewContactView : Window
    {
        public NewContactView(AppDBContext context)
        {
            InitializeComponent();;
            NewContactViewModel model = new NewContactViewModel(context);
            this.DataContext = model;
        }
    }
}
