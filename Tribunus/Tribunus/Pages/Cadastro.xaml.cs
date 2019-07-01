using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cadastro: ContentPage {
        public Cadastro() {
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

        private void DatNasc_DataSelected(object sender, DateChangedEventArgs e) {
            DatNascDatePicker.TextColor = Color.DarkTurquoise;
        }

        private void DatIngresso_DataSelected(object sender, DateChangedEventArgs e) {
            DatIngressoDatePicker.TextColor = Color.DarkTurquoise;
        }
    }
}