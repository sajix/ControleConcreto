using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ControleMoldagem.Entidades;

namespace ControleMoldagem.Dados
{
    class RepositorioPeca
    {
        Conexao con = new Conexao();
        public void inserir(Peca peca)
        {
            con.open();
            con.executeQuery("INSERT INTO tblPeca (cIDObra, cIDEixo, cNomePeca) VALUES ("+ peca.IdObra + ", " + peca.IdEixo + ", '" + peca.NomePeca + "') ");
            con.close();
        }
        public void remover(string nome)
        {
            con.open();
            con.executeQuery("DELETE FROM tblPeca WHERE (cNomePeca =" + nome + ")");
            con.close();
        }
        public DataTable buscar(string nome, string idEixo, string idObra, string campo)
        {
            con.open();
            con.executeQuery("SELECT * FROM tblPeca WHERE ("+ campo +" ='" + nome + "' AND cIDEixo = " + idEixo + "AND cIDObra =" + idObra + ")");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public DataTable buscarTudo(int obra, int eixo)
        {
            con.open();
            con.executeQuery("SELECT * FROM tblPeca WHERE cIDObra = " + obra + " AND cIDEixo = " + eixo);
            DataTable resultado = con.getResult();
            con.close();
            return resultado;

        }
        public Boolean buscarEixo(int codigo)
        {
            bool exist = new bool();
            con.open();
            con.executeQuery("SELECT * FROM tblPeca WHERE (cIDObra =" + codigo + ")");
            DataTable resultado = con.getResult();
            if (resultado == null)
            {
                exist = false;
            }
            else
            {
                exist = true;
            }
            return exist;
        }
        
        

        public void editar(Peca peca, string nome)
        {
            con.open();
            con.executeQuery("UPDATE tblPeca SET cNomePeca = '" + nome + "' WHERE cIDPeca =" + peca.IdPeca + " AND cIDEixo = " + peca.IdEixo + " AND cIDObra = " + peca.IdObra);
            con.close();
        }
    }
}
