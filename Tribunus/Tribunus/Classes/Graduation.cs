using System.Collections.ObjectModel;

namespace Tribunus.Classes {
    public class Graduation : ObservableCollection<Members> {

        public string CodGraduacao { get; set; }
        public string DscGraduacao { get; set; }
    }
}
