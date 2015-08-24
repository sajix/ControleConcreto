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
    class CadastroCodigoBarras
    {
        RepositorioCodigoBarras rCodigoBarras = new RepositorioCodigoBarras();
        public void InserirCodigoBarras(string codigoBarras, string idSerie, string situacao)
        {
            CodigoBarras cBarras = new CodigoBarras();
            cBarras = rCodigoBarras.Buscar(codigoBarras);
            if (cBarras.IdCodigoBarras != "")
            {
                MessageBox.Show("Codigo de Barras ja Cadastrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            cBarras.IdCodigoBarras = codigoBarras;
            cBarras.IdSerie = Convert.ToInt32(idSerie);
            cBarras.Situacao = Convert.ToByte(situacao);
            rCodigoBarras.Inserir(cBarras);
        }
        public void EditarCodigoBarras(string novo, string codigoBarras, string idSerie, string situacao)
        {
            CodigoBarras cBarras = new CodigoBarras();
            cBarras.IdCodigoBarras = codigoBarras;
            cBarras.IdSerie = Convert.ToInt32(idSerie);
            cBarras.Situacao = Convert.ToByte(situacao);
            rCodigoBarras.Editar(novo, cBarras);
        }
        public CodigoBarras BuscarCodigoBarras(string codigoBarras)
        {
            CodigoBarras cBarras = new CodigoBarras();
            cBarras = rCodigoBarras.Buscar(codigoBarras);
            if (cBarras.IdCodigoBarras == "")
            {
                MessageBox.Show("Codigo de Barras não encontrado",
                "Erro ao Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return cBarras;
        }

        public void RemoverCodigoBarras(string codigoBarras)
        {
            
            CodigoBarras cBarras = new CodigoBarras();
            cBarras = rCodigoBarras.Buscar(codigoBarras);
            cBarras = rCodigoBarras.Buscar(codigoBarras);
            rCodigoBarras.Remover(Convert.ToInt32(codigoBarras));
        }

        public CodigoBarras [] BuscarTodos()
        {
            CodigoBarras[] aCB;
            aCB = rCodigoBarras.BuscarTudo();
            return aCB;
        }
        public CodigoBarras[] BuscarSerie(string serie)
        {
            CodigoBarras[] aCB;
            aCB = rCodigoBarras.BuscarSerie(serie);
            return aCB;
        }
    }
}
