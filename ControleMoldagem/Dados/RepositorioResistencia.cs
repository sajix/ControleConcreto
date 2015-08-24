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
    class RepositorioResistencia
    {
        Conexao con = new Conexao();
        public void Inserir(int serie)
        {
            con.open();
            con.executeQuery("INSERT INTO tblResistencia (cIDSerie) VALUES (" + serie + ")"); //, cRupturaA1, cRupturaA2, cRupturaB1, cRupturaB2, cRupturaC1, cRupturaC2
            con.close();
        }
        public void Remover(int serie)
        {
            con.open();
            con.executeQuery("DELETE FROM tblResistencia WHERE (cIDSerie =" + serie + ")");
            con.close();
        }
        public Resistencia Buscar(int serie)
        {
            Resistencia resist = new Resistencia();
            con.open();
            con.executeQuery("SELECT * FROM tblResistencia WHERE (cIDSerie =" + serie + ")");
            DataTable resultado = con.getResult();
            if (resultado.Rows.Count > 0)
            {
                resist.IdSerie = Convert.ToInt32(resultado.Rows[0][0].ToString());
                if (resultado.Rows[0][1].ToString() == "")
                {
                    resist.RA1 = 0;
                }
                else
                {
                    resist.RA1 = Convert.ToDecimal(resultado.Rows[0][1].ToString());
                }
                if (resultado.Rows[0][2].ToString() == "")
                {
                    resist.RA2 = 0;
                }
                else
                {
                    resist.RA2 = Convert.ToDecimal(resultado.Rows[0][2].ToString());
                }
                if (resultado.Rows[0][3].ToString() == "")
                {
                    resist.RB1 = 0;
                }
                else
                {
                    resist.RB1 = Convert.ToDecimal(resultado.Rows[0][3].ToString());
                }
                if (resultado.Rows[0][4].ToString() == "")
                {
                    resist.RB2 = 0;
                }
                else
                {
                    resist.RB2 = Convert.ToDecimal(resultado.Rows[0][4].ToString());
                }
                if (resultado.Rows[0][5].ToString() == "")
                {
                    resist.RC1 = 0;
                }
                else
                {
                    resist.RC1 = Convert.ToDecimal(resultado.Rows[0][5].ToString());
                }
                if (resultado.Rows[0][6].ToString() == "")
                {
                    resist.RC2 = 0;
                }
                else
                {
                    resist.RC2 = Convert.ToDecimal(resultado.Rows[0][6].ToString());
                }
            }
            con.close();
            return resist;
        }
        public void Editar(int serie, string ruptura, decimal valor )
        {
            con.open();
            con.executeQuery("UPDATE tblResistencia SET "+ ruptura + " = '" + valor + "' WHERE cIDSerie =" + serie);
            con.close();
        }
        public Resistencia [] BuscarTudo()
        {
            
            con.open();
            con.executeQuery("SELECT * FROM tblResistencia");
            DataTable resultado = con.getResult();
            Resistencia[] tResist = new Resistencia[resultado.Rows.Count];
            if (resultado.Rows.Count > 0)
            {
                for (int i = 0; i < resultado.Rows.Count; i++)
                {
                    Resistencia resist = new Resistencia();
                    resist.IdSerie = Convert.ToInt32(resultado.Rows[i][0].ToString());
                    if (resultado.Rows[i][1].ToString() == "")
                    {
                        resist.RA1 = 0;
                    }
                    else
                    {
                        resist.RA1 = Convert.ToDecimal(resultado.Rows[i][1].ToString());
                    }
                    if (resultado.Rows[i][2].ToString() == "")
                    {
                        resist.RA2 = 0;
                    }
                    else
                    {
                        resist.RA2 = Convert.ToDecimal(resultado.Rows[i][2].ToString());
                    }
                    if (resultado.Rows[i][3].ToString() == "")
                    {
                        resist.RB1 = 0;
                    }
                    else
                    {
                        resist.RB1 = Convert.ToDecimal(resultado.Rows[i][3].ToString());
                    }
                    if (resultado.Rows[i][4].ToString() == "")
                    {
                        resist.RB2 = 0;
                    }
                    else
                    {
                        resist.RB2 = Convert.ToDecimal(resultado.Rows[i][4].ToString());
                    }
                    if (resultado.Rows[i][5].ToString() == "")
                    {
                        resist.RC1 = 0;
                    }
                    else
                    {
                        resist.RC1 = Convert.ToDecimal(resultado.Rows[i][5].ToString());
                    }
                    if (resultado.Rows[i][6].ToString() == "")
                    {
                        resist.RC2 = 0;
                    }
                    else
                    {
                        resist.RC2 = Convert.ToDecimal(resultado.Rows[i][6].ToString());
                    }
                    tResist[i] = resist;
                }
            }
            con.close();
            return tResist;
        }
    }
}
