using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class Ruptura
    {
        private string idCodigoBarras;
        public string IdCodigoBarras
        {
            get { return idCodigoBarras; }
            set { idCodigoBarras = value; }
        }

        private DateTime dataRuptura;
        public DateTime DataRuptura
        {
            get { return dataRuptura; }
            set { dataRuptura = value; }
        }

        private DateTime hora;
        public DateTime Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        private int idSerie;
        public int IdSerie
        {
            get { return idSerie; }
            set { idSerie = value; }
        }

        private decimal diametroCP;
        public decimal DiametroCP
        {
            get { return diametroCP; }
            set { diametroCP = value; }
        }

        private decimal alturaCP;
        public decimal AlturaCP
        {
            get { return alturaCP; }
            set { alturaCP = value; }
        }

        private decimal correcao;
        public decimal Correcao
        {
            get { return correcao; }
            set { correcao = value; }
        }

        private decimal carga;
        public decimal Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        public Ruptura(string idCodigoBarras, DateTime dataRuptura, DateTime hora, int idSerie, decimal diametroCP, decimal alturaCP, decimal correcao, decimal carga)
        {
            this.idCodigoBarras = idCodigoBarras;
            this.dataRuptura = dataRuptura;
            this.hora = hora;
            this.idSerie = idSerie;
            this.diametroCP = diametroCP;
            this.alturaCP = alturaCP;
            this.correcao = correcao;
            this.carga = carga;
        }

        public Ruptura()
        {
        }
    }
}
