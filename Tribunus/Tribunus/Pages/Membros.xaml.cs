using System.Collections.ObjectModel;
using Tribunus.Classes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Pages {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Membros : ContentPage {
        private ObservableCollection<Graduation> ListaAgrupada { get; set; }

        public Membros() {
            InitializeComponent();

            switch (Device.RuntimePlatform) {
                case Device.Android:
                    Padding = new Thickness(10, 20, 10, 10);
                    break;

                default:
                    Padding = new Thickness(10);
                    break;
            }

            ListaAgrupada = new ObservableCollection<Graduation>();

            var EscudadoCategory = new Graduation() { CodGraduacao = "1", DscGraduacao = "Escudado" };
            EscudadoCategory.Add(new Members { Apelido = "Carlos", NomeMembro = "Carlos" });
            EscudadoCategory.Add(new Members { Apelido = "Marcão", NomeMembro = " Marcos" });
            EscudadoCategory.Add(new Members { Apelido = "Tobias", NomeMembro = "Tobias" });
            EscudadoCategory.Add(new Members { Apelido = "Ganiza", NomeMembro = "Rafael" });
            EscudadoCategory.Add(new Members { Apelido = "Minion", NomeMembro = "Aleixo" });
            EscudadoCategory.Add(new Members { Apelido = "Gabi", NomeMembro = "Gabi" });
            EscudadoCategory.Add(new Members { Apelido = "Loyd", NomeMembro = "Ricardo" });
            EscudadoCategory.Add(new Members { Apelido = "TopGun", NomeMembro = "Jonas" });
            EscudadoCategory.Add(new Members { Apelido = "Vânia", NomeMembro = "Vânia" });
            EscudadoCategory.Add(new Members { Apelido = "Bigão", NomeMembro = "Fabiano" });
            EscudadoCategory.Add(new Members { Apelido = "Mau", NomeMembro = "Maurício" });
            EscudadoCategory.Add(new Members { Apelido = "Mano", NomeMembro = "Mano" });
            EscudadoCategory.Add(new Members { Apelido = "Alê", NomeMembro = "Alexandre" });
            EscudadoCategory.Add(new Members { Apelido = "Carol", NomeMembro = "Ana Carolina" });
            EscudadoCategory.Add(new Members { Apelido = "Smoke", NomeMembro = "Roberto" });
            EscudadoCategory.Add(new Members { Apelido = "Marada", NomeMembro = "Renato" });
            ListaAgrupada.Add(EscudadoCategory);

            var MeioEscudoCategory = new Graduation() { CodGraduacao = "2", DscGraduacao = "Meio Escudo" };
            MeioEscudoCategory.Add(new Members { Apelido = "Peppo", NomeMembro = "Cristiano" });
            MeioEscudoCategory.Add(new Members { Apelido = "Pira", NomeMembro = "Anderson" });
            MeioEscudoCategory.Add(new Members { Apelido = "Barbeiro", NomeMembro = "Evandro" });
            ListaAgrupada.Add(MeioEscudoCategory);

            var ProsperoCategory = new Graduation() { CodGraduacao = "3", DscGraduacao = "Próspero" };
            ProsperoCategory.Add(new Members { Apelido = "Proed", NomeMembro = "Arthur" });
            ProsperoCategory.Add(new Members { Apelido = "Zé Bunitinho", NomeMembro = "Cristian" });
            ListaAgrupada.Add(ProsperoCategory);

            listView.ItemsSource = ListaAgrupada;
        }
    }
}