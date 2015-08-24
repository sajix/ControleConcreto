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
    class RepositorioLote
    {
        Conexao con = new Conexao();
        public void inserir(Lote lote)
        {
            con.open();
            string volume = Convert.ToString(lote.Volume);
            volume = volume.Replace(",", ".");
            string fckEstimado = Convert.ToString(lote.FckEstimado);
            fckEstimado = fckEstimado.Replace(",", ".");
            con.executeQuery("INSERT INTO tblLote (cIDLote, cDataControle, cFCK, cFckEstimado, cVolumeLote) VALUES (" + lote.IdSerie + ", '" + lote.DataControle + "', " + lote.Fck + ", '" + fckEstimado + "', '" + volume + "') ");
            con.close();
        }
        public void remover(int codigo)
        {
            con.open();
            con.executeQuery("DELETE FROM tblLote WHERE (cIDSerie =" + codigo + ")");
            con.close();
        }
        public Lote buscar(int codigo)
        {
            Lote lote = new Lote();
            con.open();
            con.executeQuery("SELECT * FROM tblLote WHERE (cIDLote =" + codigo + ")");
            DataTable resultado = con.getResult();
            if (resultado.Rows.Count > 0)
            {
                lote.IdSerie = Convert.ToInt32(resultado.Rows[0][0].ToString());
                lote.DataControle = Convert.ToDateTime(resultado.Rows[0][1].ToString());
                lote.Fck = Convert.ToInt32(resultado.Rows[0][2].ToString());
                if (resultado.Rows[0][3].ToString() == "")
                {
                    lote.FckEstimado = 0;
                }
                else
                {
                    lote.FckEstimado = Convert.ToDouble(resultado.Rows[0][3].ToString());
                }
                lote.Volume = Convert.ToDecimal(resultado.Rows[0][4].ToString());
            }
            con.close();
            return lote;
        }
        public void editar(Lote lote)
        {
            con.open();
            string volume = Convert.ToString(lote.Volume);
            volume = volume.Replace(",", ".");
            con.executeQuery("UPDATE tblLote SET cIDLote=" + lote.IdSerie + ", cDataControle = '" + lote.DataControle + "', cFCK = " + lote.Fck + ", cFckEstimado =" + lote.FckEstimado + ", cVolumeLote = '" + volume + "' WHERE cIDLote =" + lote.IdSerie);
            con.close();
        }
        public DataTable BuscaNLote()
        {
            con.open();
            con.executeQuery("SELECT TOP 1 cIDLote FROM dbo.tblLote ORDER BY cIDLote DESC");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public Lote [] BuscarTudo()
        {
            
            Lote [] tLote;
            con.open();
            con.executeQuery("SELECT * FROM tblLote");
            DataTable resultado = con.getResult();
            tLote = new Lote[resultado.Rows.Count];
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                Lote lote = new Lote();
                lote.IdSerie = Convert.ToInt32(resultado.Rows[i][0].ToString());
                lote.DataControle = Convert.ToDateTime(resultado.Rows[i][1].ToString());
                lote.Fck = Convert.ToInt32(resultado.Rows[i][2].ToString());
                if (resultado.Rows[i][3].ToString() == "")
                {
                    lote.FckEstimado = 0;
                }
                else
                {
                    lote.FckEstimado = Convert.ToDouble(resultado.Rows[i][3].ToString());
                }
                lote.Volume = Convert.ToDecimal(resultado.Rows[i][4].ToString());

                tLote[i] = lote;
            }
            con.close();
            return tLote;
        }
    }
}
