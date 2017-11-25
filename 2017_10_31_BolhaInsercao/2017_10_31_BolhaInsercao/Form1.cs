using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace _2017_10_31_BolhaInsercao
{
    public partial class Form1 : Form
    {
        int[] vetor, vetorAux;
        int contComp;
        int contTrocas;
        int limInf, limSup, tamVetor;
        Stopwatch watch = new Stopwatch();
        double[] valoresTeste;
        double tempoMinimo, tempoMedio, tempoMaximo;
        string nomeArq;
        string nomeArquivosTxt;
        string tipoVetorOrdenado;
        int contBubble, contInsercao, contMerge, contQuick, contSelecao;

        public Form1()
        {
            InitializeComponent();

            contComp = 0;
            contTrocas = 0;
            valoresTeste = new double[5];

            quantTestesLbl.Text = "Quantidade de testes = " + 0 + "/5";

            nomeArquivosTxt = "..\\..\\arquivos.txt//";
        }

        private void gerarVetorBtn_Click(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text.Length != 0 && maskedTextBox4.Text.Length != 0)
            {
                string limInfText, limSupText;

                limInfText = maskedTextBox4.Text;
                limSupText = maskedTextBox3.Text;

                limInf = int.Parse(limInfText);
                limSup = int.Parse(limSupText);

                if (limInf > limSup)
                {
                    int aux = limInf;
                    limInf = limSup;
                    limSup = aux;
                }

                if (limSup - limInf > 1000000)
                {
                    MessageBox.Show("A diferença entre o limite inferir e superior deve ser, no máximo, 5000!");
                }
                else
                {
                    tamVetor = limSup - limInf;

                    if (vetCrescChckB.Checked)
                    {
                        nomeArq = "..\\..\\arquivos.txt//crescente";
                        tipoVetorOrdenado = "Vetor crescente";
                        vetor = PreencheVetor.vetCrescente(tamVetor, limInf, limSup);
                    }
                    else if (vetDecrescChckB.Checked)
                    {
                        nomeArq = "..\\..\\arquivos.txt//decrescente";
                        tipoVetorOrdenado = "Vetor Decrescente";
                        vetor = PreencheVetor.vetDecrescente(tamVetor, limInf, limSup);
                    }
                    else if (quaseOrdChckB.Checked)
                    {
                        nomeArq = "..\\..\\arquivos.txt//quaseOrd";
                        tipoVetorOrdenado = "Vetor quase ordenado";
                        vetor = PreencheVetor.quaseOrdenado(tamVetor, limInf, limSup);
                    }
                    else if (vetAleatChckB.Checked)
                    {
                        nomeArq = "..\\..\\arquivos.txt//aleatorio";
                        tipoVetorOrdenado = "Vetor aleatório";
                        vetor = PreencheVetor.vetAleatorio(tamVetor, limInf, limSup);
                    }
                    else
                        MessageBox.Show("Selecione alguma das opções para preenchimento do vetor!");

                    PreencherListaDesordenada();

                    tamVetor++;
                }

            }
            else
            {
                MessageBox.Show("Informe um intervalo!");
            }
        }

        #region REGION - WASTED (E da próxima vez, use o comboBox (voz dona Florinda))

        private void vetCrescChckB_CheckedChanged(object sender, EventArgs e)
        {
            Ordenacao.QuantComp = 0;
            vetAleatChckB.Checked = false;
            quaseOrdChckB.Checked = false;
            vetDecrescChckB.Checked = false;
        }

        private void vetDecrescChckB_CheckedChanged(object sender, EventArgs e)
        {
            Ordenacao.QuantComp = 0;
            vetAleatChckB.Checked = false;
            quaseOrdChckB.Checked = false;
            vetCrescChckB.Checked = false;
        }

        private void quaseOrdChckB_CheckedChanged(object sender, EventArgs e)
        {
            Ordenacao.QuantComp = 0;
            vetAleatChckB.Checked = false;
            vetDecrescChckB.Checked = false;
            vetCrescChckB.Checked = false;
        }

        private void vetAleatChckB_CheckedChanged(object sender, EventArgs e)
        {
            Ordenacao.QuantComp = 0;
            quaseOrdChckB.Checked = false;
            vetDecrescChckB.Checked = false;
            vetCrescChckB.Checked = false;
        }

        #endregion

        private void DefinirTempoMinimo()
        {
            tempoMinimo = valoresTeste[0];

            for (int i = 1; i < valoresTeste.Length; i++)
            {
                if (i > 0 && tempoMinimo > valoresTeste[i]) tempoMinimo = valoresTeste[i];
            }
        }

        private void DefinirTempoMedio()
        {
            double soma = 0;

            foreach (double i in valoresTeste)
                soma += i;

            tempoMedio = soma / valoresTeste.Length;
        }

        private void DefinirTempoMaximo()
        {
            tempoMaximo = valoresTeste[0];

            for (int i = 1; i < valoresTeste.Length; i++)
            {
                if (i > 0 && tempoMaximo < valoresTeste[i]) tempoMaximo = valoresTeste[i];
            }
        }

        private void EscreverArquivo(string nomeArq)
        {
            using (StreamWriter writer = new StreamWriter(nomeArq, false))
            {
                writer.Write(tempoMinimo + ";" + tempoMedio + ";" + tempoMaximo + ";" + Ordenacao.QuantComp + ";" + tamVetor + ";" + tipoVetorOrdenado);
            }
        }


        private void insercaoBtn_Click(object sender, EventArgs e)
        {
            if (vetor != null)
            {
                vetorAux = new int[vetor.Length];

                vetor.CopyTo(vetorAux, 0);

                if (tamVetor != 0)
                {
                    watch.Start();
                    Ordenacao.InsertionSort(vetor);
                    watch.Stop();

                    valoresTeste[contInsercao] = watch.ElapsedMilliseconds;

                    watch.Reset();

                    contInsercao++;

                    quantTestesLbl.Text = "Quantidade de testes = " + contInsercao + "/5";

                    PreencherListaOrdenada();

                    if (contInsercao == 5)
                    {
                        string nomeArqAux = nomeArq;

                        nomeArq += "insercao.txt";

                        DefinirTempoMinimo();
                        DefinirTempoMedio();
                        DefinirTempoMaximo();

                        EscreverArquivo(nomeArq);

                        Insercao ins = new Insercao(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                        ins.Show();

                        Ordenacao.QuantComp = 0;
                        valoresTeste = new double[5];
                        contInsercao = 0;
                        quantTestesLbl.Text = "Quantidade de testes = " + contInsercao + "/5";

                        nomeArq = nomeArqAux;
                    }
                }

                vetor = vetorAux;
            }

        }

        private void PreencherListaDesordenada()
        {
            desordenadaListBox.Items.Clear();

            if (vetor != null)
            {
                if (vetor.Length > 1000)
                {
                    for (int i = 0; i <= 250; i++)
                    {
                        desordenadaListBox.Items.Add(vetor[i].ToString());
                    }
                    desordenadaListBox.Items.Add("................................................................................");
                    for (int i = vetor.Length - 250; i < vetor.Length; i++)
                    {
                        desordenadaListBox.Items.Add(vetor[i].ToString());
                    }
                }
                else
                    for (int i = 0; i <= tamVetor; i++)
                    {
                        desordenadaListBox.Items.Add(vetor[i].ToString());
                    }
            }
        }

        private void testesAntBtn_Click(object sender, EventArgs e)
        {
            Opcao opc = new Opcao();

            opc.Show();
        }

        private void PreencherListaOrdenada()
        {
            ordenadaListBox.Items.Clear();

            if (vetor != null)
            {
                if (vetor.Length > 1000)
                {
                    for (int i = 0; i <= 250; i++)
                    {
                        ordenadaListBox.Items.Add(vetor[i].ToString());
                    }
                    ordenadaListBox.Items.Add("................................................................................");
                    for (int i = vetor.Length - 250; i < vetor.Length; i++)
                    {
                        ordenadaListBox.Items.Add(vetor[i].ToString());
                    }
                }
                else
                    for (int i = 0; i < tamVetor; i++)
                    {
                        ordenadaListBox.Items.Add(vetor[i].ToString());
                    }
            }
        }


        private void bolhaBtn_Click(object sender, EventArgs e)
        {
            if (vetor != null)
            {
                vetorAux = new int[vetor.Length];

                vetor.CopyTo(vetorAux, 0);

                if (tamVetor != 0)
                {
                    watch.Start();
                    Ordenacao.bubbleSort(vetor);
                    watch.Stop();

                    valoresTeste[contBubble] = watch.ElapsedMilliseconds;

                    watch.Reset();

                    contBubble++;

                    quantTestesLbl.Text = "Quantidade de testes = " + contBubble + "/5";

                    PreencherListaOrdenada();

                    if (contBubble == 5)
                    {
                        string nomeArqAux = nomeArq;

                        nomeArq += "bolha.txt";

                        DefinirTempoMinimo();
                        DefinirTempoMedio();
                        DefinirTempoMaximo();

                        EscreverArquivo(nomeArq);

                        Bolha ins = new Bolha(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                        ins.Show();

                        Ordenacao.QuantComp = 0;
                        valoresTeste = new double[5];
                        contBubble = 0;
                        quantTestesLbl.Text = "Quantidade de testes = " + contBubble + "/5";

                        nomeArq = nomeArqAux;
                    }
                }

                vetor = vetorAux;
            }

        }


        private void selecaoBtn_Click(object sender, EventArgs e)
        {

            if (vetor != null)
            {
                vetorAux = new int[vetor.Length];

                vetor.CopyTo(vetorAux, 0);

                if (tamVetor != 0)
                {
                    watch.Start();
                    Ordenacao.selectionSort(vetor);
                    watch.Stop();

                    valoresTeste[contSelecao] = watch.ElapsedMilliseconds;

                    watch.Reset();

                    contSelecao++;

                    quantTestesLbl.Text = "Quantidade de testes = " + contSelecao + "/5";

                    PreencherListaOrdenada();

                    if (contSelecao == 5)
                    {
                        string nomeArqAux = nomeArq;

                        nomeArq += "selecao.txt";

                        DefinirTempoMinimo();
                        DefinirTempoMedio();
                        DefinirTempoMaximo();

                        EscreverArquivo(nomeArq);

                        Selecao ins = new Selecao(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                        ins.Show();

                        Ordenacao.QuantComp = 0;
                        valoresTeste = new double[5];
                        contSelecao = 0;
                        quantTestesLbl.Text = "Quantidade de testes = " + contSelecao + "/5";
                        nomeArq = nomeArqAux;
                    }
                }

                vetor = vetorAux;
            }

        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {

            if (vetor != null)
            {
                vetorAux = new int[vetor.Length];

                vetor.CopyTo(vetorAux, 0);

                if (tamVetor != 0)
                {
                    watch.Start();
                    Ordenacao.MergeSort(vetor);
                    watch.Stop();

                    valoresTeste[contMerge] = watch.ElapsedMilliseconds;

                    watch.Reset();

                    contMerge++;

                    quantTestesLbl.Text = "Quantidade de testes = " + contMerge + "/5";

                    PreencherListaOrdenada();

                    if (contMerge == 5)
                    {
                        string nomeArqAux = nomeArq;

                        nomeArq += "merge.txt";
                        DefinirTempoMinimo();
                        DefinirTempoMedio();
                        DefinirTempoMaximo();

                        EscreverArquivo(nomeArq);

                        Merge ins = new Merge(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                        ins.Show();

                        Ordenacao.QuantComp = 0;
                        valoresTeste = new double[5];
                        contMerge = 0;
                        quantTestesLbl.Text = "Quantidade de testes = " + contMerge + "/5";

                        nomeArq = nomeArqAux;
                    }
                }

                vetor = vetorAux;
            }
        }

        private void quickBtn_Click(object sender, EventArgs e)
        {
            if (vetor != null)
            {
                vetorAux = new int[vetor.Length];

                vetor.CopyTo(vetorAux, 0);

                if (tamVetor != 0)
                {
                    watch.Start();
                    Ordenacao.QuickSort_Recursive(vetor, 0, vetor.Length - 1);
                    watch.Stop();

                    valoresTeste[contQuick] = watch.ElapsedMilliseconds;

                    watch.Reset();

                    contQuick++;

                    quantTestesLbl.Text = "Quantidade de testes = " + contQuick + "/5";

                    PreencherListaOrdenada();

                    if (contQuick == 5)
                    {
                        string nomeArqAux = nomeArq;

                        nomeArq += "quick.txt";
                        DefinirTempoMinimo();
                        DefinirTempoMedio();
                        DefinirTempoMaximo();

                        EscreverArquivo(nomeArq);

                        Quick ins = new Quick(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                        ins.Show();

                        Ordenacao.QuantComp = 0;
                        valoresTeste = new double[5];
                        contQuick = 0;
                        quantTestesLbl.Text = "Quantidade de testes = " + contQuick + "/5";

                        nomeArq = nomeArqAux;
                    }
                }

                vetor = vetorAux;
            }
        }
    }
}