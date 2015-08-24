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
    class RepositorioCodigoBarras
    {
        Conexao con = new Conexao();
        public void Inserir(CodigoBarras cb)
        {
            con.open();
            con.executeQuery("INSERT INTO tblCodigoBarras (cIDCodigoBarras, cIDSerie, cSituacao) VALUES ('" + cb.IdCodigoBarras + "', " + cb.IdSerie + ", '" + cb.Situacao + "') ");
            con.close();
        }
        public void Remover(int codigo)
        {
            con.open();
            con.executeQuery("DELETE FROM tblCodigoBarras WHERE (cIDSerie =" + codigo + ")");
            con.close();
        }
        public CodigoBarras Buscar(string codigo)
        {
            CodigoBarras cb = new CodigoBarras();
            con.open();
            con.executeQuery("SELECT * FROM tblCodigoBarras WHERE (cIDCodigoBarras ='" + codigo + "')");
            DataTable resultado = con.getResult();
            if (resultado.Rows.Count > 0)
            {
                cb.IdCodigoBarras = resultado.Rows[0][0].ToString();
                cb.IdSerie = Convert.ToInt32(resultado.Rows[0][1].ToString());
                if (resultado.Rows[0][2].ToString() == "False")
                {
                    cb.Situacao = 0;
                }
                else
                {
                    cb.Situacao = 1;
                }
            }
            con.close();
            return cb;
        }
        public void Editar(string novo, CodigoBarras cb)
        {
            con.open();
            con.executeQuery("UPDATE tblCodigoBarras SET cIDCodigoBarras = '" + novo + "', cIDSerie = '" + cb.IdSerie + "', cSituacao =" + cb.Situacao + " WHERE cIDCodigoBarras =" + cb.IdCodigoBarras);
            con.close();
        }
        public CodigoBarras [] BuscarTudo()
        {
            CodigoBarras[] aCB;
            CodigoBarras cb;
            con.open();
            con.executeQuery("SELECT * FROM tblCodigoBarras ORDER BY cIDSerie");
            DataTable resultado = con.getResult();
            aCB = new CodigoBarras[resultado.Rows.Count];
            if (resultado.Rows.Count > 0)
            {
                for (int i = 0; i < resultado.Rows.Count; i++)
                {
                    cb = new CodigoBarras();
                    cb.IdCodigoBarras = resultado.Rows[i][0].ToString();
                    cb.IdSerie = Convert.ToInt32(resultado.Rows[i][1].ToString());
                    if (resultado.Rows[i][2].ToString() == "False")
                    {
                        cb.Situacao = 0;
                    }
                    else
                    {
                        cb.Situacao = 1;
                    }
                    
                    aCB[i] = cb;
                }
            }
            con.close();
            return aCB;
        }
        public CodigoBarras[] BuscarSerie(string codigo)
        {
            CodigoBarras[] aCB;
            CodigoBarras cb;
            con.open();
            con.executeQuery("SELECT * FROM tblCodigoBarras WHERE (cIDSerie =" + codigo + ")");
            DataTable resultado = con.getResult();
            aCB = new CodigoBarras[resultado.Rows.Count];
            if (resultado.Rows.Count > 0)
            {
                for (int i = 0; i < resultado.Rows.Count; i++)
                {
                    cb = new CodigoBarras();
                    cb.IdCodigoBarras = resultado.Rows[i][0].ToString();
                    cb.IdSerie = Convert.ToInt32(resultado.Rows[i][1].ToString());
                    string teste = resultado.Rows[i][2].ToString();
                    if (resultado.Rows[i][2].ToString() == "False")
                    {
                        cb.Situacao = 0;
                    }
                    else
                    {
                        cb.Situacao = 1;
                    }
                    aCB[i] = cb;
                }
            }
            con.close();
            return aCB;
        }

    }
}
