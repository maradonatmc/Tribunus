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
        private FingerprintValidation fingerPrint = new FingerprintValidation();
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

            if (!useFingerprintSwitch.IsToggled) {
                lblAliasNotify.IsVisible = false;
                aliasEntry.IsVisible = false;
                lblEmailEPasswordNotify.IsVisible = true;
                emailEntry.IsVisible = true;
                passwordEntry.IsVisible = true;
            }
            else {
                lblAliasNotify.IsVisible = true;
                aliasEntry.IsVisible = true;
                lblEmailEPasswordNotify.IsVisible = false;
                emailEntry.IsVisible = false;
                passwordEntry.IsVisible = false;
            }

            loginButton.Clicked += LoginButton_Clicked;
            useFingerprintSwitch.Toggled += HandleSwitchToggledByUser;
        }

        private void HandleSwitchToggledByUser(object sender, ToggledEventArgs e) {
            if (!useFingerprintSwitch.IsToggled) {
                lblAliasNotify.IsVisible = false;
                aliasEntry.IsVisible = false;
                lblEmailEPasswordNotify.IsVisible = true;
                emailEntry.IsVisible = true;
                passwordEntry.IsVisible = true;
            }
            else {
                lblAliasNotify.IsVisible = true;
                aliasEntry.IsVisible = true;
                lblEmailEPasswordNotify.IsVisible = false;
                emailEntry.IsVisible = false;
                passwordEntry.IsVisible = false;
            }
        }

        private async void LoginButton_Clicked(object sender, EventArgs e) {
            var haveFingerprint = await fingerPrint.HaveFingerprint();
           
            if (useFingerprintSwitch.IsToggled) {
                if (haveFingerprint) {
                    if (string.IsNullOrEmpty(aliasEntry.Text)) {
                        await DisplayAlert("Erro", "Digite seu apelido", "Ok");

                        aliasEntry.Focus();
                        return;
                    }

                    await fingerPrint.AuthenticationAsync("Toque no sensor", swAutoCancel.IsToggled);

                    if (fingerPrint.fingerPrintValidate) {
                        this.LogarAsync();
                    }
                    else {
                        await DisplayAlert("Falha de Autenticação", "Tribunus não detectado", "Ok");
                    }
                }
                else {
                    await DisplayAlert("Erro", "Função de Autenticação por impressão digitão não disponível neste celular", "Ok");
                }
            }
            else {
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

            //var loginRequest = new LoginRequest { User = emailEntry.Text, Password = passwordEntry.Text };

            /**/
            //var jsonRequest = JsonConvert.SerializeObject(loginRequest);
            //var httpContent = new StringContent(jsonRequest, Encoding.UTF8, "application/json");
            //var resp = string.Empty;

            //try {
                //var client = new HttpClient();
                //client.BaseAddress = new Uri("http://tribunus.somee.com");
                //var url = "/API/Users/Login";
                //var result = await client.PostAsync(url, httpContent);

                //if (!result.IsSuccessStatusCode) {
                //    await DisplayAlert("Erro", "Usuário ou Senha incorretos", "Aceitar");
                //    waitActivityIndicator.IsRunning = false;
                //    return;
                //}

                //resp = await result.Content.ReadAsStringAsync();
            //}
            //catch (Exception ex) {
            //    await DisplayAlert("Erro", ex.Message, "Ok");
            //    waitActivityIndicator.IsRunning = false;
            //    return;
            //}

            /*Manter enquanto não implementado API*/
            //var user = JsonConvert.DeserializeObject<User>(resp);
            waitActivityIndicator.IsRunning = false;

            await Navigation.PushAsync(new Pages.Menu());
        }
    }
}