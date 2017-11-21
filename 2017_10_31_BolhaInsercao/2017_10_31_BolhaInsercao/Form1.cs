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

namespace _2017_10_31_BolhaInsercao
{
    public partial class Form1 : Form
    {
        int[] vetor;
        int contComp;
        int contTrocas;
        int limInf, limSup, tamVetor;

        Stopwatch watch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

            contComp = 0;
            contTrocas = 0;
        }

        private void gerarVetorBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

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

                if (limSup - limInf > 5000)
                {
                    MessageBox.Show("A diferença entre o limite inferir e superior deve ser, no máximo, 5000!");
                }
                else
                {
                    tamVetor = limSup - limInf;

                    if (vetCrescChckB.Checked)
                        vetor = PreencheVetor.vetCrescente(tamVetor, limInf, limSup);
                    else if (vetDecrescChckB.Checked)
                        vetor = PreencheVetor.vetDecrescente(tamVetor, limInf, limSup);
                    else if (quaseOrdChckB.Checked)
                        vetor = PreencheVetor.quaseOrdenado(tamVetor, limInf, limSup);
                    else if (vetAleatChckB.Checked)
                        vetor = PreencheVetor.vetAleatorio(tamVetor, limInf, limSup);
                    else
                        MessageBox.Show("Selecione alguma das opções para preenchimento do vetor!");

                    if (vetor != null)
                    {
                        for (int i = 0; i <= tamVetor; i++)
                        {
                            listBox.Items.Add(vetor[i].ToString());
                            Application.DoEvents();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Informe um intervalo!");
            }
        }

        private void vetCrescChckB_CheckedChanged(object sender, EventArgs e)
        {
            vetAleatChckB.Checked = false;
            quaseOrdChckB.Checked = false;
            vetDecrescChckB.Checked = false;
        }

        private void vetDecrescChckB_CheckedChanged(object sender, EventArgs e)
        {
            vetAleatChckB.Checked = false;
            quaseOrdChckB.Checked = false;
            vetCrescChckB.Checked = false;
        }

        private void quaseOrdChckB_CheckedChanged(object sender, EventArgs e)
        {
            vetAleatChckB.Checked = false;
            vetDecrescChckB.Checked = false;
            vetCrescChckB.Checked = false;
        }

        private void vetAleatChckB_CheckedChanged(object sender, EventArgs e)
        {
            quaseOrdChckB.Checked = false;
            vetDecrescChckB.Checked = false;
            vetCrescChckB.Checked = false;
        }

        // WORKING =D
        private void insercaoBtn_Click(object sender, EventArgs e)
        {
            vetor = Ordenacao.InsertionSort(vetor);
        }

        // WORKING XD
        private void bolhaBtn_Click(object sender, EventArgs e)
        {
            vetor = Ordenacao.bubbleSort(vetor);
        }

        // WORKING ;D
        private void selecaoBtn_Click(object sender, EventArgs e)
        {
            vetor = Ordenacao.selectionSort(vetor);
        }

        // WOOORKINGG =D=D=D
        private void mergeBtn_Click(object sender, EventArgs e)
        {
            vetor = Ordenacao.MergeSort(vetor);
        }

        // DON'T WORKING =(
        private void quickBtn_Click(object sender, EventArgs e)
        {
            vetor = Ordenacao.QuickSort_Recursive(vetor, 0, vetor.Length);
        }
    }
}