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
        int quantTestes;
        double[] valoresTeste;
        double tempoMinimo, tempoMedio, tempoMaximo;
        string nomeArq;
        string nomeArquivosTxt;
        string tipoVetorOrdenado;

        public Form1()
        {
            InitializeComponent();

            quantTestes = 0;
            contComp = 0;
            contTrocas = 0;
            valoresTeste = new double[5];

            quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";

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
                    quantTestes = 0;
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
                    if (quantTestes == 0)
                        nomeArq += "insercao.txt";

                    vetorAux = new int[vetor.Length];

                    vetor.CopyTo(vetorAux, 0);

                    if (tamVetor != 0)
                    {
                        watch.Start();
                        Ordenacao.InsertionSort(vetor);
                        watch.Stop();

                        valoresTeste[quantTestes] = watch.ElapsedMilliseconds;

                        watch.Reset();

                        quantTestes++;

                        quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";

                        PreencherListaOrdenada();

                        if (quantTestes == 5)
                        {
                            DefinirTempoMinimo();
                            DefinirTempoMedio();
                            DefinirTempoMaximo();

                            EscreverArquivo(nomeArq);

                            Insercao ins = new Insercao(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                            ins.Show();

                            Ordenacao.QuantComp = 0;
                            valoresTeste = new double[5];
                            quantTestes = 0;
                            quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";
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
            for (int i = 0; i < 5; i++)
            {
                if (vetor != null)
                {
                    if (quantTestes == 0)
                        nomeArq += "bolha.txt";

                    vetorAux = new int[vetor.Length];

                    vetor.CopyTo(vetorAux, 0);

                    if (tamVetor != 0)
                    {
                        watch.Start();
                        Ordenacao.bubbleSort(vetor);
                        watch.Stop();

                        valoresTeste[quantTestes] = watch.ElapsedMilliseconds;

                        watch.Reset();

                        quantTestes++;

                        quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";

                        PreencherListaOrdenada();

                        if (quantTestes == 5)
                        {
                            DefinirTempoMinimo();
                            DefinirTempoMedio();
                            DefinirTempoMaximo();

                            EscreverArquivo(nomeArq);

                            Bolha ins = new Bolha(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                            ins.Show();

                            Ordenacao.QuantComp = 0;
                            valoresTeste = new double[5];
                            quantTestes = 0;
                            quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";
                        }
                    }

                    vetor = vetorAux;
                }
            }
        }


        private void selecaoBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                if (vetor != null)
                {
                    if (quantTestes == 0)
                        nomeArq += "selecao.txt";

                    vetorAux = new int[vetor.Length];

                    vetor.CopyTo(vetorAux, 0);

                    if (tamVetor != 0)
                    {
                        watch.Start();
                        Ordenacao.selectionSort(vetor);
                        watch.Stop();

                        valoresTeste[quantTestes] = watch.ElapsedMilliseconds;

                        watch.Reset();

                        quantTestes++;

                        quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";

                        PreencherListaOrdenada();

                        if (quantTestes == 5)
                        {
                            DefinirTempoMinimo();
                            DefinirTempoMedio();
                            DefinirTempoMaximo();

                            EscreverArquivo(nomeArq);

                            Selecao ins = new Selecao(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                            ins.Show();

                            Ordenacao.QuantComp = 0;
                            valoresTeste = new double[5];
                            quantTestes = 0;
                            quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";
                        }
                    }

                    vetor = vetorAux;
                }
            }
        }

        private void mergeBtn_Click(object sender, EventArgs e)
        {
            if (vetor != null)
            {
                if (quantTestes == 0)
                    nomeArq += "merge.txt";

                vetorAux = new int[vetor.Length];

                vetor.CopyTo(vetorAux, 0);

                if (tamVetor != 0)
                {
                    watch.Start();
                    Ordenacao.MergeSort(vetor);
                    watch.Stop();

                    valoresTeste[quantTestes] = watch.ElapsedMilliseconds;

                    watch.Reset();

                    quantTestes++;

                    quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";

                    PreencherListaOrdenada();

                    if (quantTestes == 5)
                    {
                        DefinirTempoMinimo();
                        DefinirTempoMedio();
                        DefinirTempoMaximo();

                        EscreverArquivo(nomeArq);

                        Merge ins = new Merge(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                        ins.Show();

                        Ordenacao.QuantComp = 0;
                        valoresTeste = new double[5];
                        quantTestes = 0;
                        quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";
                    }
                }

                vetor = vetorAux;
            }
        }

        private void quickBtn_Click(object sender, EventArgs e)
        {
            if (vetor != null)
            {
                if (quantTestes == 0)
                    nomeArq += "quick.txt";

                vetorAux = new int[vetor.Length];

                vetor.CopyTo(vetorAux, 0);

                if (tamVetor != 0)
                {
                    watch.Start();
                    Ordenacao.QuickSort_Recursive(vetor, 0, vetor.Length - 1);
                    watch.Stop();

                    valoresTeste[quantTestes] = watch.ElapsedMilliseconds;

                    watch.Reset();

                    quantTestes++;

                    quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";

                    PreencherListaOrdenada();

                    if (quantTestes == 5)
                    {
                        DefinirTempoMinimo();
                        DefinirTempoMedio();
                        DefinirTempoMaximo();

                        EscreverArquivo(nomeArq);

                        Quick ins = new Quick(tempoMinimo, tempoMedio, tempoMaximo, Ordenacao.QuantComp, tamVetor, nomeArq, tipoVetorOrdenado);

                        ins.Show();

                        Ordenacao.QuantComp = 0;
                        valoresTeste = new double[5];
                        quantTestes = 0;
                        quantTestesLbl.Text = "Quantidade de testes = " + quantTestes + "/5";
                    }
                }

                vetor = vetorAux;
            }
        }
    }
}