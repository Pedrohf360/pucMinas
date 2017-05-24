using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_05_22_Aula12_Ex2_Excecoes
{
    public partial class Form1 : Form
    {
        private char operador;
        private double numeroAnterior;
        private double total;

        public Form1()
        {
            InitializeComponent();

            numeroAnterior = 0;
            tbVisor.Text = "0";
        }

        private void Calcula(char operador, double numero)
        {
            double valorAnterior = double.Parse(tbVisor.Text);

            switch (operador)
            {
                case '+':
                    total += valorAnterior + numero;
                    break;

                case '-':
                    total += valorAnterior - numero;
                    break;

                case 'X':
                    total += valorAnterior * numero;
                    break;

                case '/':
                    total += valorAnterior / numero;
                    break;

                case '%':
                    total += valorAnterior - numero;
                    break;

                default:
                    throw new ArgumentException("Operador desconhecido!");
            }
        }

        private void btSoma_Click(object sender, EventArgs e)
        {

            operador = '+';
            numeroAnterior = double.Parse(tbVisor.Text);
            tbVisor.Text = "0";

            Calcula(operador, numeroAnterior);

            

        }

        private void btIgualdade_Click(object sender, EventArgs e)
        {
            tbVisor.Text = total.ToString();
        }

        private void tbVisor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double.Parse(tbVisor.Text);
            }
            catch (FormatException forex)
            {
                MessageBox.Show(forex.Message);
                tbVisor.Text = "0";
            }
        }
    }
}
