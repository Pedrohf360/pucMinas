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
        private double numeroAtual, total;

        public Form1()
        {
            InitializeComponent();

            numeroAtual = 0;
            tbVisor.Text = "0";
            total = 0;
        }

        private void Calcula()
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

                    break;
            }
        }
    }
}
