namespace TribunusAPI.Models {
    public class Cargo {
        public Cargo() {
        }

        private int _SEQ_CARGO;
        public int SEQ_CARGO {
            get { return _SEQ_CARGO; }
            set { _SEQ_CARGO = value; }
        }

        private string _DSC_CARGO;
        public string DSC_CARGO {
            get { return _DSC_CARGO; }
            set { _DSC_CARGO = value; }
        }
    }
}
