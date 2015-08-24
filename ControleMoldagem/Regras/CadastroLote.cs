
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
    class CadastroLote
    {
        RepositorioLote rLote = new RepositorioLote();
        public void CadastrarLote(string idSerie, string dataControle, string fck, string fckEstimado, string volume)
        {
            Lote lote = new Lote();
            lote = BuscarLote(idSerie);
            if (lote.IdSerie != 0)
            {
                MessageBox.Show("Lote ja Cadastrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                lote.DataControle = Convert.ToDateTime(dataControle);
                lote.Fck = Convert.ToInt32(fck);
                lote.FckEstimado = Convert.ToDouble(fckEstimado);
                lote.IdSerie = Convert.ToInt32(idSerie);
                lote.Volume = Convert.ToDecimal(volume);
                rLote.inserir(lote);
            }
        }

        public void EditarLote(string novo, string idSerie, string dataControle, string fck, string fckEstimado, string volume)
        {
            Lote lote = new Lote();
            lote = BuscarLote(novo);
            if (lote.IdSerie != 0)
            {
                MessageBox.Show("Lote ja Cadastrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                lote.DataControle = Convert.ToDateTime(dataControle);
                lote.Fck = Convert.ToInt32(fck);
                if (fckEstimado == "")
                {
                    fckEstimado = "0";
                }
                lote.FckEstimado = Convert.ToDouble(fckEstimado);
                lote.IdSerie = Convert.ToInt32(idSerie);
                lote.Volume = Convert.ToDecimal(volume);
                rLote.editar(lote);
            }
        }
        public void RemoverLote(string idSerie)
        {
            rLote.remover(Convert.ToInt32(idSerie));
        }
        public int UltimaNLote()
        {
            int lote = 0;
            DataTable resultado = rLote.BuscaNLote();
            if (resultado.Rows.Count > 0)
            {
                lote = Convert.ToInt32(resultado.Rows[0][0].ToString());
            }
            lote++;
            return lote;
        }
        public Lote BuscarLote(string codigo)
        {
            Lote lote = new Lote();
            lote = rLote.buscar(Convert.ToInt32(codigo));
            if (lote == null)
            {
                MessageBox.Show("Lote não Encontrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return lote;
        }
        public Lote [] BuscarTodosLotes()
        {
            Lote [] lote = rLote.BuscarTudo();
            return lote;
        }
    }
}
