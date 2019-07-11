using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class Reuniao {
        public Reuniao() {
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _DscLocalReuniao;
        public string DscLocalReuniao {
            get { return _DscLocalReuniao; }
            set { _DscLocalReuniao = value; }
        }

        private string _DscEnderecoReuniao;
        public string DscEnderecoReuniao {
            get { return _DscEnderecoReuniao; }
            set { _DscEnderecoReuniao = value; }
        }

        private DateTime _DatReuniao;
        public DateTime DatReuniao {
            get { return _DatReuniao; }
            set { _DatReuniao = value; }
        }
    }
}
