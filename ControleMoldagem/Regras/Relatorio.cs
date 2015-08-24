using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Drawing.Printing;
using ControleMoldagem.Dados;
using ControleMoldagem.Entidades;
using System.Drawing;

namespace ControleMoldagem.Regras
{
    class Relatorio
    {
        RepositorioRelatorio rRelatorio = new RepositorioRelatorio();
        RepositorioObra rObra = new RepositorioObra();
        RepositorioPeca rPeca = new RepositorioPeca();
        RepositorioEixo rEixo = new RepositorioEixo();
        CadastroObra cObra = new CadastroObra();
        CadastroEixo cEixo = new CadastroEixo();
        CadastroPeca cPeca = new CadastroPeca();
        CadastroTraco cTraco = new CadastroTraco();
        CadastroCodigoBarras cCB = new CadastroCodigoBarras();
        CadastroMoldagem cMolde = new CadastroMoldagem();
        CadastrarResistencia cResist = new CadastrarResistencia();
        public void AgendaRuptura(ProgressBar pBar, DateTime data)
        {
            System.Data.DataTable lista;
            DateTime hoje = data;//DateTime.Now.Date;
            System.Data.DataTable resultado = rRelatorio.AgendaRuptura();
            lista = resultado.Clone();
            lista.Clear();
            pBar.Maximum = resultado.Rows.Count;
            pBar.Minimum = 0;
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                DateTime compara = Convert.ToDateTime(resultado.Rows[i][1].ToString());
                DateTime comparaA = new DateTime();
                DateTime comparaB = new DateTime();
                DateTime comparaC = new DateTime();
                if (resultado.Rows[i][6].ToString() != "")
                {
                    comparaA = compara.AddDays(Convert.ToInt32(resultado.Rows[i][6].ToString()));
                }
                if (resultado.Rows[i][7].ToString() != "")
                {
                    comparaB = compara.AddDays(Convert.ToInt32(resultado.Rows[i][7].ToString()));
                }
                if (resultado.Rows[i][8].ToString() != "")
                {
                    comparaC = compara.AddDays(Convert.ToInt32(resultado.Rows[i][8].ToString()));
                }
                if ((comparaA == hoje && resultado.Rows[i][3].ToString() != "") || (comparaB == hoje && resultado.Rows[i][5].ToString() != "") || (comparaC == hoje && resultado.Rows[i][7].ToString() != ""))
                {
                    
                    lista.ImportRow(resultado.Rows[i]);
                }

            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = System.Windows.Forms.Application.StartupPath.ToString() + @"\Arquivos\AgendaRuptura.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "Form";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            Range excelCell;
            excelApp.DisplayAlerts = false;
            excelApp.ScreenUpdating = false;
            for (int i = 0; i < lista.Rows.Count; i++)
            {
                string teste = Convert.ToString(i * 2 + 11);
                excelCell = (Range)excelWorksheet.get_Range("B" + teste);
                excelCell.Value2 = lista.Rows[i][0].ToString();
                if (Convert.ToDateTime(lista.Rows[i][1].ToString()).AddDays(Convert.ToInt32(lista.Rows[i][6].ToString())) == DateTime.Now.Date)
                {
                    excelCell = (Range)excelWorksheet.get_Range("C" + i * 2 + 11);
                    excelCell.Value2 = lista.Rows[i][6].ToString();
                }
                else if (Convert.ToDateTime(lista.Rows[i][1].ToString()).AddDays(Convert.ToInt32(lista.Rows[i][7].ToString())) == DateTime.Now.Date)
                {
                    excelCell = (Range)excelWorksheet.get_Range("C" + i * 2 + 11);
                    excelCell.Value2 = lista.Rows[i][7].ToString();
                }
                else if (Convert.ToDateTime(lista.Rows[i][1].ToString()).AddDays(Convert.ToInt32(lista.Rows[i][8].ToString())) == DateTime.Now.Date)
                {
                    excelCell = (Range)excelWorksheet.get_Range("C" + i * 2 + 11);
                    excelCell.Value2 = lista.Rows[i][8].ToString();
                }
                excelCell = (Range)excelWorksheet.get_Range("D" + i * 2 + 11);
                excelCell.Value2 = lista.Rows[i][2].ToString();
                System.Data.DataTable obra = rObra.Buscar(lista.Rows[i][3].ToString(), "cIDObra");
                System.Data.DataTable eixo = rEixo.buscar(lista.Rows[i][4].ToString(), obra.Rows[0][0].ToString(), "cIDEixo");
                System.Data.DataTable peca = rPeca.buscar(lista.Rows[i][5].ToString(), eixo.Rows[0][0].ToString(), obra.Rows[0][0].ToString(), "cIDPeca");
                excelCell = (Range)excelWorksheet.get_Range("E" + i * 2 + 11);
                excelCell.Value2 = obra.Rows[0][1].ToString() + " / " + eixo.Rows[0][2].ToString() + " / " + peca.Rows[0][3].ToString();
            }
            excelWorksheet.PrintOutEx(1, 1, Properties.Settings.Default.NumberCopies, Properties.Settings.Default.PreviewPrint, Properties.Settings.Default.Printer, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        public void Resistencia(DateTime data)
        {
            System.Data.DataTable lista;
            DateTime hoje = data;//DateTime.Now.Date.AddDays(-4);
            System.Data.DataTable resultado = rRelatorio.RelatorioRuptura();
            lista = resultado.Clone();
            lista.Clear();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                DateTime compara = Convert.ToDateTime(resultado.Rows[i][2].ToString());
                DateTime comparaA = new DateTime();
                DateTime comparaB = new DateTime();
                DateTime comparaC = new DateTime();
                if (resultado.Rows[i][6].ToString() != "")
                {
                    comparaA = compara.AddDays(Convert.ToInt32(resultado.Rows[i][10].ToString()));
                }
                if (resultado.Rows[i][7].ToString() != "")
                {
                    comparaB = compara.AddDays(Convert.ToInt32(resultado.Rows[i][11].ToString()));
                }
                if (resultado.Rows[i][8].ToString() != "")
                {
                    comparaC = compara.AddDays(Convert.ToInt32(resultado.Rows[i][12].ToString()));
                }
                if (comparaA == hoje || comparaB == hoje || comparaC == hoje)
                {

                    lista.ImportRow(resultado.Rows[i]);
                }
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = System.Windows.Forms.Application.StartupPath.ToString() + @"\Arquivos\RelatorioResisencia.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "FormRes";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            Range excelCell;
            excelApp.DisplayAlerts = false;
            excelApp.ScreenUpdating = false;
            for (int i = 0; i < lista.Rows.Count; i++)
            {
                excelCell = (Range)excelWorksheet.get_Range("B" + i + 10); //Serie
                excelCell.Value2 = lista.Rows[i][0].ToString();
                excelCell = (Range)excelWorksheet.get_Range("C" + i + 10); //Lote
                excelCell.Value2 = lista.Rows[i][1].ToString();
                if (Convert.ToDateTime(lista.Rows[i][2].ToString()).AddDays(Convert.ToInt32(lista.Rows[i][10].ToString())) == DateTime.Now.Date)
                {
                    excelCell = (Range)excelWorksheet.get_Range("D" + i + 10); //Idade
                    excelCell.Value2 = lista.Rows[i][10].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("I" + i + 10); //Resistencia 1
                    excelCell.Value2 = lista.Rows[i][3].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("J" + i + 10); //Resistencia 2
                    excelCell.Value2 = lista.Rows[i][4].ToString();
                    if (Convert.ToInt32(lista.Rows[i][3].ToString()) < Convert.ToInt32(lista.Rows[i][4].ToString()))
                    {
                        excelCell = (Range)excelWorksheet.get_Range("K" + i + 10);//fi
                        excelCell.Value2 = lista.Rows[i][4].ToString();
                    }
                    else
                    {
                        excelCell = (Range)excelWorksheet.get_Range("K" + i + 10);//fi
                        excelCell.Value2 = lista.Rows[i][3].ToString();
                    }
                }
                else if (Convert.ToDateTime(lista.Rows[i][2].ToString()).AddDays(Convert.ToInt32(lista.Rows[i][11].ToString())) == DateTime.Now.Date)
                {
                    excelCell = (Range)excelWorksheet.get_Range("D" + i + 10); //Idade
                    excelCell.Value2 = lista.Rows[i][11].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("I" + i + 10);//Resistencia 1
                    excelCell.Value2 = lista.Rows[i][5].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("J" + i + 10);//Resistencia 2
                    excelCell.Value2 = lista.Rows[i][6].ToString();
                    if (Convert.ToInt32(lista.Rows[i][5].ToString()) < Convert.ToInt32(lista.Rows[i][6].ToString()))
                    {
                        excelCell = (Range)excelWorksheet.get_Range("K" + i + 10);//fi
                        excelCell.Value2 = lista.Rows[i][6].ToString();
                    }
                    else
                    {
                        excelCell = (Range)excelWorksheet.get_Range("K" + i + 10);//fi
                        excelCell.Value2 = lista.Rows[i][5].ToString();
                    }
                }
                else if (Convert.ToDateTime(lista.Rows[i][2].ToString()).AddDays(Convert.ToInt32(lista.Rows[i][12].ToString())) == DateTime.Now.Date)
                {
                    excelCell = (Range)excelWorksheet.get_Range("D" + i + 10);//Idade
                    excelCell.Value2 = lista.Rows[i][12].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("I" + i + 10);//Resistencia 1
                    excelCell.Value2 = lista.Rows[i][7].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("J" + i + 10);//Resistencia 2
                    excelCell.Value2 = lista.Rows[i][8].ToString();
                    if (Convert.ToInt32(lista.Rows[i][7].ToString()) < Convert.ToInt32(lista.Rows[i][8].ToString()))
                    {
                        excelCell = (Range)excelWorksheet.get_Range("K" + i + 10);//fi
                        excelCell.Value2 = lista.Rows[i][8].ToString();
                    }
                    else
                    {
                        excelCell = (Range)excelWorksheet.get_Range("K" + i + 10);//fi
                        excelCell.Value2 = lista.Rows[i][7].ToString();
                    }
                }
                excelCell = (Range)excelWorksheet.get_Range("E" + i + 10);
                excelCell.Value2 = lista.Rows[i][9].ToString();
                excelCell = (Range)excelWorksheet.get_Range("F" + i * 2 + 11);
                excelCell.Value2 = lista.Rows[i][13].ToString() + " / " + lista.Rows[i][14].ToString() + " / " + lista.Rows[i][15].ToString();
            }
            //excelApp.Visible = true;
            excelWorksheet.PrintOutEx(1, 1, Properties.Settings.Default.NumberCopies, Properties.Settings.Default.PreviewPrint, Properties.Settings.Default.Printer, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        public void RelatorioLote(ProgressBar pBar, int lote)
        {
            System.Data.DataTable lista = rRelatorio.RelatorioLote(lote);
            System.Data.DataTable count;
            System.Data.DataTable result = rRelatorio.RelatorioLoteSerie(Convert.ToInt32(lista.Rows[0][1].ToString()));
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = System.Windows.Forms.Application.StartupPath.ToString() + @"\Arquivos\RelatorioLote.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "Rel_Ensaio";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            Worksheet cutWorksheet = (Worksheet)excelSheets.get_Item("Recorte");
            Range cabecalho = (Range)excelWorksheet.get_Range("B1", "J15");
            Range rodape = (Range)excelWorksheet.get_Range("B160", "J161");
            Range excelCell;
            excelApp.DisplayAlerts = false;
            excelApp.ScreenUpdating = false;
            //excelApp.Visible = true;
            count = rRelatorio.RelatorioLoteContA(lote);
            int aLines = Convert.ToInt32(count.Rows[0][0].ToString());
            count = rRelatorio.RelatorioLoteContB(lote);
            int bLines = Convert.ToInt32(count.Rows[0][0].ToString());
            count = rRelatorio.RelatorioLoteContC(lote);
            int cLines = Convert.ToInt32(count.Rows[0][0].ToString());
            int totalLines = aLines + bLines + cLines;
            int nPages;
            int pageLines = 0;
            int l = 0;
            excelCell = (Range)excelWorksheet.get_Range("B1");
            pBar.Maximum = lista.Rows.Count;
            pBar.Minimum = 0;

            excelCell = (Range)excelWorksheet.get_Range("J7"); //lote
            excelCell.Value2 = lista.Rows[0][0].ToString();
            excelCell = (Range)excelWorksheet.get_Range("E8"); //Traço
            excelCell.Value2 = result.Rows[0][1].ToString();
            excelCell = (Range)excelWorksheet.get_Range("E9"); //fck
            excelCell.Value2 = result.Rows[0][3].ToString();
            excelCell = (Range)excelWorksheet.get_Range("E10"); //dataMoldagem
            excelCell.Value2 = result.Rows[0][12].ToString();
            excelCell = (Range)excelWorksheet.get_Range("E11"); //Consistencia
            excelCell.Value2 = result.Rows[0][7].ToString();
            excelCell = (Range)excelWorksheet.get_Range("E12"); //Consumo
            excelCell.Value2 = result.Rows[0][6].ToString();
            excelCell = (Range)excelWorksheet.get_Range("E13"); //Nº Lote
            excelCell.Value2 = result.Rows[0][0].ToString();
            excelCell = (Range)excelWorksheet.get_Range("I8"); //Usina
            excelCell.Value2 = result.Rows[0][2].ToString();
            excelCell = (Range)excelWorksheet.get_Range("I9"); //A/C
            excelCell.Value2 = result.Rows[0][4].ToString();
            excelCell = (Range)excelWorksheet.get_Range("I11"); //IdadeControle
            excelCell.Value2 = result.Rows[0][5].ToString();
            excelCell = (Range)excelWorksheet.get_Range("I13"); //MarcoTipo
            excelCell.Value2 = result.Rows[0][0].ToString();

            for (int i = 0; i < lista.Rows.Count; i++)
            {
                int serieLines = 0;
                if (lista.Rows[i][3].ToString() != "") //verifica se existe idade A
                {
                    serieLines += 2; //adiciona duas linhas ao contador de linha da serie
                }
                if (lista.Rows[i][4].ToString() != "") //verifica se existe idade B
                {
                    serieLines += 2; //adiciona duas linhas ao contador de linha da serie
                }
                if (lista.Rows[i][5].ToString() != "") //verifica se existe idade C
                {
                    serieLines += 2; //adiciona duas linhas ao contador de linhas da serie
                }
                if (pageLines + serieLines < 38)
                {
                    pageLines = pageLines + serieLines;
                    excelCell = (Range)excelWorksheet.get_Range("B" + (i * 6 + 16 + l)); //Serie
                    excelCell.Value2 = lista.Rows[i][1].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("C" + (i * 6 + 16 + l)); //Nota Fiscal
                    excelCell.Value2 = lista.Rows[i][2].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("D" + (i * 6 + 16 + l)); //Consistencia
                    excelCell.Value2 = lista.Rows[i][6].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("I" + (i * 6 + 16 + l)); //Peça Concretada  !!Adicionar na Query!!
                    result = rRelatorio.RelatorioLoteSerie(Convert.ToInt32(lista.Rows[i][1].ToString()));
                    excelCell.Value2 = result.Rows[0][9].ToString() + " / " + result.Rows[0][10].ToString() + " / " + result.Rows[0][11].ToString();
                    if (lista.Rows[i][0].ToString() != "") //verifica se existe idade A
                    {
                        //adiciona itens da idade A
                        excelCell = (Range)excelWorksheet.get_Range("E" + (i * 6 + 16 + l)); //Data Ruptura !!
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("F" + (i * 6 + 16 + l)); //Idade
                        excelCell.Value2 = lista.Rows[i][3].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 16 + l)); //Resistencia 1
                        excelCell.Value2 = lista.Rows[i][7].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 17 + l)); //Resistencia 2
                        excelCell.Value2 = lista.Rows[i][8].ToString();
                        string resistencia1 = lista.Rows[i][7].ToString();
                        string resistencia2 = lista.Rows[i][8].ToString();
                        if (resistencia1 == "")
                        {
                            resistencia1 = "0";
                        }
                        if (resistencia2 == "")
                        {
                            resistencia2 = "0";
                        }
                        if (Convert.ToDouble(resistencia1) < Convert.ToDouble(resistencia2))
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 16 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][8].ToString();
                        }
                        else
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 16 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][7].ToString();
                        }
                    }
                    if (lista.Rows[i][0].ToString() != "") //verifica se existe idade B
                    {
                        //adiciona itens da idade B
                        excelCell = (Range)excelWorksheet.get_Range("E" + (i * 6 + 18 + l)); //Data Ruptura !!
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("F" + (i * 6 + 18 + l)); //Idade 
                        excelCell.Value2 = lista.Rows[i][4].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 18 + l)); //Resistencia 1
                        excelCell.Value2 = lista.Rows[i][9].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 19 + l)); //Resistencia 2
                        excelCell.Value2 = lista.Rows[i][10].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 18 + l)); //Resistencia Exemplar
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        string resistencia1 = lista.Rows[i][9].ToString();
                        string resistencia2 = lista.Rows[i][10].ToString();
                        if (resistencia1 == "")
                        {
                            resistencia1 = "0";
                        }
                        if (resistencia2 == "")
                        {
                            resistencia2 = "0";
                        }
                        if (Convert.ToDouble(resistencia1) < Convert.ToDouble(resistencia2))
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 18 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][10].ToString();
                        }
                        else
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 18 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][9].ToString();
                        }
                    }
                    else
                    {
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 18 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 19 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();

                    }
                    if (lista.Rows[i][0].ToString() != "") //verifica se existe idade C
                    {
                        //adiciona itens da idade C
                        excelCell = (Range)excelWorksheet.get_Range("E" + (i * 6 + 20 + l)); //Data Ruptura
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("F" + (i * 6 + 20 + l)); //Idade
                        excelCell.Value2 = lista.Rows[i][5].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 20 + l)); //Resistencia 1
                        excelCell.Value2 = lista.Rows[i][11].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 21 + l)); //Resistencia 2
                        excelCell.Value2 = lista.Rows[i][12].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 20 + l)); //Resistencia Exemplar
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        string resistencia1 = lista.Rows[i][11].ToString();
                        string resistencia2 = lista.Rows[i][12].ToString();
                        if (resistencia1 == "")
                        {
                            resistencia1 = "0";
                        }
                        if (resistencia2 == "")
                        {
                            resistencia2 = "0";
                        }
                        if (Convert.ToDouble(resistencia1) < Convert.ToDouble(resistencia2))
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 20 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][12].ToString();
                        }
                        else
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 20 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][11].ToString();
                        }

                    }
                    else
                    {
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 20 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 21 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();
                    }
                }
                else
                {
                    pageLines = 0;
                    //excelCell.Next
                    int linha = Convert.ToInt32(excelCell.Row.ToString());
                    linha = linha + 2;
                    l = l + 17;
                    int qqcoisa = i * 6 + 15 + l;
                    excelCell = (Range)excelWorksheet.get_Range("B" + linha);
                    rodape.Copy(); //Copia Rodape
                    excelCell.Insert(XlInsertShiftDirection.xlShiftDown, true); //Inserindo Copia
                    linha = linha + 2;
                    excelCell = (Range)excelWorksheet.get_Range("B" + linha);
                    cabecalho.Copy(); //Copia Cabeçalho
                    excelCell.Insert(XlInsertShiftDirection.xlShiftDown, true); //Inserindo Copia
                    linha = linha + 1;
                    excelCell = (Range)excelWorksheet.get_Range("B" + linha);
                    excelSheets.HPageBreaks.Add(excelCell); //Quebra de pagina
                    excelCell = (Range)excelWorksheet.get_Range("B" + linha, "j" + linha);
                    excelCell.Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].Color = Color.Black.ToArgb();
                    //excelCell.EntireRow.PasteSpecial(Microsoft.Office.Interop.Excel.XlPasteType.xlPasteAll, Microsoft.Office.Interop.Excel.XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                    pageLines = pageLines + serieLines;
                    excelCell = (Range)excelWorksheet.get_Range("B" + (i * 6 + 16 + l)); //Serie
                    excelCell.Value2 = lista.Rows[i][1].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("C" + (i * 6 + 16 + l)); //Nota Fiscal
                    excelCell.Value2 = lista.Rows[i][2].ToString();
                    excelCell = (Range)excelWorksheet.get_Range("D" + (i * 6 + 16 + l)); //Consistencia
                    excelCell.Value2 = lista.Rows[i][6].ToString();
                    
                    excelCell = (Range)excelWorksheet.get_Range("I" + (i * 6 + 16 + l)); //Peça Concretada  !!Adicionar na Query!!
                    result = rRelatorio.RelatorioLoteSerie(Convert.ToInt32(lista.Rows[i][1].ToString()));
                    excelCell.Value2 = result.Rows[0][9].ToString() + " / " + result.Rows[0][10].ToString() + " / " + result.Rows[0][11].ToString();
                    if (lista.Rows[i][0].ToString() != "") //verifica se existe idade A
                    {
                        //adiciona itens da idade A
                        excelCell = (Range)excelWorksheet.get_Range("E" + (i * 6 + 16 + l)); //Data Ruptura !!
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("F" + (i * 6 + 16 + l)); //Idade
                        excelCell.Value2 = lista.Rows[i][3].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 16 + l)); //Resistencia 1
                        excelCell.Value2 = lista.Rows[i][7].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 17 + l)); //Resistencia 2
                        excelCell.Value2 = lista.Rows[i][8].ToString();
                        string resistencia1 = lista.Rows[i][7].ToString();
                        string resistencia2 = lista.Rows[i][8].ToString();
                        if (resistencia1 == "")
                        {
                            resistencia1 = "0";
                        }
                        if (resistencia2 == "")
                        {
                            resistencia2 = "0";
                        }
                        if (Convert.ToDouble(resistencia1) < Convert.ToDouble(resistencia2))
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 16 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][8].ToString();
                        }
                        else
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 16 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][7].ToString();
                        }
                    }
                    if (lista.Rows[i][0].ToString() != "") //verifica se existe idade B
                    {
                        //adiciona itens da idade B
                        excelCell = (Range)excelWorksheet.get_Range("E" + (i * 6 + 18 + l)); //Data Ruptura !!
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("F" + (i * 6 + 18 + l)); //Idade 
                        excelCell.Value2 = lista.Rows[i][4].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 18 + l)); //Resistencia 1
                        excelCell.Value2 = lista.Rows[i][9].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 19 + l)); //Resistencia 2
                        excelCell.Value2 = lista.Rows[i][10].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 18 + l)); //Resistencia Exemplar
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        string resistencia1 = lista.Rows[i][9].ToString();
                        string resistencia2 = lista.Rows[i][10].ToString();
                        if (resistencia1 == "")
                        {
                            resistencia1 = "0";
                        }
                        if (resistencia2 == "")
                        {
                            resistencia2 = "0";
                        }
                        if (Convert.ToDouble(resistencia1) < Convert.ToDouble(resistencia2))
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 18 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][10].ToString();
                        }
                        else
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 18 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][9].ToString();
                        }
                    }
                    else
                    {
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 18 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 19 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();

                    }
                    if (lista.Rows[i][0].ToString() != "") //verifica se existe idade C
                    {
                        //adiciona itens da idade C
                        excelCell = (Range)excelWorksheet.get_Range("E" + (i * 6 + 20 + l)); //Data Ruptura
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("F" + (i * 6 + 20 + l)); //Idade
                        excelCell.Value2 = lista.Rows[i][5].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 20 + l)); //Resistencia 1
                        excelCell.Value2 = lista.Rows[i][11].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 21 + l)); //Resistencia 2
                        excelCell.Value2 = lista.Rows[i][12].ToString();
                        excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 20)); //Resistencia Exemplar
                        excelCell.Value2 = lista.Rows[i][0].ToString();
                        string resistencia1 = lista.Rows[i][11].ToString();
                        string resistencia2 = lista.Rows[i][12].ToString();
                        if (resistencia1 == "")
                        {
                            resistencia1 = "0";
                        }
                        if (resistencia2 == "")
                        {
                            resistencia2 = "0";
                        }
                        if (Convert.ToDouble(resistencia1) < Convert.ToDouble(resistencia2))
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 20 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][12].ToString();
                        }
                        else
                        {
                            excelCell = (Range)excelWorksheet.get_Range("H" + (i * 6 + 20 + l)); //Resistencia Exemplar
                            excelCell.Value2 = lista.Rows[i][11].ToString();
                        }

                    }
                    else
                    {
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 20 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();
                        excelCell = (Range)excelWorksheet.get_Range("G" + (i * 6 + 21 + l)); //Data Ruptura
                        excelCell.EntireRow.Delete();
                    }
                }
                
                pBar.Value = i;
                
            }
            int teste = 144 - totalLines * 2;
            string teste2 = "G" + (16+ l + totalLines * 2);
            for (int j = 0; j < (144 - totalLines*2); j++)
            {
                excelCell = (Range)excelWorksheet.get_Range("G" + (16 + l + totalLines * 2));
                excelCell.EntireRow.Delete();
            }
            nPages = excelWorkbook.ActiveSheet.PageSetup.Pages.Count();
            excelWorksheet.PrintOutEx(1, 1, Properties.Settings.Default.NumberCopies, Properties.Settings.Default.PreviewPrint, Properties.Settings.Default.Printer, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelWorkbook.Close(false, Type.Missing, Type.Missing);
            
        }

        public void RelatorioCodigoBarras(ProgressBar pBar)
        {
            CodigoBarras[] cbs = cCB.BuscarTodos();
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string workbookPath = System.Windows.Forms.Application.StartupPath.ToString() + @"\Arquivos\RelatorioCodigoBarras.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Open(workbookPath, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Sheets excelSheets = excelWorkbook.Worksheets;
            string currentSheet = "FormCB";
            Worksheet excelWorksheet = (Worksheet)excelSheets.get_Item(currentSheet);
            Range excelCell;
            //excelApp.Visible = true;
            excelApp.DisplayAlerts = false;
            //excelApp.ScreenUpdating = false;
            int linha = 0;
            pBar.Maximum = cbs.Length;
            pBar.Minimum = 0;
            for (int i = 0; i < cbs.Length; i++)
            {
                pBar.Value = i;
                Moldagem molde = cMolde.BuscarMoldagem(Convert.ToString(cbs[i].IdSerie));
                excelCell = (Range)excelWorksheet.get_Range("B" + (linha + 10));
                excelCell.Value2 = cbs[i].IdSerie;
                //===========================================================================================
                excelCell = (Range)excelWorksheet.get_Range("C" + (linha + 10));
                excelCell.Value2 = cbs[i].IdCodigoBarras;
                if (cbs[i].Situacao == 1)
                {
                    excelCell.Cells.Interior.Color = Color.LightBlue;
                }
                excelCell = (Range)excelWorksheet.get_Range("D" + (linha + 10));
                excelCell.Value2 = cbs[i+1].IdCodigoBarras;
                if (cbs[i + 1].Situacao == 1)
                {
                    excelCell.Cells.Interior.Color = Color.LightBlue;
                }
                if (molde.QuantidadeCP > 3)
                {
                    excelCell = (Range)excelWorksheet.get_Range("E" + (linha + 10));
                    excelCell.Value2 = cbs[i + 2].IdCodigoBarras;
                    if (cbs[i+2].Situacao == 1)
                    {
                        excelCell.Cells.Interior.Color = Color.LightBlue;
                    }
                    excelCell = (Range)excelWorksheet.get_Range("F" + (linha + 10));
                    excelCell.Value2 = cbs[i + 3].IdCodigoBarras;
                    if (cbs[i+3].Situacao == 1)
                    {
                        excelCell.Cells.Interior.Color = Color.LightBlue;
                    }
                }
                if (molde.QuantidadeCP > 5)
                {
                    excelCell = (Range)excelWorksheet.get_Range("I" + (linha + 10));
                    excelCell.Value2 = cbs[i + 4].IdCodigoBarras;
                    if (cbs[i+4].Situacao == 1)
                    {
                        excelCell.Cells.Interior.Color = Color.LightBlue;
                    }
                    excelCell = (Range)excelWorksheet.get_Range("J" + (linha + 10));
                    excelCell.Value2 = cbs[i + 5].IdCodigoBarras;
                    if (cbs[i+5].Situacao == 1)
                    {
                        excelCell.Cells.Interior.Color = Color.LightBlue;
                    }
                }
                i = i + molde.QuantidadeCP -1;
                linha++;
            }
            excelApp.Visible = true;
        }
        public void RelatorioSerieResistencia(ProgressBar pBar)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            //string workbookPath = @"C:\Users\Vitor\Documents\Visual Studio 2012\Projects\ControleMoldagem\RelatorioCodigoBarras.xlsx";
            Workbook excelWorkbook = excelApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            Sheets excelSheets = excelWorkbook.Worksheets;
            //string currentSheet = "FormCB";
            Worksheet excelWorksheet = (Worksheet)excelSheets[1];
            excelWorksheet.Name = "Serie Resistencia";
            Range excelCell;
            Moldagem[] molde = cMolde.BuscarTudo();
            Resistencia[] resist = cResist.BuscarTudo();
            pBar.Maximum = molde.Length;
            pBar.Minimum = 0;
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
            excelCell = (Range)excelWorksheet.get_Range("S1");
            excelCell.Value2 = "Resistencia A1";
            excelCell = (Range)excelWorksheet.get_Range("T1");
            excelCell.Value2 = "Resistencia A2";
            excelCell = (Range)excelWorksheet.get_Range("U1");
            excelCell.Value2 = "Resistencia B1";
            excelCell = (Range)excelWorksheet.get_Range("V1");
            excelCell.Value2 = "Resistencia B2";
            excelCell = (Range)excelWorksheet.get_Range("W1");
            excelCell.Value2 = "Resistencia C1";
            excelCell = (Range)excelWorksheet.get_Range("X1");
            excelCell.Value2 = "Resistencia C2";
            for (int i = 0; i < molde.Length; i++)
            {
                pBar.Value = i;
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
                Traco[] mTraco = cTraco.BuscarTraco(Convert.ToString(molde[i].IdTraco), "cIDTraco");
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
                excelCell = (Range)excelWorksheet.get_Range("S" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(resist[i].RA1);
                excelCell = (Range)excelWorksheet.get_Range("T" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(resist[i].RA2);
                excelCell = (Range)excelWorksheet.get_Range("U" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(resist[i].RB1);
                excelCell = (Range)excelWorksheet.get_Range("V" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(resist[i].RB2);
                excelCell = (Range)excelWorksheet.get_Range("W" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(resist[i].RC1);
                excelCell = (Range)excelWorksheet.get_Range("X" + (i + 2));
                excelCell.NumberFormat = "@";
                excelCell.Value2 = Convert.ToString(resist[i].RC2);
            }
            excelApp.Visible = true;
        }
    }
}
