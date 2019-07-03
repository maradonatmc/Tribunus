using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage: MasterDetailPage {
        public MenuPage() {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

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

        private void GoCadastro(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new CadastroMembrosPage());
            IsPresented = false;
        }
        private void GoReunioes(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new ReunioesPage());
            IsPresented = false;
        }
        private void GoMural(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new MuralPage());
            IsPresented = false;
        }

        private void GoMembros(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new MembrosPage());
            IsPresented = false;
        }

        private void GoFinanceiro(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new FinanceiroPage());
            IsPresented = false;
        }
    }
}