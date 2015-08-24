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
    class RepositorioObra
    {
        Conexao con = new Conexao();
        public void Inserir(Obra obra)
        {
            con.open();
            con.executeQuery("INSERT INTO tblObra (cNomeObra) VALUES ('" + obra.NomeObra + "') ");
            con.close();
        }
        public void Remover(string nome)
        {
            con.open();
            con.executeQuery("DELETE FROM tblObra WHERE (cNomeObra =" + nome + ")");
            con.close();
        }
        public DataTable Buscar(string nome, string campo)
        {
            con.open();
            con.executeQuery("SELECT * FROM tblObra WHERE ("+ campo +" ='" + nome + "')");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public void Editar(string nome, Obra obra)
        {
            con.open();
            con.executeQuery("UPDATE tblObra SET cNomeObra = '" + obra.NomeObra + "' WHERE cNomeObra ='" + nome + "'");
            con.close();
        }
        public int NRegistros()
        {
            int registros = new int();
            con.open();
            con.executeQuery("SELECT COUNT(*) FROM tblObra");
            DataTable resultado = con.getResult();
            registros = Convert.ToInt32(resultado.Rows[0][0].ToString());
            con.close();
            return registros;
        }
        public DataTable BuscarTudo()
        {
            con.open();
            con.executeQuery("SELECT * FROM tblObra");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;

        }
    }
}
