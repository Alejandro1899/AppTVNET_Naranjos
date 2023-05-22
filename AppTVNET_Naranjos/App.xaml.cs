using AppTVNET_Naranjos.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTVNET_Naranjos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage =new NavigationPage (new VTabbedNavegation());

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
