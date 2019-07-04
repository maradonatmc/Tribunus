using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Tribunus.Models;

namespace Tribunus.ViewModels {
    public partial class MembrosViewModel {
        private ObservableCollection<Membro> items;
        public ObservableCollection<Membro> Items {
            get { return items; }
            set { items = value; }
        }

        public MembrosViewModel() {
            Items = new ObservableCollection<Membro>() {
                new Membro() {
                    NOME_MEMBRO = "Renato Ramos e Ramos",
                    APELIDO_MEMBRO = "Maradona - Escudado (Ad Aeternum)"
                },
                new Membro() {
                    NOME_MEMBRO = "Teste ListView",
                    APELIDO_MEMBRO = "Teste ListView com Detalhes"
                }
            };
        }
    }
}
