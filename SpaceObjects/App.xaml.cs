using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SpaceObjects;

namespace SpaceObjects
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListViewPageSpaceObjects());
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
