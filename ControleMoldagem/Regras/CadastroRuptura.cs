using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMoldagem.Dados;
using ControleMoldagem.Entidades;
using System.Windows.Forms;

namespace ControleMoldagem.Regras
{
    class CadastroRuptura
    {
        RepositorioRuptura rRuptura = new RepositorioRuptura();
        public void InserirRuptura(string CodigoBarras, string dataRuptura, string hora, string idSerie, string diametroCP, string alturaCP, string correcao, string carga)
        {
            Ruptura ruptura = new Ruptura();
            ruptura = rRuptura.Buscar(CodigoBarras);
            if (ruptura != null)
            {
                MessageBox.Show("Ruptura ja Cadastrada",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            ruptura.AlturaCP = Convert.ToDecimal(alturaCP);
            ruptura.Carga = Convert.ToDecimal(carga);
            ruptura.Correcao = Convert.ToDecimal(correcao);
            ruptura.DataRuptura = Convert.ToDateTime(dataRuptura);
            ruptura.DiametroCP = Convert.ToDecimal(diametroCP);
            ruptura.Hora = Convert.ToDateTime(hora);
            ruptura.IdCodigoBarras = CodigoBarras;
            ruptura.IdSerie = Convert.ToInt32(idSerie);
            rRuptura.Inserir(ruptura);
        }
        public void EditarRuptura(string CodigoBarras, string dataRuptura, string hora, string idSerie, string diametroCP, string alturaCP, string correcao, string carga)
        {
            Ruptura ruptura = new Ruptura();
            ruptura.AlturaCP = Convert.ToDecimal(alturaCP);
            ruptura.Carga = Convert.ToDecimal(carga);
            ruptura.Correcao = Convert.ToDecimal(correcao);
            ruptura.DataRuptura = Convert.ToDateTime(dataRuptura);
            ruptura.DiametroCP = Convert.ToDecimal(diametroCP);
            ruptura.Hora = Convert.ToDateTime(hora);
            ruptura.IdCodigoBarras = CodigoBarras;
            ruptura.IdSerie = Convert.ToInt32(idSerie);
            rRuptura.Editar(ruptura);
        }
        public Ruptura BuscarRuptura(string CodigoBarras)
        {
            Ruptura ruptura = new Ruptura();
            ruptura = rRuptura.Buscar(CodigoBarras);
            if (ruptura == null)
            {
                MessageBox.Show("Ruptura não encontrada",
                "Erro ao Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return ruptura;
        }
        public Ruptura[] BuscarRupturaSerie(string serie)
        {
            Ruptura[] ruptura = rRuptura.BuscarSerie(Convert.ToInt32(serie));
            return ruptura;
        }
        public decimal BuscaCorrecao(string alturaDiametro)
        {
            decimal correcao;
            correcao = rRuptura.BuscaCorrecao(Convert.ToDecimal(alturaDiametro));
            return correcao;
        }
        public void RemoverRuptura(string codigo)
        {
            Ruptura ruptura = new Ruptura();
            ruptura = rRuptura.Buscar(codigo);
            if (ruptura == null)
            {
                MessageBox.Show("Ruptura não encontrada",
                "Erro ao Remover",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            rRuptura.Remover(codigo);
        }
        public Ruptura [] BuscarTudo()
        {
            Ruptura[] ruptura = rRuptura.BuscarTudo();
            return ruptura;
        }

    }
}
