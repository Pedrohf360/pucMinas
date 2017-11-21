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

namespace _2017_10_31_BolhaInsercao
{
    public partial class Bolha : Form
    {
        double tempoMinimo, tempoMedio, tempoMaximo;
        long quantComp, tamanhoVetor;
        string nomeArq;
        string tipoVetorOrd;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public Bolha(double tempoMinimo, double tempoMedio, double tempoMaximo, long quantComp, int tamanhoVetor, string nomeArq, string tipoVetOrd)
        {
            InitializeComponent();

            this.tempoMinimo = tempoMinimo;
            this.tempoMaximo = tempoMaximo;
            this.tempoMedio = tempoMedio;
            this.quantComp = quantComp;
            this.tamanhoVetor = tamanhoVetor;
            this.nomeArq = nomeArq;
            this.tipoVetorOrd = tipoVetorOrd;

            tamanhoVetorLbl.Text = "Tamanho vetor = " + this.tamanhoVetor;
            vetorOrdLbl.Text = "Tipo vetor ordenado = " + this.tipoVetorOrd;

            PreencherTabela();
        }

        public Bolha(string nomeArq)
        {
            InitializeComponent();

            this.nomeArq = nomeArq;

            PreencherTabela();
        }

        private string[] LerArq()
        {
            string conteudoArq;
            string[] vetorArq;

            //if (File.Exists(this.nomeArq))
            using (StreamReader reader = new StreamReader(this.nomeArq))
            {
                conteudoArq = reader.ReadToEnd();

                vetorArq = conteudoArq.Split(';');

                reader.Close();
            }

            return vetorArq;
        }

        private void PreencherTabela()
        {
            ListViewItem item = new ListViewItem();
            string[] vetorArq = LerArq();

            item.Text = vetorArq[0];
            item.SubItems.Add(vetorArq[1]);
            item.SubItems.Add(vetorArq[2]);
            item.SubItems.Add(vetorArq[3]);

            this.tamanhoVetor = int.Parse(vetorArq[4]);
            tamanhoVetorLbl.Text = "Tamanho vetor = " + this.tamanhoVetor;
            vetorOrdLbl.Text = "Tipo vetor ordenado = " + vetorArq[5];

            listView1.Items.Add(item);
        }
    }
}
