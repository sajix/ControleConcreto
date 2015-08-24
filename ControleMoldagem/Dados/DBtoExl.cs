using ControleMoldagem.Entidades;
using ControleMoldagem.Regras;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMoldagem.Dados
{
    class DBtoExl
    {
        CadastroCodigoBarras cCB = new CadastroCodigoBarras();
        CadastroObra cObra = new CadastroObra();
        CadastroMoldagem cMolde = new CadastroMoldagem();
        CadastroTraco cTraco = new CadastroTraco();
        CadastroLote cLote = new CadastroLote();
        CadastroEixo cEixo = new CadastroEixo();
        CadastroPeca cPeca = new CadastroPeca();
        CadastroRuptura cRuptura = new CadastroRuptura();
        CadastrarResistencia cResist = new CadastrarResistencia();
        public void ExportarCodigoBarras()
        {
            CodigoBarras[] cbs = cCB.BuscarTodos();
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\RelatorioCodigoBarras.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Sheets excelSheets = excelWorkbook.Worksheets;
            //string currentSheet = "FormCB";
            Worksheet excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Codigo Barras";
            Range excelCell;
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "Codigo de Barras";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Série";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "Situação";
            for (int i = 0; i < cbs.Length; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("A" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(cbs[i].IdCodigoBarras);
                excelCell = (Range)excelWorksheet.get_Range("B" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(cbs[i].IdSerie);
                excelCell = (Range)excelWorksheet.get_Range("C" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(cbs[i].Situacao);
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Traço";
            Traco[] traco = cTraco.BuscarTodos();
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "ID Traço";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Codigo Traço";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "Usina";
            excelCell = (Range)excelWorksheet.get_Range("D1");
            excelCell.Value2 = "FCK";
            excelCell = (Range)excelWorksheet.get_Range("E1");
            excelCell.Value2 = "Fator AC";
            excelCell = (Range)excelWorksheet.get_Range("F1");
            excelCell.Value2 = "Idade Controle";
            excelCell = (Range)excelWorksheet.get_Range("G1");
            excelCell.Value2 = "Consumo Cimento";
            excelCell = (Range)excelWorksheet.get_Range("H1");
            excelCell.Value2 = "Consistencia";
            excelCell = (Range)excelWorksheet.get_Range("I1");
            excelCell.Value2 = "Tolerancia";
            for (int i = 0; i < traco.Length; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("A" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].IdTraco);
                excelCell = (Range)excelWorksheet.get_Range("B" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].CodigoTraco);
                excelCell = (Range)excelWorksheet.get_Range("C" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].Usina);
                excelCell = (Range)excelWorksheet.get_Range("D" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].Fck);
                excelCell = (Range)excelWorksheet.get_Range("E" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].FatorAC);
                excelCell = (Range)excelWorksheet.get_Range("F" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].IdadeControle);
                excelCell = (Range)excelWorksheet.get_Range("G" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].ConsumoCimento);
                excelCell = (Range)excelWorksheet.get_Range("H" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].Consistencia);
                excelCell = (Range)excelWorksheet.get_Range("I" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(traco[i].Tolerancia);
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Lote";
            
            Lote[] lote = cLote.BuscarTodosLotes();
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "ID Lote";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Data Controle";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "FCK";
            excelCell = (Range)excelWorksheet.get_Range("D1");
            excelCell.Value2 = "FCK Estimado";
            excelCell = (Range)excelWorksheet.get_Range("E1");
            excelCell.Value2 = "Volume Lote";
            for (int i = 0; i < lote.Length; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("A" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(lote[i].IdSerie);
                excelCell = (Range)excelWorksheet.get_Range("B" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(lote[i].DataControle);
                excelCell = (Range)excelWorksheet.get_Range("C" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(lote[i].Fck);
                excelCell = (Range)excelWorksheet.get_Range("D" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(lote[i].FckEstimado);
                excelCell = (Range)excelWorksheet.get_Range("E" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(lote[i].Volume);
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Obra";
            Obra[] obra = cObra.BuscarTodos();
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "ID Obra";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Nome Obra";
            for (int i = 0; i < obra.Length; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("A" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(obra[i].IdObra);
                excelCell = (Range)excelWorksheet.get_Range("B" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(obra[i].NomeObra);
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = " Obra Eixo";
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "ID Eixo";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Nome Obra";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "Nome Eixo";
            int linha = 0;
            for (int i = 0; i < obra.Length; i++)
            {
                Eixo[] eixo = cEixo.BuscarTodos(obra[i].IdObra);
                for (int j = 0; j < eixo.Length; j++)
                {
                    excelCell = (Range)excelWorksheet.get_Range("A" + (linha + 2));
                    excelCell.NumberFormat = "@";
                    excelCell.Value2 = Convert.ToString(eixo[j].IdEixo);
                    excelCell = (Range)excelWorksheet.get_Range("B" + (linha + 2));
                    excelCell.NumberFormat = "@";
                    excelCell.Value2 = Convert.ToString(obra[i].NomeObra);
                    excelCell = (Range)excelWorksheet.get_Range("C" + (linha + 2));
                    excelCell.NumberFormat = "@";
                    excelCell.Value2 = Convert.ToString(eixo[j].NomeEixo);
                    linha++;
                }
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = " Obra Eixo Peça";
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "ID Peça";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Nome Obra";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "Nome Eixo";
            excelCell = (Range)excelWorksheet.get_Range("D1");
            excelCell.Value2 = "Nome Peça";
            linha = 0;
            for (int i = 0; i < obra.Length; i++)
            {
                Eixo[] eixo = cEixo.BuscarTodos(obra[i].IdObra);
                for (int j = 0; j < eixo.Length; j++)
                {
                    Peca[] peca = cPeca.BuscarTodos(obra[i].IdObra, eixo[j].IdEixo);
                    for (int k = 0; k < peca.Length; k++)
                    {
                        excelCell = (Range)excelWorksheet.get_Range("A" + (linha + 2));
                        excelCell.NumberFormat = "@";
                        excelCell.Value2 = Convert.ToString(peca[k].IdPeca);
                        excelCell = (Range)excelWorksheet.get_Range("B" + (linha + 2));
                        excelCell.NumberFormat = "@";
                        excelCell.Value2 = Convert.ToString(obra[i].NomeObra);
                        excelCell = (Range)excelWorksheet.get_Range("C" + (linha + 2));
                        excelCell.NumberFormat = "@";
                        excelCell.Value2 = Convert.ToString(eixo[j].NomeEixo);
                        excelCell = (Range)excelWorksheet.get_Range("D" + (linha + 2));
                        excelCell.NumberFormat = "@";
                        excelCell.Value2 = Convert.ToString(peca[k].NomePeca);
                        linha++;
                    }
                }
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Moldagem";
            Moldagem[] molde = cMolde.BuscarTudo();
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "ID Serie";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Data Moldagem";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "Hora Moldagem";
            excelCell = (Range)excelWorksheet.get_Range("D1");
            excelCell.Value2 = "Lote";
            excelCell = (Range)excelWorksheet.get_Range("E1");
            excelCell.Value2 = "Traço";
            excelCell = (Range)excelWorksheet.get_Range("F1");
            excelCell.Value2 = "FCK";
            excelCell = (Range)excelWorksheet.get_Range("G1");
            excelCell.Value2 = "Obra";
            excelCell = (Range)excelWorksheet.get_Range("H1");
            excelCell.Value2 = "Eixo";
            excelCell = (Range)excelWorksheet.get_Range("I1");
            excelCell.Value2 = "Peca";
            excelCell = (Range)excelWorksheet.get_Range("J1");
            excelCell.Value2 = "Quantidade CP";
            excelCell = (Range)excelWorksheet.get_Range("K1");
            excelCell.Value2 = "Idade Controle";
            excelCell = (Range)excelWorksheet.get_Range("L1");
            excelCell.Value2 = "Idade A";
            excelCell = (Range)excelWorksheet.get_Range("M1");
            excelCell.Value2 = "Idade B";
            excelCell = (Range)excelWorksheet.get_Range("N1");
            excelCell.Value2 = "Idade C";
            excelCell = (Range)excelWorksheet.get_Range("O1");
            excelCell.Value2 = "Volume Betonada";
            excelCell = (Range)excelWorksheet.get_Range("P1");
            excelCell.Value2 = "Temperatura do Ar";
            excelCell = (Range)excelWorksheet.get_Range("Q1");
            excelCell.Value2 = "Temperatura do Concreto";
            excelCell = (Range)excelWorksheet.get_Range("R1");
            excelCell.Value2 = "Nota Fiscal";
            for (int i = 0; i < molde.Length; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("A" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].IdSerie);
                excelCell = (Range)excelWorksheet.get_Range("B" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = molde[i].DataMoldagem.ToString("dd/MM/yyyy");
                excelCell = (Range)excelWorksheet.get_Range("C" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].HoraMoldagem);
                excelCell = (Range)excelWorksheet.get_Range("D" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].Lote);
                excelCell = (Range)excelWorksheet.get_Range("E" + (i + 2));
                excelCell.NumberFormat = "@";
                Traco [] mTraco = cTraco.BuscarTraco(Convert.ToString(molde[i].IdTraco), "cIDTraco");
                excelCell.Value2 = Convert.ToString(mTraco[0].CodigoTraco);
                excelCell = (Range)excelWorksheet.get_Range("F" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].Fck);
                excelCell = (Range)excelWorksheet.get_Range("G" + (i + 2));
                excelCell.NumberFormat = "@";
                Obra[] mObra = cObra.BuscarObra(Convert.ToString(molde[i].IdObra), "cIDObra");
                excelCell.Value2 = Convert.ToString(mObra[0].NomeObra);
                excelCell = (Range)excelWorksheet.get_Range("H" + (i + 2));
                excelCell.NumberFormat = "@";
                Eixo[] mEixo = cEixo.BuscarEixo(Convert.ToString(molde[i].IdEixo), Convert.ToString(molde[i].IdObra), "cIDEixo");
                excelCell.Value2 = Convert.ToString(mEixo[0].NomeEixo);
                excelCell = (Range)excelWorksheet.get_Range("I" + (i + 2));
                excelCell.NumberFormat = "@";
                Peca[] mPeca = cPeca.BuscarPeca(Convert.ToString(molde[i].IdPeca), Convert.ToString(molde[i].IdEixo), Convert.ToString(molde[i].IdObra), "cIDPeca");
                excelCell.Value2 = Convert.ToString(mPeca[0].NomePeca);
                excelCell = (Range)excelWorksheet.get_Range("J" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].QuantidadeCP);
                excelCell = (Range)excelWorksheet.get_Range("K" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].IdadeControle);
                excelCell = (Range)excelWorksheet.get_Range("L" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].IdadeA);
                excelCell = (Range)excelWorksheet.get_Range("M" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].IdadeB);
                excelCell = (Range)excelWorksheet.get_Range("N" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].IdadeC);
                excelCell = (Range)excelWorksheet.get_Range("O" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].VolumeBetonada);
                excelCell = (Range)excelWorksheet.get_Range("P" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].TemperaturaAr);
                excelCell = (Range)excelWorksheet.get_Range("Q" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].TemperaturaCimento);
                excelCell = (Range)excelWorksheet.get_Range("R" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(molde[i].Nota);
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Ruptura";
            Ruptura[] ruptura = cRuptura.BuscarTudo();
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "Codigo Barras";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Data Ruptura";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "Hora Ruptura";
            excelCell = (Range)excelWorksheet.get_Range("D1");
            excelCell.Value2 = "Serie";
            excelCell = (Range)excelWorksheet.get_Range("E1");
            excelCell.Value2 = "Diametro";
            excelCell = (Range)excelWorksheet.get_Range("F1");
            excelCell.Value2 = "Altura";
            excelCell = (Range)excelWorksheet.get_Range("G1");
            excelCell.Value2 = "Correção";
            excelCell = (Range)excelWorksheet.get_Range("H1");
            excelCell.Value2 = "Carga";
            for (int i = 0; i < ruptura.Length; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("A" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(ruptura[i].IdCodigoBarras);
                excelCell = (Range)excelWorksheet.get_Range("B" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(ruptura[i].DataRuptura);
                excelCell = (Range)excelWorksheet.get_Range("C" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(ruptura[i].Hora);
                excelCell = (Range)excelWorksheet.get_Range("D" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(ruptura[i].IdSerie);
                excelCell = (Range)excelWorksheet.get_Range("E" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(ruptura[i].DiametroCP);
                excelCell = (Range)excelWorksheet.get_Range("F" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(ruptura[i].AlturaCP);
                excelCell = (Range)excelWorksheet.get_Range("G" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(ruptura[i].Correcao);
                excelCell = (Range)excelWorksheet.get_Range("H" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(ruptura[i].Carga);
            }
            excelWorksheet = (Worksheet)excelSheets.Add();
            excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Resistencias";
            Resistencia[] resist = cResist.BuscarTudo();
            excelCell = (Range)excelWorksheet.get_Range("A1");
            excelCell.Value2 = "Serie";
            excelCell = (Range)excelWorksheet.get_Range("B1");
            excelCell.Value2 = "Idade A CP1";
            excelCell = (Range)excelWorksheet.get_Range("C1");
            excelCell.Value2 = "Idade A CP2";
            excelCell = (Range)excelWorksheet.get_Range("D1");
            excelCell.Value2 = "Idade B CP1";
            excelCell = (Range)excelWorksheet.get_Range("E1");
            excelCell.Value2 = "Idade B CP2";
            excelCell = (Range)excelWorksheet.get_Range("F1");
            excelCell.Value2 = "Idade C CP1";
            excelCell = (Range)excelWorksheet.get_Range("G1");
            excelCell.Value2 = "Idade C CP2";
            for (int i = 0; i < resist.Length; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("A" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(resist[i].IdSerie);
                excelCell = (Range)excelWorksheet.get_Range("B" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(resist[i].RA1);
                excelCell = (Range)excelWorksheet.get_Range("C" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(resist[i].RA2);
                excelCell = (Range)excelWorksheet.get_Range("D" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(resist[i].RB1);
                excelCell = (Range)excelWorksheet.get_Range("E" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(resist[i].RB2);
                excelCell = (Range)excelWorksheet.get_Range("F" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(resist[i].RC1);
                excelCell = (Range)excelWorksheet.get_Range("G" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = excelCell.Value2 = Convert.ToString(resist[i].RC2);
            }
            excelApp.Visible = true;
        }

    }
}
