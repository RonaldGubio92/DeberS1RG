using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeberS1RG
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new Login();

            MainPage = new NavigationPage(new Login());
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
