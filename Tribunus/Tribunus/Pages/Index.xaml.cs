using Tribunus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Index: ContentPage {
        private User user;

        public Index(User user) {
            InitializeComponent();

            switch (Device.RuntimePlatform) {
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;

                default:
                    Padding = new Thickness(10);
                    break;
            }

            this.user = user;
        }

        protected override void OnAppearing() {
            base.OnAppearing();

        }
    }
}