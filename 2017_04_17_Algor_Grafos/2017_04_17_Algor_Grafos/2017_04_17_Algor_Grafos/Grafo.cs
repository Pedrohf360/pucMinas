using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_17_Algor_Grafos
{
    public class Grafo
    {
        int quantVertices;
        string[] conteudoArquivo;
        bool direcinado;

        List<Vertice> listaVertice;
        List<Aresta> listaAresta;

        public Grafo(string[] conteudoArquivo)
        {
            this.quantVertices = int.Parse(conteudoArquivo[0]);
            this.conteudoArquivo = conteudoArquivo;

            this.listaVertice = new List<Vertice>();
            this.listaAresta = new List<Aresta>();
        }

        public Vertice ProcurarVertice(Vertice v)
        {
            for (int i = 0; i < listaVertice.Count; i++)
            {
                if (listaVertice[i].Nome == v.Nome)
                {
                    return listaVertice[i];
                }
            }

            return null;
        }

        public bool IsAdjacente(Vertice v1, Vertice v2)
        {
            for (int i = 0; i < this.listaVertice.Count; i++)
            {
                if (this.listaVertice[i].Nome == v1.Nome)
                {
                    for (int j = 0; j < this.listaVertice[i].Adjacente.Count; j++)
                    {
                        if (this.listaVertice[i].Adjacente[j].Nome == v2.Nome)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            string str = "";

            for (int i = 0; i < conteudoArquivo.Length; i++)
            {
                str = conteudoArquivo[i];
            }

            return str;
        }

        public int QuantVertices { get => quantVertices; set => quantVertices = value; }
        public string[] ConteudoArquivo { get => conteudoArquivo; set => conteudoArquivo = value; }
        public bool Direcinado { get => direcinado; set => direcinado = value; }
        public List<Vertice> ListaVertice { get => listaVertice; set => listaVertice = value; }
        internal List<Aresta> ListaAresta { get => listaAresta; set => listaAresta = value; }
    }
}
