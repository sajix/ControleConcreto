using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using ControleMoldagem.Dados;
using ControleMoldagem.Entidades;
using ControleMoldagem.Regras;
using System.Windows.Forms;

namespace ControleMoldagem
{
    class ExltoDB
    {
        Conexao con = new Conexao();
        CadastroTraco cTraco = new CadastroTraco();
        public void ExportarSerie(ProgressBar pBar)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\BANCO_DADOS_CONCRETO_VLT_140530.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "Moldagem";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            Range excelCell;
            excelCell = (Range)excelWorksheet.get_Range("E2");
            string teste = (string)(excelWorksheet.Cells[2, 5] as Range).Value;
            //MessageBox.Show(teste, teste, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            pBar.Maximum = 688;
            pBar.Minimum = 2;
            con.open();
            for (int i = 2; i < 688; i++)
            {
                pBar.Value = i;
                string serie = Convert.ToString((object)(excelWorksheet.Cells[i, 1] as Range).Value);
                string data = Convert.ToString((DateTime)(excelWorksheet.Cells[i, 3] as Range).Value);
                string hora = Convert.ToString((object)(excelWorksheet.Cells[i, 4] as Range).Value);
                string lote = (string)(excelWorksheet.Cells[i, 2] as Range).Value;
                string codigoTraco = (string)(excelWorksheet.Cells[i, 5] as Range).Value;
                Traco [] traco = cTraco.BuscarTraco(codigoTraco, "cCodigoTraco");
                int idTraco = traco[0].IdTraco;
                string fck = Convert.ToString((object)(excelWorksheet.Cells[i, 6] as Range).Value);
                string obra = "4";//(string)(excelWorksheet.Cells[i, 12] as Range).Value;
                string eixo = "1";//(string)(excelWorksheet.Cells[i, 13] as Range).Value;
                string peca = "1";//(string)(excelWorksheet.Cells[i, 14] as Range).Value;
                string quantidade = Convert.ToString((object)(excelWorksheet.Cells[i, 15] as Range).Value);
                string idadeA = Convert.ToString((object)(excelWorksheet.Cells[i, 16] as Range).Value);
                string idadeB = Convert.ToString((object)(excelWorksheet.Cells[i, 17] as Range).Value);
                string idadeC = Convert.ToString((object)(excelWorksheet.Cells[i, 18] as Range).Value);
                string volume = Convert.ToString((object)(excelWorksheet.Cells[i, 28] as Range).Value);
                string tempAr = Convert.ToString((object)(excelWorksheet.Cells[i, 10] as Range).Value);
                string tempConc = Convert.ToString((object)(excelWorksheet.Cells[i, 11] as Range).Value);
                string nota = Convert.ToString((object)(excelWorksheet.Cells[i, 8] as Range).Value);
                string idade = "28";
                if (nota == "")
                {
                    nota = "0000";
                }
                fck = fck.Replace(",", ".");
                volume = volume.Replace(",", ".");
                tempAr = tempAr.Replace(",", ".");
                tempConc = tempConc.Replace(",", ".");
                if (Convert.ToInt32(quantidade) == 2)
                {
                    con.executeQuery("INSERT INTO tblMoldagemCadastro (cIDSerie, cDataMoldagem, cHoraMoldagem, cLote, cIDTraco, cFCK, cIDObra, cIDEixo, cIDPeca, cQuantidadeCP, cIdadeControle, cIdadeA, cVolumeBetonada, cTemperaturaAr, cTemperaturaConcreto, cNotaFiscal) VALUES (" + serie + ", '" + data + "', '" + hora + "', " + lote + ", " + idTraco + ", " + fck + ", " + obra + ", " + eixo + ", " + peca + ", " + quantidade + ", " + idade + ", " + idadeA + ", '" + volume + "', " + "null" + ", " + "null" + ", " + nota + ")");
                }
                else if (Convert.ToInt32(quantidade) == 4)
                {
                    con.executeQuery("INSERT INTO tblMoldagemCadastro (cIDSerie, cDataMoldagem, cHoraMoldagem, cLote, cIDTraco, cFCK, cIDObra, cIDEixo, cIDPeca, cQuantidadeCP, cIdadeControle, cIdadeA, cIdadeB, cVolumeBetonada, cTemperaturaAr, cTemperaturaConcreto, cNotaFiscal) VALUES (" + serie + ", '" + data + "', '" + hora + "', " + lote + ", '" + idTraco + "', " + fck + ", " + obra + ", " + eixo + ", " + peca + ", " + quantidade + ", " + idade + ", " + idadeA + ", " + idadeB + ", '" + volume + "', " + "null" + ", " + "null" + ", " + nota + ")");
                }
                else if (Convert.ToInt32(quantidade) == 6)
                {
                    con.executeQuery("INSERT INTO tblMoldagemCadastro (cIDSerie, cDataMoldagem, cHoraMoldagem, cLote, cIDTraco, cFCK, cIDObra, cIDEixo, cIDPeca, cQuantidadeCP, cIdadeControle, cIdadeA, cIdadeB, cIdadeC, cVolumeBetonada, cTemperaturaAr, cTemperaturaConcreto, cNotaFiscal) VALUES (" + serie + ", '" + data + "', '" + hora + "', " + lote + ", '" + idTraco + "', " + fck + ", " + obra + ", " + eixo + ", " + peca + ", " + quantidade + ", " + idade + ", " + idadeA + ", " + idadeB + ", " + idadeC + ", '" + volume + "', " + "null" + ", " + "null" + ", " + nota + ")");
                }
                con.executeQuery("INSERT INTO tblResistencia (cIDSerie) VALUES (" + serie + ")");
            }
            
            con.close();
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }
        public void ExportarLote()
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\BANCO_DADOS_CONCRETO_VLT_140530.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "Lote";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            con.open();
            for (int i = 2; i < 232; i++)
            {
                string lote = (string)(excelWorksheet.Cells[i, 1] as Range).Value;
                DateTime data = (DateTime)(excelWorksheet.Cells[i, 5] as Range).Value;
                string volume = "0";
                string fck = (string)(excelWorksheet.Cells[i, 2] as Range).Value;
                fck = fck.Replace(",", ".");
                string fckEstimado = null;
                if ((object)(excelWorksheet.Cells[i, 3] as Range).Value != "")
                {
                    fckEstimado = Convert.ToString((object)(excelWorksheet.Cells[i, 3] as Range).Value);
                    fckEstimado = fckEstimado.Replace(",", ".");
                }
                if (fckEstimado == "")
                {
                    con.executeQuery("INSERT INTO tblLote (cIDLote, cDataControle, cFCK, cFckEstimado, cVolumeLote) VALUES (" + lote + ", '" + data + "', " + fck + ", " + "null" + ", '" + volume + "')");
                }
                else
                {
                    con.executeQuery("INSERT INTO tblLote (cIDLote, cDataControle, cFCK, cFckEstimado, cVolumeLote) VALUES (" + lote + ", '" + data + "', " + fck + ", '" + fckEstimado + "', '" + volume + "')");
                }
            }
            con.close();
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }
        public void ExportarTraco()
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\BANCO_DADOS_CONCRETO_VLT_140530.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "Traço";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            con.open();
            for (int i = 2; i < 11; i++)
            {
                string traco = (string)(excelWorksheet.Cells[i, 1] as Range).Value;
                string fck = (string)(excelWorksheet.Cells[i, 2] as Range).Value;
                string fatorAC = Convert.ToString((double)(excelWorksheet.Cells[i, 3] as Range).Value);
                fatorAC = fatorAC.Replace(",", ".");
                string usina = (string)(excelWorksheet.Cells[i, 11] as Range).Value;
                string consumo = Convert.ToString((double)(excelWorksheet.Cells[i, 4] as Range).Value);
                consumo = consumo.Replace(",", ".");
                string consistencia = Convert.ToString((double)(excelWorksheet.Cells[i, 12] as Range).Value);
                consistencia = consistencia.Replace(",", ".");
                string tolerancia = "20";
                string idade = (string)(excelWorksheet.Cells[i, 13] as Range).Value;
                con.executeQuery("INSERT INTO tblTraco (cCodigoTraco, cUsina, cFCK, cFatorAC, cIdadeControle, cConsumoCimento, cConsistencia, cTolerancia) VALUES ('" + traco + "', '" + usina + "', " + fck + ", '" + fatorAC + "', " + idade + ", '" + consumo + "', " + consistencia + ", " + tolerancia + ")");
            }
            con.close();
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        public void ExportarRuptura(ProgressBar pBar)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\BANCO_DADOS_CONCRETO_VLT_140530.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "Ruptura";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            pBar.Maximum = 2948;
            pBar.Minimum = 2;
            con.open();
            for (int i = 2; i < 2948; i++)
            {
                pBar.Value = i;
                string codigoBarra = Convert.ToString((object)(excelWorksheet.Cells[i, 1] as Range).Value);
                DateTime data = (DateTime)(excelWorksheet.Cells[i, 3] as Range).Value;
                double timeSpan = ((double)(excelWorksheet.Cells[i, 4] as Range).Value)*24;
                int hora = (int)timeSpan;
                int min = (int)((timeSpan - Convert.ToDouble(hora)) * 60);
                string horario = hora + ":" + min;
                string serie = Convert.ToString((object)(excelWorksheet.Cells[i, 2] as Range).Value);
                string diametro = Convert.ToString((object)(excelWorksheet.Cells[i, 9] as Range).Value);
                diametro = diametro.Replace(",", ".");
                string altura = Convert.ToString((object)(excelWorksheet.Cells[i, 8] as Range).Value);
                altura = altura.Replace(",", ".");
                string correcao = Convert.ToString((object)(excelWorksheet.Cells[i, 10] as Range).Value);
                correcao = correcao.Replace(",", ".");
                string carga = Convert.ToString((object)(excelWorksheet.Cells[i, 5] as Range).Value);
                carga = carga.Replace(",", ".");
                con.executeQuery("INSERT INTO tblRuptura (cIDCodigoBarras, cDaraRuptura, cHora, cIDSerie, cDiametroCP, cAlturaCP, cCorrecao, cCarga) VALUES ('" + codigoBarra + "', '" + data + "', '" + horario + "', " + serie + ", '" + diametro + "', '" + altura + "', '" + correcao + "', '" + carga + "')");
            }
            con.close();
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }
        public void ExportarCodigoBarras(ProgressBar pBar)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\BANCO_DADOS_CONCRETO_VLT_140530.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "CodBar";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            pBar.Maximum = 693;
            pBar.Minimum = 2;
            con.open();
            for (int i = 2; i < 693; i++)
            {
                pBar.Value = i;
                for (int j = 2; j < 8; j++)
                {
                    string codigoBarra = Convert.ToString((object)(excelWorksheet.Cells[i, j] as Range).Value);
                    string serie = Convert.ToString((object)(excelWorksheet.Cells[i, 1] as Range).Value);
                    string situacao;
                    if ((excelWorksheet.Cells[i, j] as Range).Interior.Color != System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White))
                    {
                        situacao = "1";
                    }
                    else
                    {
                        situacao = "0";
                    }
                    if (codigoBarra == "")
                    {

                    }
                    else
                    {
                        con.executeQuery("INSERT INTO tblCodigoBarras (cIDCodigoBarras, cIDSerie, cSituacao) VALUES ('" + codigoBarra + "', " + serie + ", '" + situacao + "') ");
                    }
                }
            }
            con.close();
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        public void ExportarResistencia(ProgressBar pBar)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\BANCO_DADOS_CONCRETO_VLT_140530.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "Moldagem";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            pBar.Maximum = 688;
            pBar.Minimum = 2;
            con.open();
            for (int i = 2; i < 688; i++)
            {
                pBar.Value = i;
                if (Convert.ToString((object)(excelWorksheet.Cells[i, 22] as Range).Value) != "")
                {
                    string resistencia = Convert.ToString((object)(excelWorksheet.Cells[i, 22] as Range).Value);
                    resistencia = resistencia.Replace(",", ".");
                    con.executeQuery("UPDATE tblResistencia SET " + "cRupturaA1" + " = '" + resistencia + "' WHERE cIDSerie =" + (object)(excelWorksheet.Cells[i, 1] as Range).Value);
                }
                if (Convert.ToString((object)(excelWorksheet.Cells[i, 23] as Range).Value) != "")
                {
                    string resistencia = Convert.ToString((object)(excelWorksheet.Cells[i, 23] as Range).Value);
                    resistencia = resistencia.Replace(",", ".");
                    con.executeQuery("UPDATE tblResistencia SET " + "cRupturaA2" + " = '" + resistencia + "' WHERE cIDSerie =" + (object)(excelWorksheet.Cells[i, 1] as Range).Value);
                }
                if (Convert.ToString((object)(excelWorksheet.Cells[i, 24] as Range).Value) != "")
                {
                    string resistencia = Convert.ToString((object)(excelWorksheet.Cells[i, 24] as Range).Value);
                    resistencia = resistencia.Replace(",", ".");
                    con.executeQuery("UPDATE tblResistencia SET " + "cRupturaB1" + " = '" + resistencia + "' WHERE cIDSerie =" + (object)(excelWorksheet.Cells[i, 1] as Range).Value);
                }
                if (Convert.ToString((object)(excelWorksheet.Cells[i, 25] as Range).Value) != "")
                {
                    string resistencia = Convert.ToString((object)(excelWorksheet.Cells[i, 25] as Range).Value);
                    resistencia = resistencia.Replace(",", ".");
                    con.executeQuery("UPDATE tblResistencia SET " + "cRupturaB2" + " = '" + resistencia + "' WHERE cIDSerie =" + (object)(excelWorksheet.Cells[i, 1] as Range).Value);
                }
                if (Convert.ToString((object)(excelWorksheet.Cells[i, 26] as Range).Value) != "")
                {
                    string resistencia = Convert.ToString((object)(excelWorksheet.Cells[i, 26] as Range).Value);
                    resistencia = resistencia.Replace(",", ".");
                    con.executeQuery("UPDATE tblResistencia SET " + "cRupturaC1" + " = '" + resistencia + "' WHERE cIDSerie =" + (object)(excelWorksheet.Cells[i, 1] as Range).Value);
                }
                if (Convert.ToString((object)(excelWorksheet.Cells[i, 27] as Range).Value) != "")
                {
                    string resistencia = Convert.ToString((object)(excelWorksheet.Cells[i, 27] as Range).Value);
                    resistencia = resistencia.Replace(",", ".");
                    con.executeQuery("UPDATE tblResistencia SET " + "cRupturaC2" + " = '" + resistencia + "' WHERE cIDSerie =" + (object)(excelWorksheet.Cells[i, 1] as Range).Value);
                }
            }
            con.close();
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        public void ExportarTeste()
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\BANCO_DADOS_CONCRETO_VLT_140530.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "CodBar";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            con.open();
            string situacao;
            if ((excelWorksheet.Cells[2, 2] as Range).Interior.Color != System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.White))
            {
                situacao = "1";
            }
            else
            {
                situacao = "0";
            }
            MessageBox.Show("Situação = " + situacao, "Situação = " + situacao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }
    }
}
