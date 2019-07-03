using System.Collections.ObjectModel;
using Tribunus.Models;
using Tribunus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MembrosPage : ContentPage {
        public MembrosPage() {
            InitializeComponent();

            switch (Device.RuntimePlatform) {
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;

                default:
                    Padding = new Thickness(10);
                    break;
            }

            BindingContext = new MembrosViewModel();
        }
    }
}