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
        List<Titular> pessoas = new List<Titular>();

        string[] dadosArquivo;
        public ContaForm()
        {
            InitializeComponent();

            LerArquivo("contas.txt");
            PreencherArvContasEListaPessoas();
            NormalizarListaPessoas();
            PreencheArvPessoas();
        }

        void LerArquivo(string nomeArquivo)
        {
            StreamReader read = new StreamReader(nomeArquivo);

            dadosArquivo = read.ReadToEnd().Replace("\r", "").Split(';', '\n');
        }

        // WHAT A...
        void PreencherArvContasEListaPessoas()
        {
            Conta conta;
            int contPessoas = 0;

            for (int i = 0; i < dadosArquivo.Length; i += 3)
            {
                pessoas.Add(new Titular(dadosArquivo[i+1]));

                // Para as contas, tanto faz se a pessoa é repetida ou não.
                if (int.Parse(dadosArquivo[i + 2]) == 1)
                {
                    conta = new Energia(0, 0, dadosArquivo[i], 0, new Titular(dadosArquivo[i+1]));
                }
                else
                {
                    conta = new Agua(0, 0, dadosArquivo[i], 0, new Titular(dadosArquivo[i+1]));
                }

                pessoas[contPessoas].AdicionarConta(conta);
                contPessoas++;

                arvoreContas.Inserir(conta);
            }
        }

        // Remove pessoas repetidas e acrescenta contas (água e energia) para um único registro de pessoa.
        void NormalizarListaPessoas()
        {
            List<int> posRepet = new List<int>();

            for (int i = 0; i < pessoas.Count; i++)
            {
                for (int j = 0; j < pessoas.Count; j++)
                {
                    if (i == j)
                    {
                        if (i == pessoas.Count-1) break;

                        j++;
                    }

                    if (pessoas[i].Equals(pessoas[j]))
                    {
                        posRepet.Add(j);
                    }
                }

                if (posRepet.Count != 0)
                {
                    for (int k = 0; k < posRepet.Count; k++)
                    {
                        pessoas[i].AdicionarConta(pessoas[posRepet[k]].Contas[0]);

                        pessoas.RemoveAt(posRepet[k]);

                        if (k == posRepet.Count - 1) break;
                        if (posRepet[k + 1] != 0)
                        {
                            for (int l = 0; l < posRepet.Count; l++)
                            {
                                posRepet[l]--;
                            }
                        }
                    }

                    posRepet = new List<int>();
			    }
			 
			}
        }

        void PreencheArvPessoas()
        {
            for (int i = 0; i < pessoas.Count; i++)
            {
                arvorePessoa.Inserir(pessoas[i]);
            }
        }

        

        private void cadIDbtn_Click(object sender, EventArgs e)
        {
            string idProcurado = cadIDtxtB.Text;

            if (idProcurado != null)
            {
                listView1.Items.Clear();

                Conta encontrado = (Conta)arvoreContas.Buscar(int.Parse(idProcurado));

                if (encontrado == null)
                    MessageBox.Show("Não encontrado.");
                else
                {
                    ListViewItem item;

                    item = new ListViewItem();

                    item.Text = (encontrado.Titular.Cpf);
                    item.SubItems.Add(encontrado.Id);
                    listView1.Items.Add(item);
                    
                }
            }
            else
            {
                MessageBox.Show("Informe um valor para ser procurado!");
            }

        }

        private void cadCPFbtn_Click(object sender, EventArgs e)
        {
            String cpfProcurado = cadCPFtxtB.Text;

            if (cpfProcurado.Substring(11) != "-")
            {
                listView1.Items.Clear();

                cpfProcurado = cpfProcurado.Replace(',', '.');

                Titular aux = new Titular(cpfProcurado);

                IDado encontrado = arvorePessoa.Buscar(aux);

                if (encontrado == null)
                    MessageBox.Show("Não encontrado.");
                else
                {

                    Titular titularEncontrado = (Titular)(encontrado);

                    ListViewItem item;

                    for (int i = 0; i < titularEncontrado.Contas.Count; i++)
                    {
                        item = new ListViewItem();

                        item.Text = (titularEncontrado.Cpf);
                        item.SubItems.Add(titularEncontrado.Contas[i].Id.ToString());
                        listView1.Items.Add(item);
                    }
                }
            }
            else
                MessageBox.Show("Informe um valor para ser procurado!");
        }
    }
}
