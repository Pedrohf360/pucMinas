using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2017_10_10_Contas
{
    public partial class ContaForm : Form
    {
        ABB arvorePessoa = new ABB();
        ABB arvoreContas = new ABB();

        string[] dadosArquivo;

        public ContaForm()
        {
            InitializeComponent();

            LerArquivo("contas.txt");
            CadastrarTitulares();
        }

        void LerArquivo(string nomeArquivo)
        {
            StreamReader read = new StreamReader(nomeArquivo);

            dadosArquivo = read.ReadToEnd().Replace("\r", "").Replace(".", "").Replace("-", "").Split(';', '\n');
        }

        void CadastrarTitulares()
        {
            for (int i = 1; i < dadosArquivo.Length; i+=3)
            {
                Conta conta;
                Titular pessoa = new Titular(int.Parse(dadosArquivo[i++]));

                if (int.Parse(dadosArquivo[i+2]) == 1)
                {
                    conta = new Energia(0, 0, int.Parse(dadosArquivo[i]), 0, pessoa);
                }
                else
                {
                    conta = new Agua(0, 0, int.Parse(dadosArquivo[i]), 0, pessoa);
                }

                pessoa.AdicionarConta(conta);

                arvoreContas.Inserir(conta);

                arvorePessoa.Inserir(pessoa);
            }
        }



        //void ArmazenarCPFs()
        //{
        //    for (int i = 0; i < ; i++)
        //    {

        //    }
        //}

        private void cadIDbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
