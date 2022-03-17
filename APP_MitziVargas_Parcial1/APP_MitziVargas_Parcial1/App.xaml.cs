using APP_MitziVargas_Parcial1.Services;
using APP_MitziVargas_Parcial1.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APP_MitziVargas_Parcial1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();



            DependencyService.Register<MockDataStore>();



            MainPage = new NavigationPage(new LoginPage());

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
