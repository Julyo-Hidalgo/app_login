using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace projeto_login
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new projeto_login.View.login();
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
