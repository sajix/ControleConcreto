using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Entidades
{
    class Moldagem
    {
        private int idSerie;

        public int IdSerie
        {
            get { return idSerie; }
            set { idSerie = value; }
        }
        private DateTime dataMoldagem;

        public DateTime DataMoldagem
        {
            get { return dataMoldagem; }
            set { dataMoldagem = value; }
        }
        private DateTime horaMoldagem;

        public DateTime HoraMoldagem
        {
            get { return horaMoldagem; }
            set { horaMoldagem = value; }
        }
        private int lote;

        public int Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        private int idTraco;

        public int IdTraco
        {
            get { return idTraco; }
            set { idTraco = value; }
        }
        private int fck;

        public int Fck
        {
            get { return fck; }
            set { fck = value; }
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
        private int idPeca;

        public int IdPeca
        {
            get { return idPeca; }
            set { idPeca = value; }
        }
        private int quantidadeCP;

        public int QuantidadeCP
        {
            get { return quantidadeCP; }
            set { quantidadeCP = value; }
        }
        private int idadeControle;

        public int IdadeControle
        {
            get { return idadeControle; }
            set { idadeControle = value; }
        }
        private int idadeA;

        public int IdadeA
        {
            get { return idadeA; }
            set { idadeA = value; }
        }
        private int idadeB;

        public int IdadeB
        {
            get { return idadeB; }
            set { idadeB = value; }
        }
        private int idadeC;

        public int IdadeC
        {
            get { return idadeC; }
            set { idadeC = value; }
        }
        private double volumeBetonada;

        public double VolumeBetonada
        {
            get { return volumeBetonada; }
            set { volumeBetonada = value; }
        }

        private decimal temperaturaAr;

        public decimal TemperaturaAr
        {
            get { return temperaturaAr; }
            set { temperaturaAr = value; }
        }

        private decimal temperaturaCimento;

        public decimal TemperaturaCimento
        {
            get { return temperaturaCimento; }
            set { temperaturaCimento = value; }
        }

        private int nota;

        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }


        public Moldagem(int idSerie, DateTime dataMoldagem, DateTime horaMoldagem, int lote, int idTraco, int fck, int idObra, int idEixo, int idPeca, int quantidadeCP, int idadeControle, int idadeA, int idadeB, int idadeC, int volumeBetonada, decimal temperaturaAr, decimal temperaturaCimento, int nota)
        {
            this.idSerie = idSerie;
            this.dataMoldagem = dataMoldagem;
            this.horaMoldagem = horaMoldagem;
            this.lote = lote;
            this.idTraco = idTraco;
            this.fck = fck;
            this.idObra = idObra;
            this.idEixo = idEixo;
            this.idPeca = idPeca;
            this.quantidadeCP = quantidadeCP;
            this.idadeControle = idadeControle;
            this.idadeA = idadeA;
            this.idadeB = idadeB;
            this.idadeC = idadeC;
            this.volumeBetonada = volumeBetonada;
            this.temperaturaAr = temperaturaAr;
            this.temperaturaCimento = temperaturaCimento;
            this.nota = nota;
        }
        public Moldagem() { }
    }
}
