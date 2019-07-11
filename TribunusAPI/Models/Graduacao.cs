using System.Collections.Generic;

namespace TribunusAPI.Models {
    public class Graduacao {
        public Graduacao() {
        }

        public Graduacao(string pGraduacao) {
            DscGraduacao = pGraduacao;
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _DscGraduacao;
        public string DscGraduacao {
            get { return _DscGraduacao; }
            set { _DscGraduacao = value; }
        }

        public ICollection<Membro> Membros { get; set; } = new List<Membro>();
    }
}
