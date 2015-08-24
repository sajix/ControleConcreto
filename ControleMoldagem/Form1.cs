using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMoldagem.Entidades;
using ControleMoldagem.Regras;
using System.Threading;
using ControleMoldagem.Dados;

namespace ControleMoldagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCript.Text = Criptografia.HashValue(txtBusca.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
