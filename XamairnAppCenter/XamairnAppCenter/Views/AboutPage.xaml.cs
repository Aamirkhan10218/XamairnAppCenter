using System;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace XamairnAppCenter.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            // api.Source = "http://www.geenraltesting.somee.com/api/Report/GetReport?ReportName=UserDetails";
           // api.Source = "https://www.google.com/";
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            string url = "http://www.geenraltesting.somee.com/api/Report/GetReport?ReportName=UserDetails";
            //try
            //{
            //    await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
            //}
            //catch (Exception ex)
            //{
            //    // An unexpected error occured. No browser may be installed on the device.
            //}
            WebView webView = new WebView();
            var page = new ContentPage();
            webView.Source = url;
            page.Content = webView;
            Navigation.PushModalAsync(page);

        }
    }
}