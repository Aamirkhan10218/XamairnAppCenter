using System;
using System.Net.Http;
using System.Threading.Tasks;
using XamairnAppCenter.Interfaces;
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
            //string url = "http://www.geenraltesting.somee.com/api/Report/GetReport?ReportName=UserDetails";
            string url = "http://media.wuerth.com/stmedia/shop/catalogpages/LANG_it/1637048.pdf";
            //try
            //{
            //    await Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred);
            //}
            //catch (Exception ex)
            //{
            //    // An unexpected error occured. No browser may be installed on the device.
            //}
            //WebView webView = new WebView();
            //var page = new ContentPage();
            //webView.Source = url;
            //page.Content = webView;
            //Navigation.PushModalAsync(page);

            var dependency = DependencyService.Get<ILocalFileProvider>();

            if (dependency == null)
            {
                DisplayAlert("Error loading PDF", "Computer says no", "OK");

                return;
            }

            var localPath = string.Empty;

            var fileName = "dbr";

            // Download PDF locally for viewing
            using (var httpClient = new HttpClient())
            {
                var pdfStream = Task.Run(() => httpClient.GetStreamAsync(url)).Result;

                localPath =
                    Task.Run(() => dependency.SaveFileToDisk(pdfStream, $"{fileName}.pdf")).Result;
            }


          //  Device.OpenUri(http://www.geenraltesting.somee.com/api/Report/GetReport?ReportName=UserDetails);

        }
    }
}