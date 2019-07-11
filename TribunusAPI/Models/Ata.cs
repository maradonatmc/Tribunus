using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TribunusAPI.Models {
    public class Ata {
        public Ata() {
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private byte[] _ArquivoAta;
        public byte[] ArquivoAta {
            get { return _ArquivoAta; }
            set { _ArquivoAta = value; }
        }
    }
}
