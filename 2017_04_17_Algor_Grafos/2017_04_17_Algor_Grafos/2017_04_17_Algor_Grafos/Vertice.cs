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
