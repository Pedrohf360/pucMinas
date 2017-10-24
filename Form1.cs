using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Leitor_Contas.Classes;
namespace Leitor_Contas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Arvore pessoas = new Arvore();
        private Arvore contas = new Arvore();
        private void btnabrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                if(Path.GetExtension(open.FileName) == ".TXT")
                {
                    try
                    {
                        using(StreamReader read = new StreamReader(open.FileName))
                        {
                            string line;
                            while((line = read.ReadLine()) != null)
                            {
                                string[] spt = line.Split(';');
                                Titular pessoa = new Titular(spt[1]);
                                ListViewItem item1 = new ListViewItem();
                                item1.Text = spt[0];
                                Conta conta;
                                if (spt[2] == "1")
                                {
                                    conta = new Energia(int.Parse(spt[0]), 0, 0, 0, pessoa);
                                    item1.SubItems.Add("Energia");
                                }
                                else
                                {
                                    conta = new Agua(int.Parse(spt[0]), 0, 0, 0, pessoa);
                                    item1.SubItems.Add("Agua");
                                }
                                pessoa.AddConta(conta);
                                contas.Inserir(conta);
                                listcontas.Items.Add(item1);
                                pessoas.Inserir(pessoa);

                                ListViewItem item = new ListViewItem();
                                item.Text = spt[1];
                                item.SubItems.Add(spt[2]);
                                listpeople.Items.Add(item);
                            }
                        }
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                        
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
