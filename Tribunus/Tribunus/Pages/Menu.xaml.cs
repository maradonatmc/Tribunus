using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu: MasterDetailPage {
        public Menu() {
            InitializeComponent();

            switch (Device.RuntimePlatform) {
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;

                default:
                    Padding = new Thickness(10);
                    break;
            }

            Detail = new NavigationPage(new MenuDetail());
        }

        private void GoPage1(object sender, System.EventArgs e) {
            //Detail.Navigation.PushAsync(new Page1());
            IsPresented = false;
        }
        private void GoPage2(object sender, System.EventArgs e) {
            //Detail.Navigation.PushAsync(new Page2());
            IsPresented = false;
        }
        private void GoPage3(object sender, System.EventArgs e) {
            //Detail.Navigation.PushAsync(new Page3());
            IsPresented = false;
        }
    }
}