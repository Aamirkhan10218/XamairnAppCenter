using System;
using System.ComponentModel;
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
    }
}