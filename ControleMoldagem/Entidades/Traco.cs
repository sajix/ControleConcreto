using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    public class Traco
    {
        private int idTraco;

        public int IdTraco
        {
            get { return idTraco; }
            set { idTraco = value; }
        }

        private string codigoTraco;

        public string CodigoTraco
        {
            get { return codigoTraco; }
            set { codigoTraco = value; }
        }
        private string usina;

        public string Usina
        {
            get { return usina; }
            set { usina = value; }
        }
        private int fck;

        public int Fck
        {
            get { return fck; }
            set { fck = value; }
        }
        private decimal fatorAC;

        public decimal FatorAC
        {
            get { return fatorAC; }
            set { fatorAC = value; }
        }
        private int idadeControle;

        public int IdadeControle
        {
            get { return idadeControle; }
            set { idadeControle = value; }
        }
        private decimal consumoCimento;

        public decimal ConsumoCimento
        {
            get { return consumoCimento; }
            set { consumoCimento = value; }
        }
        private int consistencia;

        public int Consistencia
        {
            get { return consistencia; }
            set { consistencia = value; }
        }

        private int tolerancia;

        public int Tolerancia
        {
            get { return tolerancia; }
            set { tolerancia = value; }
        }

        public Traco(int idTraco, string codigoTraco, string usina, int fck, decimal fatorAC, int idadeControle, decimal consumoCimento, int consistencia)
        {
            this.idTraco = idTraco;
            this.codigoTraco = codigoTraco;
            this.usina = usina;
            this.fck = fck;
            this.fatorAC = fatorAC;
            this.idadeControle = idadeControle;
            this.consumoCimento = consumoCimento;
            this.consistencia = consistencia;
        }
        public Traco()
        {
        }
    }
}
