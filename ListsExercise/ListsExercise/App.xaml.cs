using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListsExercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Airbnb();
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
