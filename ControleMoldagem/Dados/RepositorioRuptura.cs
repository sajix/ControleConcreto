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
    class RepositorioRuptura
    {
        Conexao con = new Conexao();
        public void Inserir(Ruptura ruptura)
        {
            con.open();
            string diamentro = Convert.ToString(ruptura.DiametroCP);
            diamentro = diamentro.Replace(",", ".");
            string altura = Convert.ToString(ruptura.AlturaCP);
            altura = altura.Replace(",", ".");
            string correcao = Convert.ToString(ruptura.Correcao);
            correcao = correcao.Replace(",", ".");
            con.executeQuery("INSERT INTO tblRuptura (cIDCodigoBarras, cDaraRuptura, cHora, cIDSerie, cDiametroCP, cAlturaCP, cCorrecao, cCarga) VALUES ('" + ruptura.IdCodigoBarras + "', '" + ruptura.DataRuptura + "', '" + ruptura.Hora + "', " + ruptura.IdSerie + ", '" + diamentro + "', '" + altura + "', '" + correcao + "', '" + ruptura.Carga + "')");
            con.close();
        }
        public void Remover(string codigo)
        {
            con.open();
            con.executeQuery("DELETE FROM tblRuptura WHERE (cIDCodigoBarras =" + codigo + ")");
            con.close();
        }
        public Ruptura Buscar(string codigo)
        {
            Ruptura ruptura = new Ruptura();
            con.open();
            con.executeQuery("SELECT * FROM tblRuptura WHERE (cIDCodigoBarras =" + codigo + ")");
            DataTable resultado = con.getResult();
            ruptura.IdCodigoBarras = resultado.Rows[0][0].ToString();
            ruptura.DataRuptura = Convert.ToDateTime(resultado.Rows[0][1].ToString());
            ruptura.Hora = Convert.ToDateTime(resultado.Rows[0][2].ToString());
            ruptura.IdSerie = Convert.ToInt32(resultado.Rows[0][3].ToString());
            ruptura.DiametroCP = Convert.ToDecimal(resultado.Rows[0][4].ToString());
            ruptura.AlturaCP = Convert.ToDecimal(resultado.Rows[0][5].ToString());
            ruptura.Correcao = Convert.ToDecimal(resultado.Rows[0][6].ToString());
            ruptura.Carga = Convert.ToDecimal(resultado.Rows[0][7].ToString());
            con.close();
            return ruptura;
        }
        public Ruptura [] BuscarSerie(int serie)
        {
            
            con.open();
            con.executeQuery("SELECT * FROM tblRuptura WHERE (cIDSerie =" + serie + ")");
            DataTable resultado = con.getResult();
            Ruptura[] ruptura = new Ruptura[resultado.Rows.Count];
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                Ruptura rup = new Ruptura();
                rup.IdCodigoBarras = resultado.Rows[i][0].ToString();
                rup.DataRuptura = Convert.ToDateTime(resultado.Rows[i][1].ToString());
                rup.Hora = Convert.ToDateTime(resultado.Rows[i][2].ToString());
                rup.IdSerie = Convert.ToInt32(resultado.Rows[i][3].ToString());
                rup.DiametroCP = Convert.ToDecimal(resultado.Rows[i][4].ToString());
                rup.AlturaCP = Convert.ToDecimal(resultado.Rows[i][5].ToString());
                rup.Correcao = Convert.ToDecimal(resultado.Rows[i][6].ToString());
                rup.Carga = Convert.ToDecimal(resultado.Rows[i][7].ToString());
                ruptura[i] = rup;
            }
            con.close();
            return ruptura;
        }
        public void Editar(Ruptura ruptura)
        {
            con.open();
            con.executeQuery("UPDATE tblRuptura SET cIDCodigoBarras = '" + ruptura.IdCodigoBarras + "', cDaraRuptura = '" + ruptura.DataRuptura + "', cHora =" + ruptura.Hora + ", cIDSerie =" + ruptura.IdSerie + " , cDiametroCP =" + ruptura.DiametroCP + ", cAlturaCP ="+ ruptura.AlturaCP + ", cCorrocao =" + ruptura.Correcao + ", cCarga =" + ruptura.Carga + " WHERE cIDCodigoBarras =" + ruptura.IdCodigoBarras);
            con.close();
        }
        public decimal BuscaCorrecao(decimal alturaDiametro)
        {
            decimal correcao;
            string altDia = Convert.ToString(alturaDiametro);
            altDia = altDia.Replace(",", ".");
            con.open();
            con.executeQuery("SELECT * FROM tblFatorCorrecao WHERE (cAlturaDiametro = '" + altDia + "')");
            DataTable resultado = con.getResult();
            con.close();
            correcao = Convert.ToDecimal(resultado.Rows[0][1].ToString());
            return correcao;
        }
        public Ruptura [] BuscarTudo()
        {
            
            con.open();
            con.executeQuery("SELECT * FROM tblRuptura");
            DataTable resultado = con.getResult();
            Ruptura[] tRupt = new Ruptura[resultado.Rows.Count];
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                Ruptura ruptura = new Ruptura();
                ruptura.IdCodigoBarras = resultado.Rows[i][0].ToString();
                ruptura.DataRuptura = Convert.ToDateTime(resultado.Rows[i][1].ToString());
                ruptura.Hora = Convert.ToDateTime(resultado.Rows[i][2].ToString());
                ruptura.IdSerie = Convert.ToInt32(resultado.Rows[i][3].ToString());
                ruptura.DiametroCP = Convert.ToDecimal(resultado.Rows[i][4].ToString());
                ruptura.AlturaCP = Convert.ToDecimal(resultado.Rows[i][5].ToString());
                ruptura.Correcao = Convert.ToDecimal(resultado.Rows[i][6].ToString());
                ruptura.Carga = Convert.ToDecimal(resultado.Rows[i][7].ToString());
                tRupt[i] = ruptura;
            }
            con.close();
            return tRupt;
        }
    }
}
