using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class MotoMembro {
        public MotoMembro() {
        }

        private int _SEQ_MOTO_MEMBRO;
        public int SEQ_MOTO_MEMBRO {
            get { return _SEQ_MOTO_MEMBRO; }
            set { _SEQ_MOTO_MEMBRO = value; }
        }

        private int _SEQ_MOTO;
        public int SEQ_MOTO {
            get { return _SEQ_MOTO; }
            set { _SEQ_MOTO = value; }
        }

        private int _SEQ_MEMBRO;
        public int SEQ_MEMBRO {
            get { return _SEQ_MEMBRO; }
            set { _SEQ_MEMBRO = value; }
        }
    }
}
