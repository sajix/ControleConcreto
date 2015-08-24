using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class Lote
    {
        private int idSerie;

        public int IdSerie
        {
            get { return idSerie; }
            set { idSerie = value; }
        }
        private DateTime dataControle;

        public DateTime DataControle
        {
            get { return dataControle; }
            set { dataControle = value; }
        }
        private int fck;

        public int Fck
        {
            get { return fck; }
            set { fck = value; }
        }
        private double fckEstimado;

        public double FckEstimado
        {
            get { return fckEstimado; }
            set { fckEstimado = value; }
        }

        private decimal volume;

        public decimal Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public Lote(int idSerie, DateTime dataControle, int fck, double fckEstimado, decimal volume)
        {
            this.idSerie = idSerie;
            this.dataControle = dataControle;
            this.fck = fck;
            this.fckEstimado = fckEstimado;
            this.volume = volume;
        }
        public Lote() { }
    }
}
