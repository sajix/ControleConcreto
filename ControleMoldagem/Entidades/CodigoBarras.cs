using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class CodigoBarras
    {
        private string idCodigoBarras;

        public string IdCodigoBarras
        {
            get { return idCodigoBarras; }
            set { idCodigoBarras = value; }
        }
        private int idSerie;

        public int IdSerie
        {
            get { return idSerie; }
            set { idSerie = value; }
        }
        private byte situacao;

        public byte Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public CodigoBarras(string idCodigoBarras, int idSerie, byte situacao)
        {
            this.idCodigoBarras = idCodigoBarras;
            this.idSerie = idSerie;
            this.situacao = situacao;
        }
        public CodigoBarras() { }
    }
}
