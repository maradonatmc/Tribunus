using System.Collections.ObjectModel;
using Tribunus.Models;

namespace Tribunus.ViewModels {
    public class MembrosViewModel {
        private ObservableCollection<Membros> _lstMembros;
        public ObservableCollection<Membros> lstMembros {
            get { return _lstMembros; }
            set { _lstMembros = value; }
        }

        public MembrosViewModel() {
            lstMembros = new ObservableCollection<Membros>() {
                new Membros {
                    SEQ_MEMBRO = 1,
                    NOME_MEMBRO = "Renato Ramos e Ramos",
                    APELIDO_MEMBRO = "Maradona - Escudado (Ad Aeternum)"
                    }
            };
        }
    }
}
