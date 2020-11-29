using XamairnAppCenter.Services;
using Xamarin.Forms;

namespace XamairnAppCenter
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
              MainPage = new AppShell();
           // MainPage = new PDFPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
