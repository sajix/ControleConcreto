using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class Peca
    {
        private int idPeca;

        public int IdPeca
        {
            get { return idPeca; }
            set { idPeca = value; }
        }
        private int idObra;

        public int IdObra
        {
            get { return idObra; }
            set { idObra = value; }
        }
        private int idEixo;

        public int IdEixo
        {
            get { return idEixo; }
            set { idEixo = value; }
        }
        private string nomePeca;

        public string NomePeca
        {
            get { return nomePeca; }
            set { nomePeca = value; }
        }

        public Peca(int idPeca, int idObra, int idEixo, string nomePeca)
        {
            this.idEixo = idEixo;
            this.idObra = idObra;
            this.idPeca = idPeca;
            this.nomePeca = nomePeca;
        }
        public Peca() { }
    }
}
