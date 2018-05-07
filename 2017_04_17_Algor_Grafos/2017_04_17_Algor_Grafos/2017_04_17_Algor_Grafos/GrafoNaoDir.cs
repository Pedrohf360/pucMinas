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
                if (conteudoLinha[0] == "") continue;
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
            v1 = ProcurarVertice(v1);

            if (v1 == null)
            {
                return -1;
            }

            return v1.Aresta.Count;
        }

        public bool IsIsolado(Vertice v1)
        {
            if (this.ProcurarVertice(v1) == null)
            {
                return false;
            }

            return v1.Adjacente.Count == 0;
        }

        public bool IsPendente(Vertice v1)
        {
            v1 = ProcurarVertice(v1);

            if (v1 == null)
            {
                return false;
            }

            return this.GetGrau(v1) == 1;
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

        public bool IsCompleto()
        {
            for (int i = 0; i < this.ListaVertice.Count; i++)
            {
                for (int j = 0; j < this.ListaVertice.Count; j++)
                {
                    if (j == i)
                        continue;
                    if (!this.IsAdjacente(this.ListaVertice[i], this.ListaVertice[j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // ESTE TRATAMENTO DEVE SER FEITO UMA ÚNICA VEZ QUANDO O CLIENTE ESCOLHER A OPÇÃO DE OBTER CAMINHO
        //// Os vértices v1 e v2 devem existir no grafo.
        //if (v1 == null)
        //{
        //    return null;
        //}

        //v2 = ProcurarVertice(v2);

        //if (v2 == null)
        //{
        //    return null;
        //}

        /// <summary>
        /// Retorna "Null" se não houver caminho possível.
        /// </summary>
        /// <returns></returns>
        public string GetCaminho(Vertice origem, Vertice vertAux, Vertice destino, List<String> caminho, int index, List<Vertice> visitados)
        {
            Aresta arestaAux;

            vertAux = origem;
            arestaAux = vertAux.GetArestaLigacao(destino, null);
            if (arestaAux.VertA != destino && arestaAux.VertB != destino)
            {
                if (arestaAux.VertA != vertAux)
                {
                    vertAux = arestaAux.VertA;
                } else
                {
                    vertAux = arestaAux.VertB;
                }

            } else
            {
                return arestaAux.ToString();
            }

            //for (int i = 0; i < this.aresta.Count; i++)
            //{
            //    if (this.aresta[i].VertA.nome == vertice.nome)
            //        return this.aresta[i];

            //    if (this.aresta[i].VertB.nome == vertice.nome)
            //        return this.aresta[i];
            //}

            caminho.Add(arestaAux.ToString());

            // Regra de formação
            GetCaminho(vertAux, null, destino, caminho, index, null);

            return arestaAux.ToString();
        }

        public bool IsConexo()
        {
            int pos = 0;

            List<string> caminho = new List<string>();
            List<Vertice> visitados = new List<Vertice>();
            this.GetCaminho(this.ListaVertice[0], null, this.ListaVertice[3], caminho, pos, visitados);

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
