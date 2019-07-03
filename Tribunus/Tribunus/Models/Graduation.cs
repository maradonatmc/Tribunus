using System.Collections.ObjectModel;

namespace Tribunus.Models {
    public class Graduation : ObservableCollection<CadastroMembros> {

        public string CodGraduacao { get; set; }
        public string DscGraduacao { get; set; }
    }
}
