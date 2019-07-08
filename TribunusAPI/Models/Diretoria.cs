using System;

namespace TribunusAPI.Models {
    public class Diretoria {
        public Diretoria() {

        }

        private int _SEQ_DIRETORIA;
        public int SEQ_DIRETORIA {
            get { return _SEQ_DIRETORIA; }
            set { _SEQ_DIRETORIA = value; }
        }

        private int _SEQ_MEMBRO;
        public int SEQ_MEMBRO {
            get { return _SEQ_MEMBRO; }
            set { _SEQ_MEMBRO = value; }
        }

        private int _SEQ_CARGO;
        public int SEQ_CARGO {
            get { return _SEQ_CARGO; }
            set { _SEQ_CARGO = value; }
        }

        private DateTime _DAT_INICIO_FUNCAO;
        public DateTime DAT_INICIO_FUNCAO {
            get { return _DAT_INICIO_FUNCAO; }
            set { _DAT_INICIO_FUNCAO = value; }
        }

        private DateTime _DAT_FINAL_FUNCAO;
        public DateTime DAT_FINAL_FUNCAO {
            get { return _DAT_FINAL_FUNCAO; }
            set { _DAT_FINAL_FUNCAO = value; }
        }

        private bool _FLG_ATIVO;
        public bool FLG_ATIVO {
            get { return _FLG_ATIVO; }
            set { _FLG_ATIVO = value; }
        }
    }
}
