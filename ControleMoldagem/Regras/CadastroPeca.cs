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
    class CadastroPeca
    {
        RepositorioPeca rPeca = new RepositorioPeca();
        RepositorioEixo rEixo = new RepositorioEixo();
        RepositorioObra rObra = new RepositorioObra();
        public void InserirPeca(string idObra, string idEixo, string nome)
        {
            
            Peca[] peca = BuscarPeca(nome, idEixo, idObra, "cNomePeca");
            if (peca.Length > 0)
            {
                MessageBox.Show("Peça ja Cadastrada",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                Peca iPeca = new Peca();
                iPeca.IdEixo = Convert.ToInt32(idEixo);
                iPeca.IdObra = Convert.ToInt32(idObra);
                iPeca.NomePeca = nome;
                rPeca.inserir(iPeca);
            }
        }

        public void EditarPeca(string idObra, string idEixo, string nome, string novo)
        {
            Peca[] peca;
            peca = BuscarPeca(novo, idEixo,idObra, "cNomePeca");
            if (peca.Length > 0)
            {
                MessageBox.Show("Eixo ja Cadastrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                peca = BuscarPeca(nome, idEixo, idObra, "cNomePeca");
                Peca iPeca = peca[0];
                rPeca.editar(iPeca, novo);
            }
        }

        public Peca[] BuscarPeca(string nome, string idEixo, string idObra, string campo)
        {
            DataTable resultado = rPeca.buscar(nome, idEixo, idObra, campo);
            Peca[] peca = new Peca[resultado.Rows.Count];
            Peca item = new Peca();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                item.IdPeca = Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.IdObra = Convert.ToInt32(resultado.Rows[i][1].ToString());
                item.IdEixo = Convert.ToInt32(resultado.Rows[i][2].ToString());
                item.NomePeca = resultado.Rows[i][3].ToString();
                peca[i] = item;
            }
            if (peca.Length < 0)
            {
                MessageBox.Show("Peça não encontrada",
                "Erro ao Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return peca;
        }

        public Peca[] BuscarTodos(int obra, int eixo)
        {
            int registros = rPeca.buscarTudo(obra, eixo).Rows.Count;
            DataTable resultado = rPeca.buscarTudo(obra, eixo);
            Peca[] peca = new Peca[registros];
            for (int i = 0; i < registros; i++)
            {
                Peca item = new Peca();
                item.IdPeca = Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.IdObra = Convert.ToInt32(resultado.Rows[i][1].ToString());
                item.IdEixo = Convert.ToInt32(resultado.Rows[i][2].ToString());
                item.NomePeca = resultado.Rows[i][3].ToString();
                peca[i] = item;
            }
            return peca;
        }
    }
}
