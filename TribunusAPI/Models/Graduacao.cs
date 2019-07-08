namespace TribunusAPI.Models {
    public class Graduacao {
        public Graduacao() {
        }

        private int _SEQ_GRADUACAO;
        public int SEQ_GRADUACAO {
            get { return _SEQ_GRADUACAO; }
            set { _SEQ_GRADUACAO = value; }
        }

        private string _DSC_GRADUACAO;
        public string DSC_GRADUACAO {
            get { return _DSC_GRADUACAO; }
            set { _DSC_GRADUACAO = value; }
        }
    }
}
