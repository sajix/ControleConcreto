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
    
    class RepositorioTraco
    {
        Conexao con = new Conexao();
        public void inserir(Traco traco)
        {
            con.open();
            string ac = Convert.ToString(traco.FatorAC);
            ac = ac.Replace(",", ".");
            string consumo = Convert.ToString(traco.ConsumoCimento);
            consumo = consumo.Replace(",", ".");
            con.executeQuery("INSERT INTO tblTraco (cCodigoTraco, cUsina, cFCK, cFatorAC, cIdadeControle, cConsumoCimento, cConsistencia, cTolerancia) VALUES ('" + traco.CodigoTraco + "', '" + traco.Usina + "', " + traco.Fck + ", '" + ac + "', " + traco.IdadeControle + ", '" + consumo + "', " + traco.Consistencia + ", " + traco.Tolerancia + ")");
            con.close();
        }
        public void remover(string codigo)
        {
            con.open();
            con.executeQuery("DELETE FROM tblTraco WHERE (cCodigoTraco ='" + codigo + "')");
            con.close();
        }
        public DataTable buscar(string codigo, string campo)
        {
            con.open();
            con.executeQuery("SELECT * FROM tblTraco WHERE ("+ campo +" ='" + codigo + "')");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public void editar(string codigo, Traco traco)
        {
            con.open();
            string ac = Convert.ToString(traco.FatorAC);
            ac = ac.Replace(",", ".");
            string consumo = Convert.ToString(traco.ConsumoCimento);
            consumo = consumo.Replace(",", ".");
            con.executeQuery("UPDATE tblTraco SET cCodigoTraco = '" + traco.CodigoTraco + "', cUsina = '" + traco.Usina + "', cFCK =" + traco.Fck + ", cFatorAC ='" + ac + "', cIdadeControle =" + traco.IdadeControle + ", cConsumoCimento ='" + consumo + "', cConsistencia =" + traco.Consistencia + ", cTolerancia =" + traco.Tolerancia + " WHERE cCodigoTraco ='" + codigo+"'");
            con.close();
        }
        public DataTable buscarTudo()
        {
            con.open();
            con.executeQuery("SELECT * FROM tblTraco");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }

    }
}
