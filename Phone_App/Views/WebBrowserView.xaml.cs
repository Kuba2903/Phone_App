using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for WebBrowserView.xaml
    /// </summary>
    public partial class WebBrowserView : Window
    {
        public WebBrowserView()
        {
            InitializeComponent();
        }

        private void WebBrowser_Navigating(object sender, System.Windows.Navigation.NavigatingCancelEventArgs e)
        {
            UrlTxt.Text = e.Uri.OriginalString;
        }

        private void WebBrowser_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            HideScriptErrors(wb, true);
        }

        private void Button_Next(object sender, RoutedEventArgs e)
        {
            if(wb.CanGoForward)
                wb.GoForward();
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            if(wb.CanGoBack)
                wb.GoBack();
        }

        private void Button_Go(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri(UrlTxt.Text);

            wb.Navigate(uri);
        }

        private void Button_Refresh(object sender, RoutedEventArgs e)
        {
            try
            {
                wb.Refresh();
            }catch (Exception ex)
            {

            }
        }

        public void HideScriptErrors(WebBrowser web, bool hide)
        {
            dynamic activeX = this.wb.GetType().InvokeMember("ActiveXInstance", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, this.wb, new object[] { });
            activeX.Silent = true;
        }
    }
}
