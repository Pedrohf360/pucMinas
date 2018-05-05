using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_17_Algor_Grafos
{
    class GrafoDirigido : Grafo, IGrafoDirigido
    {
        public GrafoDirigido(string[] conteudoArquivo) : base(conteudoArquivo)
        {
            this.PreencherGrafo();
        }

        private void PreencherGrafo()
        {
            string[] conteudoLinha;
            int pesoAresta;
            Vertice novoVertA, novoVertB;
            Vertice novoVertAaux, novoVertBaux;
            Aresta novaAresta;

            int direcaoAresta;

            // Variável 'i' começa com o valor '1', porque a 1a linha contém a qtd de vértices do grafo
            for (int i = 1; i < this.ConteudoArquivo.Length; i++)
            {
                conteudoLinha = this.ConteudoArquivo[i].Split(';');
                novoVertA = new Vertice(conteudoLinha[0]);
                novoVertB = new Vertice(conteudoLinha[1]);

                novoVertAaux = this.ProcurarVertice(novoVertA);
                novoVertBaux = this.ProcurarVertice(novoVertB);

                // Só adiciona vértice na lista se ainda não existe.
                if (novoVertAaux == null)
                {
                    this.ListaVertice.Add(novoVertA);
                }
                else
                {
                    novoVertA = novoVertAaux;
                }

                if (novoVertBaux == null)
                {
                    this.ListaVertice.Add(novoVertB);
                }
                else
                {
                    novoVertB = novoVertBaux;
                }

                // Se um vértice não consta na lista de adjacência do outro,
                // são chamados os métodos para de adicionar adjacente para o vértice A e B
                if (!this.IsAdjacente(novoVertA, novoVertB))
                {
                    novoVertA.AdicionarAdjacente(novoVertB);
                    novoVertB.AdicionarAdjacente(novoVertA);
                }


                pesoAresta = int.Parse(conteudoLinha[2]);
                direcaoAresta = int.Parse(conteudoLinha[3]);
                novaAresta = new Aresta(pesoAresta, novoVertA, novoVertB, direcaoAresta);

                this.ListaAresta.Add(novaAresta);

                novoVertA.AdicionarAresta(novaAresta);
                novoVertB.AdicionarAresta(novaAresta);
            }
        }


        public int GetGrauEntrada(Vertice v1)
        {
            return 1;
        }

        public int GetGrauSaida(Vertice v1)
        {
            return 1;
        }

        public bool HasCiclo()
        {
            return true;
        }
    }
}
