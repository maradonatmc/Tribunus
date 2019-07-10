using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class Ata {
        public Ata() {
        }

        private int _SEQ_ATA;
        public int SEQ_ATA {
            get { return _SEQ_ATA; }
            set { _SEQ_ATA = value; }
        }

        private byte[] _ARQUIVO_ATA;
        public byte[] ARQUIVO_ATA {
            get { return _ARQUIVO_ATA; }
            set { _ARQUIVO_ATA = value; }
        }
    }
}
