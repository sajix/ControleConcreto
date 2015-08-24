using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleMoldagem.Entidades;
using ControleMoldagem.Dados;
using System.Windows.Forms;
using System.Data;

namespace ControleMoldagem.Regras
{
    class CadastrarResistencia
    {
        RepositorioResistencia rResistenca = new RepositorioResistencia();
        public void InserirResistencia(string serie)
        {
            rResistenca.Inserir(Convert.ToInt32(serie));
        }
        public Resistencia BuscarResistencia(string serie)
        {
            Resistencia resist = rResistenca.Buscar(Convert.ToInt32(serie));
            return resist;
        }
        public Resistencia[] BuscarTudo()
        {
            Resistencia[] resist = rResistenca.BuscarTudo();
            return resist;
        }
        public void EditarResistencia(string serie, string resistencia, string valor)
        {
            rResistenca.Editar(Convert.ToInt32(serie), resistencia, Convert.ToDecimal(valor));
        }

    }
}
