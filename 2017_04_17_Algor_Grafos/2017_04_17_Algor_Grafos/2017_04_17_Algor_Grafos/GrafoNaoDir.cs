using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_17_Algor_Grafos
{
    class GrafoNaoDir : Grafo, IGrafoNaoDir
    {

        public GrafoNaoDir(string[] conteudoArquivo) : base(conteudoArquivo)
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
                novaAresta = new Aresta(pesoAresta, novoVertA, novoVertB);

                this.ListaAresta.Add(novaAresta);

                novoVertA.AdicionarAresta(novaAresta);
                novoVertB.AdicionarAresta(novaAresta);
            }
        }

        public int GetGrau(Vertice v1)
        {
            return v1.Aresta.Count;
        }

        public bool IsIsolado(Vertice v1)
        {
            return v1.Adjacente.Count == 0;
        }

        public bool IsPendente(Vertice v1)
        {
            return v1.Adjacente.Count == 1;
        }

        public bool IsRegular()
        {
            int grauPrimVert = this.GetGrau(this.ListaVertice[0]);

            for (int i = 1; i < this.ListaVertice.Count; i++)
            {
                if (this.GetGrau(ListaVertice[i]) != grauPrimVert)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsNulo()
        {
            for (int i = 0; i < this.ListaVertice.Count; i++)
            {
                if (!this.IsIsolado(this.ListaVertice[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public bool isCompleto()
        {
            
        }

        public bool IsConexo()
        {
            return true;
        }

        public bool IsEuleriano()
        {
            return true;
        }

        public bool IsUnicursal()
        {
            return true;
        }

        public Grafo GetComplementar()
        {
            return new Grafo(new string[] { "1", "2" });
        }

        public Grafo GetAGMPrim(Vertice v1)
        {
            return new Grafo(new string[] { "1", "2" });
        }

        public Grafo GetAGMKruskal(Vertice v1)
        {
            return new Grafo(new string[] { "1", "2" });
        }




    }
}
