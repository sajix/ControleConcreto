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
    class RepositorioMoldagem
    {
        Conexao con = new Conexao();
        public void Inserir(Moldagem molde)
        {

            con.open();
            string volume = Convert.ToString(molde.VolumeBetonada);
            volume = volume.Replace(",", ".");
            string temperaturaAr = Convert.ToString(molde.TemperaturaAr);
            temperaturaAr = temperaturaAr.Replace(",", ".");
            string temperaturaCimento = Convert.ToString(molde.TemperaturaCimento);
            temperaturaCimento = temperaturaCimento.Replace(",", ".");
            if (molde.QuantidadeCP == 2)
            {
                con.executeQuery("INSERT INTO tblMoldagemCadastro (cIDSerie, cDataMoldagem, cHoraMoldagem, cLote, cIDTraco, cFCK, cIDObra, cIDEixo, cIDPeca, cQuantidadeCP, cIdadeControle, cIdadeA, cVolumeBetonada, cTemperaturaAr, cTemperaturaConcreto, cNotaFiscal) VALUES (" + molde.IdSerie + ", '" + molde.DataMoldagem.ToShortDateString() + "', '" + molde.HoraMoldagem.ToShortTimeString() + "', " + molde.Lote + ", '" + molde.IdTraco + "', " + molde.Fck + ", " + molde.IdObra + ", " + molde.IdEixo + ", " + molde.IdPeca + ", " + molde.QuantidadeCP + ", " + molde.IdadeControle + ", " + molde.IdadeA + ", '" + volume + "', '" + temperaturaAr + "', '" + temperaturaCimento + "', " + molde.Nota + ")");
            }
            else if (molde.QuantidadeCP == 4)
            {
                con.executeQuery("INSERT INTO tblMoldagemCadastro (cIDSerie, cDataMoldagem, cHoraMoldagem, cLote, cIDTraco, cFCK, cIDObra, cIDEixo, cIDPeca, cQuantidadeCP, cIdadeControle, cIdadeA, cIdadeB, cVolumeBetonada, cTemperaturaAr, cTemperaturaConcreto, cNotaFiscal) VALUES (" + molde.IdSerie + ", '" + molde.DataMoldagem + "', '" + molde.HoraMoldagem + "', " + molde.Lote + ", '" + molde.IdTraco + "', " + molde.Fck + ", " + molde.IdObra + ", " + molde.IdEixo + ", " + molde.IdPeca + ", " + molde.QuantidadeCP + ", " + molde.IdadeControle + ", " + molde.IdadeA + ", " + molde.IdadeB + ", '" + volume + "', '" + temperaturaAr + "', '" + temperaturaCimento + "', " + molde.Nota + ")");
            }
            else if (molde.QuantidadeCP == 6)
            {
                con.executeQuery("INSERT INTO tblMoldagemCadastro (cIDSerie, cDataMoldagem, cHoraMoldagem, cLote, cIDTraco, cFCK, cIDObra, cIDEixo, cIDPeca, cQuantidadeCP, cIdadeControle, cIdadeA, cIdadeB, cIdadeC, cVolumeBetonada, cTemperaturaAr, cTemperaturaConcreto, cNotaFiscal) VALUES (" + molde.IdSerie + ", '" + molde.DataMoldagem + "', '" + molde.HoraMoldagem + "', " + molde.Lote + ", '" + molde.IdTraco + "', " + molde.Fck + ", " + molde.IdObra + ", " + molde.IdEixo + ", " + molde.IdPeca + ", " + molde.QuantidadeCP + ", " + molde.IdadeControle + ", " + molde.IdadeA + ", " + molde.IdadeB + ", " + molde.IdadeC + ", '" + volume + "', '" + temperaturaAr + "', '" + temperaturaCimento + "', " + molde.Nota + ")");
            }

            con.close();
        }
        public void Remover(int codigo)
        {
            con.open();
            con.executeQuery("DELETE FROM tblMoldagemCadstro WHERE (cIDSerie =" + codigo + ")");
            con.close();
        }
        public Moldagem Buscar(int codigo)
        {
            Moldagem molde = new Moldagem();
            con.open();
            con.executeQuery("SELECT * FROM dbo.tblMoldagemCadastro WHERE (cIDSerie =" + codigo + ")");
            DataTable resultado = con.getResult();
            if (resultado.Rows.Count > 0)
            {
                molde.IdSerie = Convert.ToInt32(resultado.Rows[0][0].ToString());
                molde.DataMoldagem = Convert.ToDateTime(resultado.Rows[0][1].ToString());
                molde.HoraMoldagem = Convert.ToDateTime(resultado.Rows[0][2].ToString());
                molde.Lote = Convert.ToInt32(resultado.Rows[0][3].ToString());
                molde.IdTraco = Convert.ToInt32(resultado.Rows[0][4].ToString());
                molde.Fck = Convert.ToInt32(resultado.Rows[0][5].ToString());
                molde.IdObra = Convert.ToInt32(resultado.Rows[0][6].ToString());
                molde.IdEixo = Convert.ToInt32(resultado.Rows[0][7].ToString());
                molde.IdPeca = Convert.ToInt32(resultado.Rows[0][8].ToString());
                molde.QuantidadeCP = Convert.ToInt32(resultado.Rows[0][9].ToString());
                molde.IdadeControle = Convert.ToInt32(resultado.Rows[0][10].ToString());
                if (molde.QuantidadeCP == 2)
                {
                    molde.IdadeA = Convert.ToInt32(resultado.Rows[0][11].ToString());
                }
                else if (molde.QuantidadeCP == 4)
                {
                    molde.IdadeA = Convert.ToInt32(resultado.Rows[0][11].ToString());
                    molde.IdadeB = Convert.ToInt32(resultado.Rows[0][12].ToString());
                }
                else if (molde.QuantidadeCP == 6)
                {
                    molde.IdadeA = Convert.ToInt32(resultado.Rows[0][11].ToString());
                    molde.IdadeB = Convert.ToInt32(resultado.Rows[0][12].ToString());
                    molde.IdadeC = Convert.ToInt32(resultado.Rows[0][13].ToString());
                }
                molde.VolumeBetonada = Convert.ToDouble(resultado.Rows[0][14].ToString());
                if (resultado.Rows[0][15].ToString() != "")
                {
                    molde.TemperaturaAr = Convert.ToDecimal(resultado.Rows[0][15].ToString());
                }
                if (resultado.Rows[0][16].ToString() != "")
                {
                    molde.TemperaturaCimento = Convert.ToDecimal(resultado.Rows[0][16].ToString());
                }
                molde.Nota = Convert.ToInt32(resultado.Rows[0][17].ToString());
            }
            con.close();
            return molde;
        }

        public Boolean BuscarPeca(int codigo)
        {
            bool exist = new bool();
            con.open();
            con.executeQuery("SELECT * FROM tblMoldagemCadstro WHERE (cIDObra =" + codigo + ")");
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

        public void Editar(Moldagem molde)
        {
            con.open();
            string volume = Convert.ToString(molde.VolumeBetonada);
            volume = volume.Replace(",", ".");
            string temperaturaAr = Convert.ToString(molde.TemperaturaAr);
            temperaturaAr = temperaturaAr.Replace(",", ".");
            string temperaturaCimento = Convert.ToString(molde.TemperaturaCimento);
            temperaturaCimento = temperaturaCimento.Replace(",", ".");
            if (molde.QuantidadeCP == 2)
            {
                con.executeQuery("UPDATE tblMoldagemCadastro SET cDataMoldagem = '" + molde.DataMoldagem + "', cHoraMoldagem ='" + molde.HoraMoldagem + "', cLote =" + molde.Lote + " , cIDTraco =" + molde.IdTraco + ", cFCK =" + molde.Fck + ", cIDObra =" + molde.IdObra + ", cIDEixo =" + molde.IdEixo + ", cIDPeca =" + molde.IdPeca + ", cQuantidadeCP =" + molde.QuantidadeCP + ", cIdadeControle =" + molde.IdadeControle + ", cIdadeA =" + molde.IdadeA + ", cTemperaturaAr = '" + temperaturaAr + "', cTemperaturaConcreto = '" + temperaturaCimento + "', cNotaFiscal = " + molde.Nota + ", cVolumeBetonada ='" + volume + "' WHERE cIDSerie =" + molde.IdSerie);
            }
            else if (molde.QuantidadeCP == 4)
            {
                con.executeQuery("UPDATE tblMoldagemCadastro SET cDataMoldagem = '" + molde.DataMoldagem + "', cHoraMoldagem ='" + molde.HoraMoldagem + "', cLote =" + molde.Lote + " , cIDTraco =" + molde.IdTraco + ", cFCK =" + molde.Fck + ", cIDObra =" + molde.IdObra + ", cIDEixo =" + molde.IdEixo + ", cIDPeca =" + molde.IdPeca + ", cQuantidadeCP =" + molde.QuantidadeCP + ", cIdadeControle =" + molde.IdadeControle + ", cIdadeA =" + molde.IdadeA + ", cIdadeB =" + molde.IdadeB + ", cTemperaturaAr = '" + temperaturaAr + "', cTemperaturaConcreto = '" + temperaturaCimento + "', cNotaFiscal = " + molde.Nota + ", cVolumeBetonada ='" + volume + "' WHERE cIDSerie =" + molde.IdSerie);
            }
            else if (molde.QuantidadeCP == 6)
            {
                con.executeQuery("UPDATE tblMoldagemCadastro SET cDataMoldagem = '" + molde.DataMoldagem + "', cHoraMoldagem ='" + molde.HoraMoldagem + "', cLote =" + molde.Lote + " , cIDTraco =" + molde.IdTraco + ", cFCK =" + molde.Fck + ", cIDObra =" + molde.IdObra + ", cIDEixo =" + molde.IdEixo + ", cIDPeca =" + molde.IdPeca + ", cQuantidadeCP =" + molde.QuantidadeCP + ", cIdadeControle =" + molde.IdadeControle + ", cIdadeA =" + molde.IdadeA + ", cIdadeB =" + molde.IdadeB + ", cIdadeC =" + molde.IdadeC + ", cTemperaturaAr = '" + temperaturaAr + "', cTemperaturaConcreto = '" + temperaturaCimento + "', cNotaFiscal = " + molde.Nota + ", cVolumeBetonada ='" + volume + "' WHERE cIDSerie =" + molde.IdSerie);
            }
            con.close();
        }

        public void EditarData(string campo, int serie, int idade)
        {
            con.executeQuery("UPDATE tblMoldagemCadastro SET "+ campo +" = " + idade +" WHERE cIDSerie =" + serie);
        }
        public DataTable BuscaSerial()
        {
            con.open();
            con.executeQuery("SELECT TOP 1 cIDSerie FROM dbo.tblMoldagemCadastro ORDER BY cIDSerie DESC");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public Moldagem [] BuscarTudo()
        {
            
            con.open();
            con.executeQuery("SELECT * FROM dbo.tblMoldagemCadastro");
            DataTable resultado = con.getResult();
            Moldagem[] tMolde = new Moldagem[resultado.Rows.Count];
            for(int i = 0; i < resultado.Rows.Count; i++)
            {
                Moldagem molde = new Moldagem();
                molde.IdSerie = Convert.ToInt32(resultado.Rows[i][0].ToString());
                molde.DataMoldagem = Convert.ToDateTime(resultado.Rows[i][1].ToString());
                molde.HoraMoldagem = Convert.ToDateTime(resultado.Rows[i][2].ToString());
                molde.Lote = Convert.ToInt32(resultado.Rows[i][3].ToString());
                molde.IdTraco = Convert.ToInt32(resultado.Rows[i][4].ToString());
                molde.Fck = Convert.ToInt32(resultado.Rows[i][5].ToString());
                molde.IdObra = Convert.ToInt32(resultado.Rows[i][6].ToString());
                molde.IdEixo = Convert.ToInt32(resultado.Rows[i][7].ToString());
                molde.IdPeca = Convert.ToInt32(resultado.Rows[i][8].ToString());
                molde.QuantidadeCP = Convert.ToInt32(resultado.Rows[i][9].ToString());
                molde.IdadeControle = Convert.ToInt32(resultado.Rows[i][10].ToString());
                if (molde.QuantidadeCP == 2)
                {
                    molde.IdadeA = Convert.ToInt32(resultado.Rows[i][11].ToString());
                }
                else if (molde.QuantidadeCP == 4)
                {
                    molde.IdadeA = Convert.ToInt32(resultado.Rows[i][11].ToString());
                    molde.IdadeB = Convert.ToInt32(resultado.Rows[i][12].ToString());
                }
                else if (molde.QuantidadeCP == 6)
                {
                    molde.IdadeA = Convert.ToInt32(resultado.Rows[i][11].ToString());
                    molde.IdadeB = Convert.ToInt32(resultado.Rows[i][12].ToString());
                    molde.IdadeC = Convert.ToInt32(resultado.Rows[i][13].ToString());
                }
                molde.VolumeBetonada = Convert.ToDouble(resultado.Rows[i][14].ToString());
                if (resultado.Rows[0][15].ToString() != "")
                {
                    molde.TemperaturaAr = Convert.ToDecimal(resultado.Rows[i][15].ToString());
                }
                if (resultado.Rows[0][16].ToString() != "")
                {
                    molde.TemperaturaCimento = Convert.ToDecimal(resultado.Rows[i][16].ToString());
                }
                molde.Nota = Convert.ToInt32(resultado.Rows[i][17].ToString());
                tMolde[i] = molde;
            }
            con.close();
            return tMolde;
        }
    }
}
