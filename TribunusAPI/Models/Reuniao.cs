using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class Reuniao {
        public Reuniao() {
        }

        private int _SEQ_REUNIAO;
        public int SEQ_REUNIAO {
            get { return _SEQ_REUNIAO; }
            set { _SEQ_REUNIAO = value; }
        }

        private string _DSC_LOCAL_REUNIAO;
        public string DSC_LOCAL_REUNIAO {
            get { return _DSC_LOCAL_REUNIAO; }
            set { _DSC_LOCAL_REUNIAO = value; }
        }

        private string _DSC_ENDERECO_REUNIAO;
        public string DSC_ENDERECO_REUNIAO {
            get { return _DSC_ENDERECO_REUNIAO; }
            set { _DSC_ENDERECO_REUNIAO = value; }
        }

        private DateTime _DAT_REUNIAO;
        public DateTime DAT_REUNIAO {
            get { return _DAT_REUNIAO; }
            set { _DAT_REUNIAO = value; }
        }
    }
}
