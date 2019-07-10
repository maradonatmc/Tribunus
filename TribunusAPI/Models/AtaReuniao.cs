using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class AtaReuniao {
        public AtaReuniao() {
        }

        private int _SEQ_ATA_REUNIAO;
        public int SEQ_ATA_REUNIAO {
            get { return _SEQ_ATA_REUNIAO; }
            set { _SEQ_ATA_REUNIAO = value; }
        }

        private int _SEQ_ATA;
        public int SEQ_ATA {
            get { return _SEQ_ATA; }
            set { _SEQ_ATA = value; }
        }

        private int _SEQ_REUNIAO;
        public int SEQ_REUNIAO {
            get { return _SEQ_REUNIAO; }
            set { _SEQ_REUNIAO = value; }
        }
    }
}
