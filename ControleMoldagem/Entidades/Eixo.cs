using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class Eixo
    {
        private int idEixo;

        public int IdEixo
        {
            get { return idEixo; }
            set { idEixo = value; }
        }
        private int idObra;

        public int IdObra
        {
            get { return idObra; }
            set { idObra = value; }
        }
        private string nomeEixo;

        public string NomeEixo
        {
            get { return nomeEixo; }
            set { nomeEixo = value; }
        }

        public Eixo(int idEixo, int idObra, string nomeEixo)
        {
            this.idEixo = idEixo;
            this.idObra = idObra;
            this.nomeEixo = nomeEixo;
        }
        public Eixo() { }
    }
}
