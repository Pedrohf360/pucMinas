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
        private double numeroAtual;
        private double total;

        public Form1()
        {
            InitializeComponent();

            numeroAtual = 0;
            tbVisor.Text = "0";
            total = 0;
        }

        private double Calcula(char operador, double numeroAtual)
        {
            switch (operador)
            {
                case '+':
                    total += numeroAtual;
                    break;

                case '-':
                    total -= numeroAtual;
                    break;

                case 'X':
                    total *= numeroAtual;
                    break;

                case '/':
                    total /= numeroAtual;
                    break;

                case '%':
                    total %= numeroAtual;
                    break;

                default:
                    throw new ArgumentException("Operador desconhecido!");
            }

            return total;
        }

        private void btSoma_Click(object sender, EventArgs e)
        {
            operador = '+';
            numeroAtual = double.Parse(tbVisor.Text);

            Calcula(operador, numeroAtual);

            tbVisor.Text = total.ToString();

            tbVisor.Focus();
            tbVisor.SelectAll();
        }

        private void btIgualdade_Click(object sender, EventArgs e)
        {
            tbVisor.Text = total.ToString();
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            operador = '-';
            numeroAtual = double.Parse(tbVisor.Text);

            Calcula(operador, numeroAtual);

            tbVisor.Text = total.ToString();

            tbVisor.Focus();
            tbVisor.SelectAll();
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            operador = '/';
            numeroAtual = double.Parse(tbVisor.Text);

            Calcula(operador, numeroAtual);

            tbVisor.Text = total.ToString();

            tbVisor.Focus();
            tbVisor.SelectAll();
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            operador = 'X';

            numeroAtual = double.Parse(tbVisor.Text);

            Calcula(operador, numeroAtual);

            tbVisor.Text = total.ToString();

            tbVisor.Focus();
            tbVisor.SelectAll();
        }

        private void btModulo_Click(object sender, EventArgs e)
        {
            operador = '%';
            numeroAtual = double.Parse(tbVisor.Text);

            Calcula(operador, numeroAtual);

            tbVisor.Text = total.ToString();

            tbVisor.Focus();
            tbVisor.SelectAll();
        }

        private void btLimpol_Click(object sender, EventArgs e)
        {
            total = 0;
            numeroAtual = 0;
            operador = '+';

            tbVisor.Text = "0";
        }

    }
}
