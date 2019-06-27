using Newtonsoft.Json;
using Tribunus.Classes;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Fingerprint;
using System.Threading;
using Plugin.Fingerprint.Abstractions;

namespace Tribunus.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login: ContentPage {

        private bool UseFingerprintValidation = false;
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
            UseFingerprintValidation = false;
            var haveFingerprint = await CrossFingerprint.Current.IsAvailableAsync(true);

            if (haveFingerprint) {
                await AuthenticationAsync("Biometria");
                this.LogarAsync();
            }

            if (!UseFingerprintValidation) {
                if (string.IsNullOrEmpty(emailEntry.Text)) {
                    await DisplayAlert("Erro", "Digite seu e-mail", "Ok");

                    emailEntry.Focus();
                    return;
                }

                if (!Utilities.IsValidEmail(emailEntry.Text)) {
                    await DisplayAlert("Erro", "Digite um e-mail válido", "Ok");

                    emailEntry.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(passwordEntry.Text)) {
                    await DisplayAlert("Erro", "Digite sua senha", "Ok");

                    passwordEntry.Focus();
                    return;
                }

                this.LogarAsync();
            }            
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
                await DisplayAlert("Erro", ex.Message, "Ok");
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

        private CancellationTokenSource _cancel;
        private async Task AuthenticationAsync(string reason, string cancel = null, string fallback = null, string tooFast = null) {
            _cancel = swAutoCancel.IsToggled ? new CancellationTokenSource(TimeSpan.FromSeconds(10)) : new CancellationTokenSource();
            var dialogConfig = new AuthenticationRequestConfiguration(reason) {
                CancelTitle = cancel,
                FallbackTitle = fallback,
                UseDialog = true
            };
            var result = await Plugin.Fingerprint.CrossFingerprint.Current.AuthenticateAsync(dialogConfig, _cancel.Token);
            await SetResultAsync(result);
        }

        private async Task SetResultAsync(FingerprintAuthenticationResult result) {
            if (result.Authenticated) {
                await DisplayAlert("Autenticação", "Tribunus detectado", "Ok");
            }
            else {
                await DisplayAlert("Falha Autenticação", "Tribunus não detectado", "Ok");
            }

            UseFingerprintValidation = true;
        }
    }
}