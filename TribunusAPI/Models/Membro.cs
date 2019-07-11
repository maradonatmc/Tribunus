using System;
using System.ComponentModel.DataAnnotations;

namespace TribunusAPI.Models {
    public class Membro {

        public Membro() {
        }

        public Membro(string pNomeMembro, DateTime pDatNasc, string pApelidoMembro, DateTime pDatIngresso, Graduacao pGraduacao, 
            string pCnh, bool pAdAeternum, bool pAtivo, DateTime pDatUltAtualizacao) {
            NomeMembro = pNomeMembro;
            DatNascimento = pDatNasc;
            ApelidoMembro = pApelidoMembro;
            DatIngresso = pDatIngresso;
            Graduacao = pGraduacao;
            DscCnh = pCnh;
            FlgAdAeternum = pAdAeternum;
            FlgAtivo = pAtivo;
            DatUltAtualizacao = pDatUltAtualizacao;
        }

        private int _Id;
        public int Id {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _NomeMembro;
        public string NomeMembro {
            get { return _NomeMembro; }
            set { _NomeMembro = value; }
        }

        private DateTime _DatNascimento;
        public DateTime DatNascimento {
            get { return _DatNascimento; }
            set { _DatNascimento = value; }
        }

        private string _ApelidoMembro;
        public string ApelidoMembro {
            get { return _ApelidoMembro; }
            set { _ApelidoMembro = value; }
        }

        private DateTime _DatIngresso;
        public DateTime DatIngresso {
            get { return _DatIngresso; }
            set { _DatIngresso = value; }
        }

        public Graduacao Graduacao { get; set; }

        private int _IdGraduacao;
        public int IdGraduacao {
            get { return _IdGraduacao; }
            set { _IdGraduacao = value; }
        }

        private string _DscCnh;
        public string DscCnh {
            get { return _DscCnh; }
            set { _DscCnh = value; }
        }

        private bool _FlgAdAeternum;
        public bool FlgAdAeternum {
            get { return _FlgAdAeternum; }
            set { _FlgAdAeternum = value; }
        }

        private bool _FlgAtivo;
        public bool FlgAtivo {
            get { return _FlgAtivo; }
            set { _FlgAtivo = value; }
        }

        private DateTime? _DatUltAtualizacao;
        public DateTime? DatUltAtualizacao {
            get { return _DatUltAtualizacao; }
            set { _DatUltAtualizacao = value; }
        }
    }
}
