using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class MotoMembro {
        public MotoMembro() {
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdMoto;
        public int IdMoto {
            get { return _IdMoto; }
            set { _IdMoto = value; }
        }

        private int _IdMembro;
        public int IdMembro {
            get { return _IdMembro; }
            set { _IdMembro = value; }
        }
    }
}
