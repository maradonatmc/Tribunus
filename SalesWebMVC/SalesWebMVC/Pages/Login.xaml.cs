using Newtonsoft.Json;
using SalesWebMVC.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

            this.LogarAsync();
        }

        private async void LogarAsync() {
            waitActivityIndicator.IsRunning = true;

            var loginRequest = new LoginRequest { User = emailEntry.Text, Password = passwordEntry.Text };

            /**/
            var jsonRequest = JsonConvert.SerializeObject(loginRequest);
            var httpContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            var resp = string.Empty;

            try {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://tribunus.somee.com");
                var url = "/API/Users/Login";
                //var result = await client.PostAsync(url, httpContent);

                //if (!result.IsSuccessStatusCode) {
                //    await DisplayAlert("Erro", "Usuário ou Senha incorretos", "Aceitar");
                //    waitActivityIndicator.IsRunning = false;
                //    return;
                //}

                //resp = await result.Content.ReadAsStringAsync();
            }
            catch (Exception ex) {
                await DisplayAlert("Erro", ex.Message, "Aceitar");
                waitActivityIndicator.IsRunning = false;
                return;
            }

            //var user = JsonConvert.DeserializeObject<User>(resp);
            //waitActivityIndicator.IsRunning = false;
            //await DisplayAlert("Bem Vindo", user.FirstName, "Aceitar");
            /**/

            /*Manter enquanto não implementado API*/
            waitActivityIndicator.IsRunning = false;
            await DisplayAlert("Bem Vindo", "Renato Ramos", "Aceitar");
        }
    }
}