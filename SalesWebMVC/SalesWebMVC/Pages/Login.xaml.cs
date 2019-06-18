using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SalesWebMVC.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login: ContentPage {
        public Login() {
            InitializeComponent();

            switch(Device.RuntimePlatform) {
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;

                default:
                    Padding = new Thickness(10);
                    break;
            }

            loginButton.Clicked += LoginButton_Clicked;
        }

        private async void LoginButton_Clicked(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(emailEntry.Text)) {
                await DisplayAlert("Erro", "Digite seu e-mail", "Aceitar");

                emailEntry.Focus();
                return;
            }

            if (string.IsNullOrEmpty(passwordEntry.Text)) {
                await DisplayAlert("Erro", "Digite sua senha", "Aceitar");

                passwordEntry.Focus();
                return;
            }

            //this.Logar();
        }

        //private void Logar() {
            
        //}
    }
}