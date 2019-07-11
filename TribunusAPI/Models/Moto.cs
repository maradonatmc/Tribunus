using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class Moto {
        public Moto() {
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _DscMarca;
        public string DscMarca {
            get { return _DscMarca; }
            set { _DscMarca = value; }
        }

        private string _DscModelo;
        public string DscModelo {
            get { return _DscModelo; }
            set { _DscModelo = value; }
        }

        private string _DscAno;
        public string DscAno {
            get { return _DscAno; }
            set { _DscAno = value; }
        }

        private string _DscPlaca;
        public string DscPlaca {
            get { return _DscPlaca; }
            set { _DscPlaca = value; }
        }
    }
}
