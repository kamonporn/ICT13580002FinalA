using Xamarin.Forms;

namespace ICT13580002FinalA
{
    public partial class App : Application
    {
        public static object DbHelpers { get; internal set; }

        public App()
        {
            InitializeComponent();

            MainPage = new ICT13580002FinalAPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
