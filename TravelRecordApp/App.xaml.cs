using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            DatabaseLocation = databaseLocation;
        }

        protected override void OnStart()
        {
            //handle when your app starts
        }

        protected override void OnSleep()
        {
            //handle when your app sleeps
        }

        protected override void OnResume()
        {
            //handle when your app resumes
        }
    }
}
