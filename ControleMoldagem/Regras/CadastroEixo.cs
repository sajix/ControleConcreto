using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMoldagem.Entidades;
using ControleMoldagem.Dados;
using System.Windows.Forms;
using System.Data;

namespace ControleMoldagem.Regras
{
    class CadastroEixo
    {
        RepositorioPeca rPeca = new RepositorioPeca();
        RepositorioEixo rEixo = new RepositorioEixo();
        RepositorioMoldagem rMoldagem = new RepositorioMoldagem();

        public void InserirEixo(string nome, string idObra, string campo)
        {
            Eixo[] eixo;
            eixo = BuscarEixo(nome, idObra, "cNomeEixo");
            if (eixo.Length > 0)
            {
                MessageBox.Show("Eixo ja Cadastrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                Eixo iEixo = new Eixo();
                iEixo.NomeEixo = nome;
                iEixo.IdObra = Convert.ToInt32(idObra);
                rEixo.inserir(iEixo);
            }
        }
        public void EditarEixo(string nome, string novo,string idObra)
        {
            Eixo[] eixo;
            eixo = BuscarEixo(novo, idObra, "cNomeEixo");
            if (eixo.Length > 0)
            {
                MessageBox.Show("Eixo ja Cadastrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                eixo = BuscarEixo(nome, idObra, "cNomeEixo");
                Eixo iEixo = eixo[0];
                rEixo.editar(novo, iEixo);
            }
        }
        public Eixo[] BuscarEixo(string nome, string idObra, string campo)
        {
            DataTable resultado = rEixo.buscar(nome, idObra, campo);
            Eixo[] eixo = new Eixo[resultado.Rows.Count];
            Eixo item = new Eixo();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                item.IdEixo = Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.IdObra = Convert.ToInt32(resultado.Rows[i][1].ToString());
                item.NomeEixo = resultado.Rows[i][2].ToString();
                eixo[i] = item;
            }
            if (eixo.Length < 0)
            {
                MessageBox.Show("Eixo não encontrado",
                "Erro ao Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return eixo;
        }
        public Eixo[] BuscarTodos(int obra)
        {
            int registros = rEixo.buscarTudo(obra).Rows.Count;
            DataTable resultado = rEixo.buscarTudo(obra);
            Eixo[] eixo = new Eixo[registros];
            for (int i = 0; i < registros; i++)
            {
                Eixo item = new Eixo();
                item.IdEixo = Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.NomeEixo = resultado.Rows[i][2].ToString();
                item.IdObra = Convert.ToInt32(resultado.Rows[i][1].ToString());
                eixo[i] = item;
            }
            return eixo;
        }
    }
}
