using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class Moto {
        public Moto() {
        }

        private int _SEQ_MOTO;
        public int SEQ_MOTO {
            get { return _SEQ_MOTO; }
            set { _SEQ_MOTO = value; }
        }

        private string _DSC_MARCA;
        public string DSC_MARCA {
            get { return _DSC_MARCA; }
            set { _DSC_MARCA = value; }
        }

        private string _DSC_MODELO;
        public string DSC_MODELO {
            get { return _DSC_MODELO; }
            set { _DSC_MODELO = value; }
        }

        private string _DSC_ANO;
        public string DSC_ANO {
            get { return _DSC_ANO; }
            set { _DSC_ANO = value; }
        }

        private string _DSC_PLACA;
        public string DSC_PLACA {
            get { return _DSC_PLACA; }
            set { _DSC_PLACA = value; }
        }
    }
}
