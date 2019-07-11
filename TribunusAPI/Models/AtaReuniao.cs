using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class AtaReuniao {
        public AtaReuniao() {
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private int _IdAta;
        public int IdAta {
            get { return _IdAta; }
            set { _IdAta = value; }
        }

        private int _IdReuniao;
        public int IdReuniao {
            get { return _IdReuniao; }
            set { _IdReuniao = value; }
        }
    }
}
