using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tribunus.Pages;
using Tribunus.Classes;

namespace Tribunus {
    public partial class App: Application {
        public static string EVENT_LAUNCH_LOGIN_PAGE = "EVENT_LAUNCH_LOGIN_PAGE";
        public static string EVENT_LAUNCH_MAIN_PAGE = "EVENT_LAUNCH_MAIN_PAGE";
        public App() {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());

            MessagingCenter.Subscribe<object>(this, EVENT_LAUNCH_LOGIN_PAGE, SetLoginAsRootPage);
            MessagingCenter.Subscribe<object>(this, EVENT_LAUNCH_MAIN_PAGE, SetMainAsRootPage);
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

        private void SetLoginAsRootPage(object sender) {
            MainPage = new Login();
        }

        private void SetMainAsRootPage(object sender) {
            MainPage = new NavigationPage(new Main());
        }
    }
}
