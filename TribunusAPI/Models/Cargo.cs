using System.Collections.Generic;

namespace TribunusAPI.Models {
    public class Cargo {
        public Cargo() {
        }

        public Cargo(string pCargo) {
            DscCargo = pCargo;
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _DscCargo;
        public string DscCargo {
            get { return _DscCargo; }
            set { _DscCargo = value; }
        }

        public ICollection<Diretoria> Diretoria { get; set; } = new List<Diretoria>();
    }
}
