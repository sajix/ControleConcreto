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
    class CadastroObra
    {
        RepositorioObra rObra = new RepositorioObra();
        RepositorioPeca rPeca = new RepositorioPeca();
        RepositorioEixo rEixo = new RepositorioEixo();
        RepositorioMoldagem rMoldagem = new RepositorioMoldagem();

        public void InserirObra(string nome, string campo)
        {
            Obra[] bObra;
            bObra = BuscarObra(nome, campo);
            
            if (bObra.Length > 0)
            {
                MessageBox.Show("Obra ja Cadastrada",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                Obra iObra = new Obra();
                iObra.NomeObra = nome;
                rObra.Inserir(iObra);
                MessageBox.Show("Obra Cadastrada", "Cadastrar Obra", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        public void EditarObra(string nome, string novo, string campo)
        {
            DataTable resultado = rObra.Buscar(novo, campo);
            
            if (resultado.Rows.Count > 0)
            {
                MessageBox.Show("Obra ja Cadastrada",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                Obra obra = new Obra();
                obra.NomeObra = novo;
                rObra.Editar(nome, obra);
            }
        }

        public Obra[] BuscarObra(string nome, string campo)
        {
            DataTable resultado = rObra.Buscar(nome, campo);
            Obra[] obra = new Obra[resultado.Rows.Count];
            Obra item = new Obra();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                
                item.IdObra = Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.NomeObra = resultado.Rows[i][1].ToString();
                obra[i] = item;
            }
            if (obra.Length < 0)
            {
                MessageBox.Show("Obra não encontrada",
                "Erro ao Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return obra;
        }

        public void RemoverObra(string nome, string campo)
        {
            DataTable resultado = rObra.Buscar(nome, campo);
            Obra obra = new Obra();
            obra.IdObra = Convert.ToInt32(resultado.Rows[0][0].ToString());
            obra.NomeObra = resultado.Rows[0][1].ToString();
            if (obra != null)
            {
                MessageBox.Show("Obra ja Cadastrada",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }

            bool ePeca = rPeca.buscarEixo(obra.IdObra);
            bool eEixo = rEixo.buscarObra(obra.IdObra);
            bool eMoldagem = rMoldagem.BuscarPeca(obra.IdObra);
            if (eMoldagem == true)
            {
                MessageBox.Show("Obra não pode ser Remevida pois existem: Moldagems, Peças e Eixos cadastrados com essa Obra",
                "Erro ao Remover",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else if (ePeca == true)
            {
                MessageBox.Show("Obra não pode ser Remevida pois existem: Peças e Eixos cadastrados com essa Obra",
                "Erro ao Remover",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else if (eEixo == true)
            {
                MessageBox.Show("Obra não pode ser Remevida pois existem: Eixos cadastrados com essa Obra",
                "Erro ao Remover",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            rObra.Remover(nome);

        }

        public Obra[] BuscarTodos()
        {
            int registros = rObra.NRegistros();
            DataTable resultado = rObra.BuscarTudo();
            Obra[] obra = new Obra[registros];
            for (int i = 0; i < registros; i++)
            {
                Obra item = new Obra();
                item.IdObra= Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.NomeObra = resultado.Rows[i][1].ToString();
                obra[i] = item;
            }
            return obra;
        }
    }
}
