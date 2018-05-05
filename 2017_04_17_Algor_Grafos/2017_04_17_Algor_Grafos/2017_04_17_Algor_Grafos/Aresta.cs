using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_17_Algor_Grafos
{
    public class Aresta
    {
        private int peso;
        private Vertice vertA;
        private Vertice vertB;
        private int direcao;

        /// <summary>
        /// Constructor para grafos não-direcionados.
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="vertA"></param>
        /// <param name="vertB"></param>
        public Aresta(int peso, Vertice vertA, Vertice vertB)
        {
            this.peso = peso;
            this.vertA = vertA;
            this.vertB = vertB;
        }

        /// <summary>
        /// Construtor para grafos direcionados.
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="vertA"></param>
        /// <param name="vertB"></param>
        /// <param name="direcao"></param>
        public Aresta(int peso, Vertice vertA, Vertice vertB, int direcao)
        {
            this.peso = peso;
            this.vertA = vertA;
            this.vertB = vertB;
            this.direcao = direcao;
        }

        public int Peso { get => peso; set => peso = value; }
        public int Direcao { get => direcao; set => direcao = value; }
        internal Vertice VertA { get => vertA; set => vertA = value; }
        internal Vertice VertB { get => vertB; set => vertB = value; }
    }
}
