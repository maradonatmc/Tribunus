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
            Detail.Navigation.PushAsync(new Cadastro());
            IsPresented = false;
        }
        private void GoReunioes(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new Reunioes());
            IsPresented = false;
        }
        private void GoMural(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new Mural());
            IsPresented = false;
        }

        private void GoMembros(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new Membros());
            IsPresented = false;
        }

        private void GoFinanceiro(object sender, System.EventArgs e) {
            Detail.Navigation.PushAsync(new Financeiro());
            IsPresented = false;
        }
    }
}