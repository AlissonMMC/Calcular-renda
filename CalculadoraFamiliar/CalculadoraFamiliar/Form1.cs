using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraFamiliar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double renda = double.Parse(txtRenda.Text);
            
            double n1 = double.Parse(txtEnergia.Text);
            double n2 = double.Parse(txtAgua.Text);
            double n3 = double.Parse(txtTv.Text);
            double n4 = double.Parse(txtAlimentecao.Text);
            double n5 = double.Parse(txtOutros.Text);

            double gasto = n1 + n2 + n3 + n4 + n5;
            double resultado = renda - gasto;
             

            lblGasto.Text = gasto.ToString("C");
            lblSaldo.Text = resultado.ToString("C");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtEnergia.Text = "";
            txtAgua.Text = "";
            txtTv.Text = "";
            txtAlimentecao.Text = "";
            txtOutros.Text = "";
            txtRenda.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
