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
    class RepositorioEixo
    {
        Conexao con = new Conexao();
        public void inserir(Eixo eixo)
        {
            con.open();
            con.executeQuery("INSERT INTO tblEixo (cIDObra, cNomeEixo) VALUES (" + eixo.IdObra + ", '"+ eixo.NomeEixo + "') ");
            con.close();
        }
        public void remover(string nome)
        {
            con.open();
            con.executeQuery("DELETE FROM tblEixo WHERE (cNomeEixo =" + nome + ")");
            con.close();
        }
        public DataTable buscar(string nome, string idObra, string campo)
        {
            con.open();
            con.executeQuery("SELECT * FROM tblEixo WHERE ("+ campo +" ='" + nome + "' AND cIDObra ="+ idObra + ")");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }

        public Boolean buscarObra(int codigo)
        {
            bool exist = new bool();
            con.open();
            con.executeQuery("SELECT * FROM tblEixo WHERE (cIDObra =" + codigo + ")");
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
        public void editar(string nome, Eixo eixo)
        {
            con.open();
            con.executeQuery("UPDATE tblEixo SET cNomeEixo = '" + nome + "' WHERE cIDEixo =" + eixo.IdEixo + " AND cIDObra ="+ eixo.IdObra);
            con.close();
        }


        public DataTable buscarTudo(int obra)
        {
            con.open();
            con.executeQuery("SELECT * FROM tblEixo INNER JOIN tblObra ON tblEixo.cIDObra=tblObra.cIDObra where tblEixo.cIDObra =" + obra);
            DataTable resultado = con.getResult();
            con.close();
            return resultado;

        }
    }
}
