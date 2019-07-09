using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using Tribunus.ApiRequest;
using Tribunus.Models;
using Tribunus.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage: ContentPage {
        private FingerprintValidation fingerPrint = new FingerprintValidation();
        public LoginPage() {
            InitializeComponent();

            switch (Device.RuntimePlatform) {
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;

                default:
                    Padding = new Thickness(10);
                    break;
            }

            if (!useFingerprintSwitch.IsToggled) {
                lblAliasNotify.Text = "Digite seu apelido e sua senha para acesso";
                passwordEntry.IsVisible = true;
            }
            else {
                lblAliasNotify.Text = "Digite seu apelido para acesso";
                passwordEntry.IsVisible = false;
            }

            loginButton.Clicked += LoginButton_Clicked;
            registerButton.Clicked += RegisterButton_Clicked;
            useFingerprintSwitch.Toggled += HandleSwitchToggledByUser;
        }

        private void HandleSwitchToggledByUser(object sender, ToggledEventArgs e) {
            if (!useFingerprintSwitch.IsToggled) {
                lblAliasNotify.Text = "Digite seu apelido e sua senha para acesso";
                passwordEntry.IsVisible = true;
            }
            else {
                lblAliasNotify.Text = "Digite seu apelido para acesso";
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
                if (string.IsNullOrEmpty(aliasEntry.Text)) {
                    await DisplayAlert("Erro", "Digite seu apelido", "Ok");

                    aliasEntry.Focus();
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

        private async void RegisterButton_Clicked(object sender, EventArgs e) {
            waitActivityIndicator.IsRunning = true;

            waitActivityIndicator.IsRunning = false;

            await Navigation.PushAsync(new CadastroMembrosPage());
        }

        private async void LogarAsync() {
            waitActivityIndicator.IsRunning = true;
            var resp = string.Empty;
            var url = string.Empty;

            try {
                var client = new HttpClient();
                client.BaseAddress = new Uri("http://128.0.0.36");

                if (useFingerprintSwitch.IsToggled) {
                    url = "/TribunusAPI/WebAPI/Tribunus/ValidarMembro/" + aliasEntry.Text + "/0";
                }
                else {
                    url = "/TribunusAPI/WebAPI/Tribunus/ValidarMembro/" + aliasEntry.Text + "/" + passwordEntry.Text;
                }
                
                var result = await client.GetAsync(url);

                if (!result.IsSuccessStatusCode) {
                    await DisplayAlert("Erro", "Membro ou Senha incorretos", "Ok");
                    waitActivityIndicator.IsRunning = false;
                    return;
                }

                resp = await result.Content.ReadAsStringAsync();
                var membro = JsonConvert.DeserializeObject<Membro>(resp);
            }
            catch (Exception ex) {
                await DisplayAlert("Erro", ex.Message, "Ok");
                waitActivityIndicator.IsRunning = false;
                return;
            }

            waitActivityIndicator.IsRunning = false;

            await Navigation.PushAsync(new MenuPage());
        }
    }
}