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

        public Moto Moto { get; set; }

        public Membro Membro { get; set; }
    }
}
