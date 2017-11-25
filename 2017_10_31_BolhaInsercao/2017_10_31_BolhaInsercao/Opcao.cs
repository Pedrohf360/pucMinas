using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017_10_31_BolhaInsercao
{
    public partial class Opcao : Form
    {
        List<Form> tiposOrdenacao = new List<Form>();

        Insercao[] ins = new Insercao[8];
        Bolha[] bolha = new Bolha[8];
        Merge[] merge = new Merge[16];
        Quick[] quick = new Quick[16];
        Selecao[] selecao = new Selecao[8];

        public Opcao()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            InstanciarObjs();

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Bolha i in bolha)
                tiposOrdenacao.Add(i);

            ExibirFormsOrdenacao();
        }

        private void ExibirFormsOrdenacao()
        {
            int x, y, contPosJanelas = 1;
            int screenSizeX, screenSizeY;

            this.tiposOrdenacao[0].Show();
            this.tiposOrdenacao[0].SetDesktopLocation(10, 10);

            x = this.tiposOrdenacao[0].Location.X;
            y = this.tiposOrdenacao[0].Size.Height;

            screenSizeX = Screen.PrimaryScreen.Bounds.Width;
            screenSizeY = Screen.PrimaryScreen.Bounds.Height-200;

            

            for (int i = 1; i < this.tiposOrdenacao.Count; i++)
            {
                this.tiposOrdenacao[i].Show();

                if ((y * contPosJanelas + 10) < screenSizeY)
                    this.tiposOrdenacao[i].SetDesktopLocation(x, (y * contPosJanelas + 10));
                else
                {
                    x += this.tiposOrdenacao[0].Size.Width + 10;
                    y = this.tiposOrdenacao[0].Size.Height;
                    contPosJanelas = 0;
                    this.tiposOrdenacao[i].SetDesktopLocation(x, 10);
                }
                contPosJanelas++;
            }

            this.tiposOrdenacao[this.tiposOrdenacao.Count - 1].Show();
        }

        private void FecharFormsOrdenacao()
        {
            for (int i = 0; i < this.tiposOrdenacao.Count; i++)
            {
                tiposOrdenacao[i].Hide();
            }

            tiposOrdenacao = new List<Form>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Insercao i in ins)
                tiposOrdenacao.Add(i);

            ExibirFormsOrdenacao();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FecharFormsOrdenacao();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Selecao i in selecao)
                tiposOrdenacao.Add(i);

            ExibirFormsOrdenacao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Merge i in merge)
                tiposOrdenacao.Add(i);

            ExibirFormsOrdenacao();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Quick i in quick)
                tiposOrdenacao.Add(i);

            ExibirFormsOrdenacao();
        }

        private void InstanciarObjs()
        {
            bolha[0] = new Bolha("..\\..\\arquivos.txt//crescentebolha10mil.txt");
            bolha[1] = new Bolha("..\\..\\arquivos.txt//decrescentebolha10mil.txt");
            bolha[2] = new Bolha("..\\..\\arquivos.txt//quaseOrdbolha10mil.txt");
            bolha[3] = new Bolha("..\\..\\arquivos.txt//aleatoriobolha10mil.txt");

            bolha[4] = new Bolha("..\\..\\arquivos.txt//crescentebolha100mil.txt");
            bolha[5] = new Bolha("..\\..\\arquivos.txt//decrescentebolha100mil.txt");
            bolha[6] = new Bolha("..\\..\\arquivos.txt//quaseOrdbolha100mil.txt");
            bolha[7] = new Bolha("..\\..\\arquivos.txt//aleatoriobolha100mil.txt");

            ///////////////////////////////////
            ins[0] = new Insercao("..\\..\\arquivos.txt//crescenteinsercao10mil.txt");
            ins[1] = new Insercao("..\\..\\arquivos.txt//decrescenteinsercao10mil.txt");
            ins[2] = new Insercao("..\\..\\arquivos.txt//quaseOrdinsercao10mil.txt");
            ins[3] = new Insercao("..\\..\\arquivos.txt//aleatorioinsercao10mil.txt");

            ins[4] = new Insercao("..\\..\\arquivos.txt//crescenteinsercao100mil.txt");
            ins[5] = new Insercao("..\\..\\arquivos.txt//decrescenteinsercao100mil.txt");
            ins[6] = new Insercao("..\\..\\arquivos.txt//quaseOrdinsercao100mil.txt");
            ins[7] = new Insercao("..\\..\\arquivos.txt//aleatorioinsercao100mil.txt");

            ////////////////////////
            selecao[0] = new Selecao("..\\..\\arquivos.txt//crescenteselecao10mil.txt");
            selecao[1] = new Selecao("..\\..\\arquivos.txt//decrescenteselecao10mil.txt");
            selecao[2] = new Selecao("..\\..\\arquivos.txt//quaseOrdselecao10mil.txt");
            selecao[3] = new Selecao("..\\..\\arquivos.txt//aleatorioselecao10mil.txt");

            selecao[4] = new Selecao("..\\..\\arquivos.txt//crescenteselecao100mil.txt");
            selecao[5] = new Selecao("..\\..\\arquivos.txt//decrescenteselecao100mil.txt");
            selecao[6] = new Selecao("..\\..\\arquivos.txt//quaseOrdselecao100mil.txt");
            selecao[7] = new Selecao("..\\..\\arquivos.txt//aleatorioselecao100mil.txt");


            ///////////////////////////////
            merge[0] = new Merge("..\\..\\arquivos.txt//crescentemerge10mil.txt");
            merge[1] = new Merge("..\\..\\arquivos.txt//decrescentemerge10mil.txt");
            merge[2] = new Merge("..\\..\\arquivos.txt//quaseOrdmerge10mil.txt");
            merge[3] = new Merge("..\\..\\arquivos.txt//aleatoriomerge10mil.txt");

            merge[4] = new Merge("..\\..\\arquivos.txt//crescentemerge100mil.txt");
            merge[5] = new Merge("..\\..\\arquivos.txt//decrescentemerge100mil.txt");
            merge[6] = new Merge("..\\..\\arquivos.txt//quaseOrdmerge100mil.txt");
            merge[7] = new Merge("..\\..\\arquivos.txt//aleatoriomerge100mil.txt");

            merge[8] = new Merge("..\\..\\arquivos.txt//crescentemerge500mil.txt");
            merge[9] = new Merge("..\\..\\arquivos.txt//decrescentemerge500mil.txt");
            merge[10] = new Merge("..\\..\\arquivos.txt//quaseOrdmerge500mil.txt");
            merge[11] = new Merge("..\\..\\arquivos.txt//aleatoriomerge500mil.txt");

            merge[12] = new Merge("..\\..\\arquivos.txt//crescentemerge1milhao.txt");
            merge[13] = new Merge("..\\..\\arquivos.txt//decrescentemerge1milhao.txt");
            merge[14] = new Merge("..\\..\\arquivos.txt//quaseOrdmerge1milhao.txt");
            merge[15] = new Merge("..\\..\\arquivos.txt//aleatoriomerge1milhao.txt");

            //////////////////////

            quick[0] = new Quick("..\\..\\arquivos.txt//crescentequick10mil.txt");
            quick[1] = new Quick("..\\..\\arquivos.txt//decrescentequick10mil.txt");
            quick[2] = new Quick("..\\..\\arquivos.txt//quaseOrdquick10mil.txt");
            quick[3] = new Quick("..\\..\\arquivos.txt//aleatorioquick10mil.txt");

            quick[4] = new Quick("..\\..\\arquivos.txt//crescentequick100mil.txt");
            quick[5] = new Quick("..\\..\\arquivos.txt//decrescentequick100mil.txt");
            quick[6] = new Quick("..\\..\\arquivos.txt//quaseOrdquick100mil.txt");
            quick[7] = new Quick("..\\..\\arquivos.txt//aleatorioquick100mil.txt");

            quick[8] = new Quick("..\\..\\arquivos.txt//crescentequick500mil.txt");
            quick[9] = new Quick("..\\..\\arquivos.txt//decrescentequick500mil.txt");
            quick[10] = new Quick("..\\..\\arquivos.txt//quaseOrdquick500mil.txt");
            quick[11] = new Quick("..\\..\\arquivos.txt//aleatorioquick500mil.txt");

            quick[12] = new Quick("..\\..\\arquivos.txt//crescentequick1milhao.txt");
            quick[13] = new Quick("..\\..\\arquivos.txt//decrescentequick1milhao.txt");
            quick[14] = new Quick("..\\..\\arquivos.txt//quaseOrdquick1milhao.txt");
            quick[15] = new Quick("..\\..\\arquivos.txt//aleatorioquick1milhao.txt");
        }
    }
}
