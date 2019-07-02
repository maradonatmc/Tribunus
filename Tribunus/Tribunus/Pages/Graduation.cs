using System.Collections.ObjectModel;

namespace Tribunus.Pages {
    public class Graduation : ObservableCollection<Members> {

        public string CodGraduacao { get; set; }
        public string DscGraduacao { get; set; }
    }
}
