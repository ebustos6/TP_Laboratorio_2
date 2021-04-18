using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1;

namespace TP1
{
    public partial class MiCalculadora : Form
    {
        public MiCalculadora()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.cmbOperador.Text = string.Empty;
            this.txtNumero2.Clear();
            this.lblResultado.Text = string.Empty;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            this.lblResultado.Text = Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text).ToString();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero auxNumero1 = new Numero(numero1);
            Numero auxNumero2 = new Numero(numero2);
            return Calculadora.Operar(auxNumero1, auxNumero2, operador);
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.lblResultado.Text))
            {
                double.TryParse(this.lblResultado.Text, out double aux);
                Numero resultado = new Numero();
                this.lblResultado.Text = resultado.DecimalBinario(aux);
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.lblResultado.Text))
            {
                Numero resultado = new Numero();
                this.lblResultado.Text = resultado.BinarioDecimal(this.lblResultado.Text);
            }
        }
    }
}
