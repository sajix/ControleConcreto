using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class Obra
    {
        private int idObra;

        public int IdObra
        {
            get { return idObra; }
            set { idObra = value; }
        }
        private string nomeObra;

        public string NomeObra
        {
            get { return nomeObra; }
            set { nomeObra = value; }
        }

        public Obra(int idObra, string nomeObra)
        {
            this.idObra = idObra;
            this.nomeObra = nomeObra;
        }
        public Obra() { }
    }
}
