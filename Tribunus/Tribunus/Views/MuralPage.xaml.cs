using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MuralPage: ContentPage {
        public MuralPage() {
            InitializeComponent();

            switch (Device.RuntimePlatform) {
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;

                default:
                    Padding = new Thickness(10);
                    break;
            }
        }
    }
}