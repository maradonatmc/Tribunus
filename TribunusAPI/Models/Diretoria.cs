using System;

namespace TribunusAPI.Models {
    public class Diretoria {
        public Diretoria() {

        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdMembro;
        public int IdMembro {
            get { return _IdMembro; }
            set { _IdMembro = value; }
        }

        private int _IdCargo;
        public int IdCargo {
            get { return _IdCargo; }
            set { _IdCargo = value; }
        }

        private DateTime _DatInicioFuncao;
        public DateTime DatInicioFuncao {
            get { return _DatInicioFuncao; }
            set { _DatInicioFuncao = value; }
        }

        private DateTime _DatFinalFuncao;
        public DateTime DatFinalFuncao {
            get { return _DatFinalFuncao; }
            set { _DatFinalFuncao = value; }
        }

        private bool _FlgAtivo;
        public bool FlgAtivo {
            get { return _FlgAtivo; }
            set { _FlgAtivo = value; }
        }
    }
}
