using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamairnAppCenter.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            api.Source = "http://www.geenraltesting.somee.com/api/Report/GetReport?ReportName=UserDetails";
          //  google.Source = "https://www.google.com/";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string url = "http://www.geenraltesting.somee.com/api/Report/GetReport?ReportName=UserDetails";
                try
                {
                    await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
                }
                catch (Exception ex)
                {
                    // An unexpected error occured. No browser may be installed on the device.
                }
           
        }
    }
}