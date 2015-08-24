using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class Resistencia
    {
        private int idSerie;

        public int IdSerie
        {
            get { return idSerie; }
            set { idSerie = value; }
        }
        private decimal rA1;

        public decimal RA1
        {
            get { return rA1; }
            set { rA1 = value; }
        }
        private decimal rA2;

        public decimal RA2
        {
            get { return rA2; }
            set { rA2 = value; }
        }
        private decimal rB1;

        public decimal RB1
        {
            get { return rB1; }
            set { rB1 = value; }
        }
        private decimal rB2;

        public decimal RB2
        {
            get { return rB2; }
            set { rB2 = value; }
        }
        private decimal rC1;

        public decimal RC1
        {
            get { return rC1; }
            set { rC1 = value; }
        }
        private decimal rC2;

        public decimal RC2
        {
            get { return rC2; }
            set { rC2 = value; }
        }

        public Resistencia(int idSerie, decimal rA1, decimal rA2, decimal rB1, decimal rB2, decimal rC1, decimal rC2)
        {
            this.idSerie = idSerie;
            this.rA1 = rA1;
            this.rA2 = rA2;
            this.rB1 = rB1;
            this.rB2 = rB2;
            this.rC1 = rC1;
            this.rC2 = rC2;
        }
        public Resistencia()
        {

        }
    }
}
