using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMoldagem.Dados;
using ControleMoldagem.Entidades;
using System.Windows.Forms;
using System.Data;

namespace ControleMoldagem.Regras
{
    class CadastroMoldagem
    {
        RepositorioMoldagem rMoldagem = new RepositorioMoldagem();
        public void InserirMoldagem(string idSerie, string dataMoldagem, string horaMoldagem, string lote, string idTraco, string fck, string idObra, string idEixo, string idPeca, string quantidadeCP, string idadeControle, string idadeA, string idadeB, string idadeC, string volumeBetonada, string temperaturaAr, string temperaturaCimento, string nota)
        {
            Moldagem molde = new Moldagem();
            molde = rMoldagem.Buscar(Convert.ToInt32(idSerie));
            if(molde.IdSerie != 0)
            {
                MessageBox.Show("Serie ja Cadastrada",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            if (idadeB == "")
            {
                idadeB = "0";
            }
            if (idadeC == "")
            {
                idadeC = "0";
            }
            molde.IdSerie = Convert.ToInt32(idSerie);
            molde.DataMoldagem = Convert.ToDateTime(dataMoldagem);
            molde.Fck = Convert.ToInt32(fck);
            molde.HoraMoldagem = Convert.ToDateTime(horaMoldagem);
            molde.IdadeA = Convert.ToInt32(idadeA);
            molde.IdadeB = Convert.ToInt32(idadeB);
            molde.IdadeC = Convert.ToInt32(idadeC);
            molde.IdadeControle = Convert.ToInt32(idadeControle);
            molde.IdEixo = Convert.ToInt32(idEixo);
            molde.IdObra = Convert.ToInt32(idObra);
            molde.IdPeca = Convert.ToInt32(idPeca);
            molde.IdTraco = Convert.ToInt32(idTraco);
            molde.Lote = Convert.ToInt32(lote);
            molde.QuantidadeCP = Convert.ToInt32(quantidadeCP);
            molde.VolumeBetonada = Convert.ToDouble(volumeBetonada);
            molde.TemperaturaAr = Convert.ToDecimal(temperaturaAr);
            molde.TemperaturaCimento = Convert.ToDecimal(temperaturaCimento);
            molde.Nota = Convert.ToInt32(nota);
            rMoldagem.Inserir(molde);
        }
        public void EditarMoldagem(string novo, string idSerie, string dataMoldagem, string horaMoldagem, string lote, string idTraco, string fck, string idObra, string idEixo, string idPeca, string quantidadeCP, string idadeControle, string idadeA, string idadeB, string idadeC, string volumeBetonada, string temperaturaAr, string temperaturaCimento, string nota)
        {
            Moldagem molde = new Moldagem();
            if (idadeB == "")
            {
                idadeB = "0";
            }
            if (idadeC == "")
            {
                idadeC = "0";
            }
            molde.IdSerie = Convert.ToInt32(idSerie);
            molde.DataMoldagem = Convert.ToDateTime(dataMoldagem);
            molde.Fck = Convert.ToInt32(fck);
            molde.HoraMoldagem = Convert.ToDateTime(horaMoldagem);
            molde.IdadeA = Convert.ToInt32(idadeA);
            molde.IdadeB = Convert.ToInt32(idadeB);
            molde.IdadeC = Convert.ToInt32(idadeC);
            molde.IdadeControle = Convert.ToInt32(idadeControle);
            molde.IdEixo = Convert.ToInt32(idEixo);
            molde.IdObra = Convert.ToInt32(idObra);
            molde.IdPeca = Convert.ToInt32(idPeca);
            molde.IdTraco = Convert.ToInt32(idTraco);
            molde.Lote = Convert.ToInt32(lote);
            molde.QuantidadeCP = Convert.ToInt32(quantidadeCP);
            molde.VolumeBetonada = Convert.ToDouble(volumeBetonada);
            molde.TemperaturaAr = Convert.ToDecimal(temperaturaAr);
            molde.TemperaturaCimento = Convert.ToDecimal(temperaturaCimento);
            molde.Nota = Convert.ToInt32(nota);
            rMoldagem.Editar(molde);
        }
        public void AtualizarData(string campo, string serie, string idade)
        {
            rMoldagem.EditarData(campo, Convert.ToInt32(serie), Convert.ToInt32(idade));
        }
        public Moldagem BuscarMoldagem(string idSerie)
        {
            Moldagem molde = new Moldagem();
            molde = rMoldagem.Buscar(Convert.ToInt32(idSerie));
            if(molde.IdSerie == 0)
            {
                /*MessageBox.Show("Série não Encontrada",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);*/
            }
            return molde;
        }
        public void RemoverMoldagem(string idSerie)
        {
            Moldagem molde = new Moldagem();
            molde = rMoldagem.Buscar(Convert.ToInt32(idSerie));
            if (molde.IdSerie == 0)
            {
                MessageBox.Show("Série não encontrada",
                "Erro ao Remover",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            rMoldagem.Remover(Convert.ToInt32(idSerie));
        }
        public int UltimaSeria()
        {
            int serial = 0;
            DataTable resultado = rMoldagem.BuscaSerial();
            if (resultado.Rows.Count > 0)
            {
                serial = Convert.ToInt32(resultado.Rows[0][0].ToString());
            }
            serial++;
            return serial;
        }
        public Moldagem [] BuscarTudo()
        {
            Moldagem[] molde = rMoldagem.BuscarTudo();
            return molde;
        }
    }
}
