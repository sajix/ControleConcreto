using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMoldagem.Dados;
using ControleMoldagem.Entidades;
using System.Windows.Forms;
using System.Data;

namespace ControleMoldagem.Regras
{
    class CadastroTraco
    {
        RepositorioTraco rtraco = new RepositorioTraco();
        public void InserirTraco(string codigoTraco, string usina, string fck, string fatorAC, string idadeControle, string consumoCimento, string consistencia, string tolerancia)
        {
            Traco[] bTraco;
            bTraco = BuscarTraco(codigoTraco, "cCodigoTraco");

            if (bTraco.Length > 0)
            {
                MessageBox.Show("Traço ja Cadastrado",
                "Erro ao Cadastrar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                Traco iTraco = new Traco();
                iTraco.CodigoTraco = codigoTraco;
                iTraco.Usina = usina;
                iTraco.Fck = Convert.ToInt32(fck);
                iTraco.FatorAC = Convert.ToDecimal(fatorAC);
                iTraco.IdadeControle = Convert.ToInt32(idadeControle);
                iTraco.ConsumoCimento = Convert.ToDecimal(consumoCimento);
                iTraco.Consistencia = Convert.ToInt32(consistencia);
                iTraco.Tolerancia = Convert.ToInt32(tolerancia);
                rtraco.inserir(iTraco);
                MessageBox.Show("Traço Cadastrado", "Cadastrar Traço", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        public void EditarTraco(string novo, string codigoTraco, string usina, string fck, string fatorAC, string idadeControle, string consumoCimento, string consistencia, string tolerancia)
        {
            if (novo != codigoTraco)
            {
                DataTable resultado = rtraco.buscar(novo, "cCodigoTraco");
                if (resultado.Rows.Count > 0)
                {
                    MessageBox.Show("Traço ja Cadastrado",
                    "Erro ao Cadastrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
                }

                else
                {
                    Traco traco = new Traco();
                    traco.CodigoTraco = novo;
                    traco.Usina = usina;
                    traco.Consistencia = Convert.ToInt32(consistencia);
                    traco.ConsumoCimento = Convert.ToDecimal(consumoCimento);
                    traco.FatorAC = Convert.ToDecimal(fatorAC);
                    traco.Fck = Convert.ToInt32(fck);
                    traco.IdadeControle = Convert.ToInt32(idadeControle);
                    traco.Tolerancia = Convert.ToInt32(tolerancia);
                    rtraco.editar(codigoTraco, traco);
                }
            }
            else
            {
                Traco traco = new Traco();
                traco.CodigoTraco = novo;
                traco.Usina = usina;
                traco.Consistencia = Convert.ToInt32(consistencia);
                traco.ConsumoCimento = Convert.ToDecimal(consumoCimento);
                traco.FatorAC = Convert.ToDecimal(fatorAC);
                traco.Fck = Convert.ToInt32(fck);
                traco.IdadeControle = Convert.ToInt32(idadeControle);
                traco.Tolerancia = Convert.ToInt32(tolerancia);
                rtraco.editar(codigoTraco, traco);
            }
            
        }

        public Traco[] BuscarTraco(string codigoTraco, string campo)
        {

            DataTable resultado = rtraco.buscar(codigoTraco, campo);
            Traco[] traco = new Traco[resultado.Rows.Count];
            Traco item = new Traco();
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                item.IdTraco = Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.CodigoTraco = resultado.Rows[i][1].ToString();
                item.Usina = resultado.Rows[i][2].ToString();
                item.Fck = Convert.ToInt32(resultado.Rows[i][3].ToString());
                item.FatorAC = Convert.ToDecimal(resultado.Rows[i][4].ToString());
                item.IdadeControle = Convert.ToInt32(resultado.Rows[i][5].ToString());
                item.ConsumoCimento = Convert.ToDecimal(resultado.Rows[i][6].ToString());
                item.Consistencia = Convert.ToInt32(resultado.Rows[i][7].ToString());
                item.Tolerancia = Convert.ToInt32(resultado.Rows[i][8].ToString());
                traco[i] = item;
            }
            if (traco.Length < 0)
            {
                MessageBox.Show("Traço não encontrado",
                "Erro ao Buscar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return traco;
        }

        public void RemoverTraco(string codigoTraco)
        {
            //Traco traco = new Traco();
            /*traco = rtraco.buscar(codigoTraco);
            if (traco == null)
            {
                MessageBox.Show("Traço não encontrado",
                "Erro ao Remover",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }*/
            rtraco.remover(codigoTraco);
            MessageBox.Show("Traço Removido", "Cadastrar Traço", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        public Traco[] BuscarTodos()
        {
            DataTable resultado = rtraco.buscarTudo();
            Traco[] traco = new Traco[resultado.Rows.Count];
            for (int i = 0; i < resultado.Rows.Count; i++)
            {
                Traco item = new Traco();
                item.IdTraco = Convert.ToInt32(resultado.Rows[i][0].ToString());
                item.CodigoTraco = resultado.Rows[i][1].ToString();
                item.Usina = resultado.Rows[i][2].ToString();
                item.Fck = Convert.ToInt32(resultado.Rows[i][3].ToString());
                item.FatorAC = Convert.ToDecimal(resultado.Rows[i][4].ToString());
                item.IdadeControle = Convert.ToInt32(resultado.Rows[i][5].ToString());
                item.ConsumoCimento = Convert.ToDecimal(resultado.Rows[i][6].ToString());
                item.Consistencia = Convert.ToInt32(resultado.Rows[i][7].ToString());
                item.Tolerancia = Convert.ToInt32(resultado.Rows[i][8].ToString());
                traco[i] = item;
            }
            return traco;
        }

    }
}
