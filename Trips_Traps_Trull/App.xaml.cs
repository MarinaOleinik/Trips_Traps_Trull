using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trips_Traps_Trull
{
    public partial class App : Application
    {
        public bool first_player=false;
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
