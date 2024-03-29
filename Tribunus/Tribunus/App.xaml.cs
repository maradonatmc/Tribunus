﻿using Xamarin.Forms;
using Tribunus.Views;

namespace Tribunus {
    public partial class App: Application {
        public App() {
            InitializeComponent();

            XF.Material.Forms.Material.Init(this);

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
