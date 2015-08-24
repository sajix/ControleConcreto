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
    class RepositorioRelatorio
    {
        Conexao con = new Conexao();
        public DataTable AgendaRuptura()
        {
            con.open();
            con.executeQuery("SELECT cIDSerie, cDataMoldagem, cFCK, cIDObra, cIDEixo, cIDPeca, cidadeA, cidadeB, cidadeC FROM tblMoldagemCadastro");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }

        public DataTable RelatorioRuptura()
        {
            con.open();
            con.executeQuery("SELECT tblResistencia.cIDSerie, tblMoldagemCadastro.cLote,tblMoldagemCadastro.cDataMoldagem, tblResistencia.cRupturaA1, tblResistencia.cRupturaA2, tblResistencia.cRupturaB1, tblResistencia.cRupturaB2, tblResistencia.cRupturaC1, tblResistencia.cRupturaC2, tblMoldagemCadastro.cFCK, tblMoldagemCadastro.cidadeA, tblMoldagemCadastro.cidadeB, tblMoldagemCadastro.cIdadeC, tblObra.cNomeObra, tblEixo.cNomeEixo, tblPeca.cNomePeca FROM tblResistencia INNER JOIN tblMoldagemCadastro ON tblResistencia.cIDSerie=tblMoldagemCadastro.cIDSerie JOIN tblObra ON tblMoldagemCadastro.cIDObra=tblObra.cIDObra JOIN tblEixo ON tblMoldagemCadastro.cIDEixo = tblEixo.cIDEixo AND tblMoldagemCadastro.cIDObra = tblEixo.cIDObra JOIN tblPeca ON tblMoldagemCadastro.cIDPeca = tblPeca.cIDPeca AND tblMoldagemCadastro.cIDEixo = tblPeca.cIDEixo AND tblMoldagemCadastro.cIDObra = tblPeca.cIDObra");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }

        public DataTable RelatorioLote(int lote)
        {
            con.open();
            con.executeQuery("SELECT tblLote.cIDLote, tblMoldagemCadastro.cIDSerie, tblMoldagemCadastro.cNotaFiscal, tblMoldagemCadastro.cidadeA, tblMoldagemCadastro.cIdadeB, tblMoldagemCadastro.cIdadeC, tblTraco.cConsistencia, tblResistencia.cRupturaA1, tblResistencia.cRupturaA2, tblResistencia.cRupturaB1, tblResistencia.cRupturaB2, tblResistencia.cRupturaC1, tblResistencia.cRupturaC2 FROM tblLote INNER JOIN tblMoldagemCadastro ON tblLote.cIDLote = tblMoldagemCadastro.cLote JOIN tblTraco ON tblMoldagemCadastro.cIDTraco = tblTraco.cIDTraco JOIN tblResistencia ON tblMoldagemCadastro.cIDSerie = tblResistencia.cIDSerie WHERE tblLote.cIDLote = "+ lote);
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public DataTable RelatorioLoteContA(int lote)
        {
            con.open();
            con.executeQuery("SELECT COUNT (*) FROM (SELECT tblLote.cIDLote, tblMoldagemCadastro.cIDSerie, tblMoldagemCadastro.cNotaFiscal, tblMoldagemCadastro.cidadeA, tblMoldagemCadastro.cIdadeB, tblMoldagemCadastro.cIdadeC, tblTraco.cConsistencia, tblResistencia.cRupturaA1, tblResistencia.cRupturaA2, tblResistencia.cRupturaB1, tblResistencia.cRupturaB2, tblResistencia.cRupturaC1, tblResistencia.cRupturaC2 FROM tblLote INNER JOIN tblMoldagemCadastro ON tblLote.cIDLote = tblMoldagemCadastro.cLote JOIN tblTraco ON tblMoldagemCadastro.cIDTraco = tblTraco.cIDTraco JOIN tblResistencia ON tblMoldagemCadastro.cIDSerie = tblResistencia.cIDSerie WHERE tblLote.cIDLote ="+ lote +" ) AS A WHERE cidadeA IS NOT NULL");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public DataTable RelatorioLoteContB(int lote)
        {
            con.open();
            con.executeQuery("SELECT COUNT (*) FROM (SELECT tblLote.cIDLote, tblMoldagemCadastro.cIDSerie, tblMoldagemCadastro.cNotaFiscal, tblMoldagemCadastro.cidadeA, tblMoldagemCadastro.cIdadeB, tblMoldagemCadastro.cIdadeC, tblTraco.cConsistencia, tblResistencia.cRupturaA1, tblResistencia.cRupturaA2, tblResistencia.cRupturaB1, tblResistencia.cRupturaB2, tblResistencia.cRupturaC1, tblResistencia.cRupturaC2 FROM tblLote INNER JOIN tblMoldagemCadastro ON tblLote.cIDLote = tblMoldagemCadastro.cLote JOIN tblTraco ON tblMoldagemCadastro.cIDTraco = tblTraco.cIDTraco JOIN tblResistencia ON tblMoldagemCadastro.cIDSerie = tblResistencia.cIDSerie WHERE tblLote.cIDLote = " + lote + ") AS A WHERE cIdadeB IS NOT NULL");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public DataTable RelatorioLoteContC(int lote)
        {
            con.open();
            con.executeQuery("SELECT COUNT (*) FROM (SELECT tblLote.cIDLote, tblMoldagemCadastro.cIDSerie, tblMoldagemCadastro.cNotaFiscal, tblMoldagemCadastro.cidadeA, tblMoldagemCadastro.cIdadeB, tblMoldagemCadastro.cIdadeC, tblTraco.cConsistencia, tblResistencia.cRupturaA1, tblResistencia.cRupturaA2, tblResistencia.cRupturaB1, tblResistencia.cRupturaB2, tblResistencia.cRupturaC1, tblResistencia.cRupturaC2 FROM tblLote INNER JOIN tblMoldagemCadastro ON tblLote.cIDLote = tblMoldagemCadastro.cLote JOIN tblTraco ON tblMoldagemCadastro.cIDTraco = tblTraco.cIDTraco JOIN tblResistencia ON tblMoldagemCadastro.cIDSerie = tblResistencia.cIDSerie WHERE tblLote.cIDLote = " + lote + ") AS A WHERE cIdadeC IS NOT NULL");
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }
        public DataTable RelatorioLoteSerie(int serie)
        {
            con.open();
            con.executeQuery("SELECT tblMoldagemCadastro.cIDSerie, tblTraco.cCodigoTraco, tblTraco.cUsina,  tblTraco.cFCK, tblTraco.cFatorAC, tblTraco.cIdadeControle, tblTraco.cConsumoCimento, tblTraco.cConsistencia, tblTraco.cTolerancia, tblObra.cNomeObra, tblEixo.cNomeEixo, tblPeca.cNomePeca, tblMoldagemCadastro.cDataMoldagem FROM tblMoldagemCadastro INNER JOIN tblTraco ON tblMoldagemCadastro.cIDTraco = tblTraco.cIDTraco JOIN tblObra ON tblMoldagemCadastro.cIDObra=tblObra.cIDObra JOIN tblEixo ON tblMoldagemCadastro.cIDEixo = tblEixo.cIDEixo AND tblMoldagemCadastro.cIDObra = tblEixo.cIDObra JOIN tblPeca ON tblMoldagemCadastro.cIDPeca = tblPeca.cIDPeca AND tblMoldagemCadastro.cIDEixo = tblPeca.cIDEixo AND tblMoldagemCadastro.cIDObra = tblPeca.cIDObra WHERE tblMoldagemCadastro.cIDSerie =" + serie);
            DataTable resultado = con.getResult();
            con.close();
            return resultado;
        }

    }
}
