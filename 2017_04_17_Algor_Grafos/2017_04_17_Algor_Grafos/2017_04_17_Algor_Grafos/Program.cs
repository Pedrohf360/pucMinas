using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace _2017_04_17_Algor_Grafos
{
    class Program
    {
        public static void ImprimirGrafo(Grafo g)
        {
            Console.WriteLine(g.ToString());
        }

        // Se as linhas com informações sobre os vértices possuírem 4
        // caracteres separados por vírgula, temos um grafo direcionado.
        public static bool IsDirecionado(string textoLinha)
        {
            string[] vet = textoLinha.Split(';');

            if (vet.Length == 4)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public static Grafo CriarGrafo(bool direcionado, string[] conteudoArquivo)
        {
            Grafo grafo;

            if (direcionado)
            {
                return grafo = new GrafoDirigido(conteudoArquivo);
            } else
            {
                return grafo = new GrafoNaoDir(conteudoArquivo);
            }
        }

        static void Main(string[] args)
        {
            // Classe para acesso aos dados (Data Access Object).
            ArquivoDAO arqDAO;
            string nomeArq;
            bool grafoDirecionado;
            Grafo grafo;

            // Em cada do arquivo linha haverá informações de um vértice, sendo que o arquivo lido pode conter
            // informações de um grafo direcionado ou não-dir.
            // Exemplo: "3;2;5;-1" ou "3;2;5" em que "nomeVertice1; nomeVertice2; pesoAresta; direção".
            string[] conteudoArquivo;

            Console.WriteLine("Informe o nome do arquivo: ");
            nomeArq = Console.ReadLine();

            arqDAO = new ArquivoDAO(nomeArq);

            conteudoArquivo = arqDAO.LerAquivo();

            grafoDirecionado = IsDirecionado(conteudoArquivo[1]);

            grafo = CriarGrafo(grafoDirecionado, conteudoArquivo);

            ImprimirGrafo(grafo);

            Console.ReadKey();
        }
    }
}
