using Newtonsoft.Json;
using Tribunus.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Pages {
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

            if (!Utilities.IsValidEmail(emailEntry.Text)) {
                await DisplayAlert("Erro", "Digite um e-mail válido", "Aceitar");

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

            /*Manter enquanto não implementado API*/
            //var user = JsonConvert.DeserializeObject<User>(resp);
            User user = new User();

            user.UserId = 1;
            user.UserName = "renatoramos89@gmail.com";
            user.FirstName = "Renato";
            user.LastName = "Ramos";
            user.Photo = "";
            user.Password = passwordEntry.Text;
            waitActivityIndicator.IsRunning = false;
            await Navigation.PushAsync(new Index(user));
        } 
    }
}