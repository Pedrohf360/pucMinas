using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_17_Algor_Grafos
{
    public class Vertice
    {
        private string nome;
        private List<Vertice> adjacente;
        private List<Aresta> aresta;

        public Vertice(string nome)
        {
            this.nome = nome;
            this.adjacente = new List<Vertice>();
            this.aresta = new List<Aresta>();
        }

        public void AdicionarAdjacente(Vertice vertice)
        {
            this.adjacente.Add(vertice);
        }

        public void AdicionarAresta(Aresta aresta)
        {
            this.aresta.Add(aresta);
        }

        public Vertice GetAdjacente(Vertice vertice)
        {
            for (int i = 0; i < this.adjacente.Count; i++)
            {
                if (vertice.nome == this.adjacente[i].nome)
                {
                    return this.adjacente[i];
                }
            }

            return null;
        }

        public Aresta GetArestaLigacao(Vertice vertice, List<Aresta> arestas)
        {
            for (int i = 0; i < this.aresta.Count; i++)
            {
                if (this.aresta[i].VertA.nome == vertice.nome)
                    return this.aresta[i];

                if (this.aresta[i].VertB.nome == vertice.nome)
                    return this.aresta[i];
            }

            for (int i = 0; i < arestas.Count; i++)
            {

            }

            return aresta[0];
        }



        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        internal List<Vertice> Adjacente { get => adjacente; set => adjacente = value; }
        public List<Aresta> Aresta { get => aresta; set => aresta = value; }
    }
}
