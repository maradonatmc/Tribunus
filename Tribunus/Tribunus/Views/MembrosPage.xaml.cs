using System.Collections.ObjectModel;
using Tribunus.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tribunus.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MembrosPage : ContentPage {
        public ObservableCollection<Graduation> ListaAgrupada { get; set; }

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

            ListaAgrupada = new ObservableCollection<Graduation>();

            var EscudadoCategory = new Graduation() { CodGraduacao = "1", DscGraduacao = "Escudado" };
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Carlos", NomeMembro = "Carlos" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Marcão", NomeMembro = " Marcos" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Tobias", NomeMembro = "Tobias" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Ganiza", NomeMembro = "Rafael" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Minion", NomeMembro = "Aleixo" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Gabi", NomeMembro = "Gabi" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Loyd", NomeMembro = "Ricardo" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "TopGun", NomeMembro = "Jonas" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Vânia", NomeMembro = "Vânia" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Bigão", NomeMembro = "Fabiano" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Mau", NomeMembro = "Maurício" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Mano", NomeMembro = "Mano" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Alê", NomeMembro = "Alexandre" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Carol", NomeMembro = "Ana Carolina" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Smoke", NomeMembro = "Roberto" });
            EscudadoCategory.Add(new CadastroMembros { Apelido = "Marada", NomeMembro = "Renato" });
            ListaAgrupada.Add(EscudadoCategory);

            var MeioEscudoCategory = new Graduation() { CodGraduacao = "2", DscGraduacao = "Meio Escudo" };
            MeioEscudoCategory.Add(new CadastroMembros { Apelido = "Peppo", NomeMembro = "Cristiano" });
            MeioEscudoCategory.Add(new CadastroMembros { Apelido = "Pira", NomeMembro = "Anderson" });
            MeioEscudoCategory.Add(new CadastroMembros { Apelido = "Barbeiro", NomeMembro = "Evandro" });
            ListaAgrupada.Add(MeioEscudoCategory);

            var ProsperoCategory = new Graduation() { CodGraduacao = "3", DscGraduacao = "Próspero" };
            ProsperoCategory.Add(new CadastroMembros { Apelido = "Proed", NomeMembro = "Arthur" });
            ProsperoCategory.Add(new CadastroMembros { Apelido = "Zé Bunitinho", NomeMembro = "Cristian" });
            ListaAgrupada.Add(ProsperoCategory);
        }
    }
}