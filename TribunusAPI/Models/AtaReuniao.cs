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

        public Ata Ata { get; set; }

        public Reuniao Reuniao { get; set; }
    }
}
