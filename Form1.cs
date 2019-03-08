using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleContaDeBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adcionar_bTn_Click(object sender, EventArgs e)
        {
            ContaDeBAr conta = new ContaDeBAr();
            decimal valorUnitario;
            int quantidade,quantidadePessoa;

            valorUnitario = vUnitarioTbx.ToString();
        }
    }
}
