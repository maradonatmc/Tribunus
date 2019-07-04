using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Tribunus.Models;
using Tribunus.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MembrosPage : ContentPage {

        List<string> membros = new List<string> {
                "Carlos", "Marcão", "Tobias", "Ganiza", "Minion", "Gabi", "TopGun",
                "Loyd", "Vânia", "Bigão", "Mau", "Mano", "Alê", "Carol", "Smoke",
                "Maradona", "Salvação", "Lokow", "Suspenso", "Sahara", "Kalzone",
                "Furão", "CloseUp", "Minion", "ZeroHum", "ZeroDois", "Mullets",
                "Pombo", "Rivotril", "Friaka", "Barbeiro", "Pira", "Peppo",
                "Proed", "Zé Bunitinho"

        };

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

            //BindingContext = new MembrosViewModel();

            membrosListView.ItemsSource = membros;
            membrosSearchBar.TextChanged += OnTextChanged;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e) {
            var texto = membrosSearchBar.Text;
            membrosListView.ItemsSource = membros.Where(
                  x => x.ToLower().Contains(texto.ToLower()));
        }
    }
}