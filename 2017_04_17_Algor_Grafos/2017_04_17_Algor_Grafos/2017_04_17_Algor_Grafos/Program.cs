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
        static ArquivoDAO arqDAO;
        static Random r = new Random();
        static string nomeArq;
        static bool grafoDirecionado;

        static void ImprimirGrafo<T>(T grafo)
        {
            Console.WriteLine(grafo.ToString());
        }

        static void Responder(string resposta)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + resposta);
            Console.ResetColor();
        }

        // Se as linhas com informações sobre os vértices possuírem 4
        // caracteres separados por vírgula, temos um grafo direcionado.
        static bool IsDirecionado(string textoLinha)
        {
            string[] vet = textoLinha.Split(';');

            if (vet.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void CriarGrafo(bool direcionado, string[] conteudoArquivo, ref GrafoNaoDir grafoComum, ref GrafoDirigido digrafo)
        {
            arqDAO = new ArquivoDAO(nomeArq);

            conteudoArquivo = arqDAO.LerAquivo();

            grafoDirecionado = IsDirecionado(conteudoArquivo[1]);

            if (direcionado)
            {
                digrafo = new GrafoDirigido(conteudoArquivo);
            }
            else
            {
                grafoComum = new GrafoNaoDir(conteudoArquivo);
            }

            BarraProgresso(25);
        }

        static void BarraProgresso(int alturaInicio)

        {

            int contProgressBar = 1;

            string charProgressBar;


            for (int i = 8; i >= 1; i--)
            {
                Console.SetCursorPosition(0, alturaInicio);

                Console.WriteLine("|");

                charProgressBar = (new string('=', r.Next(5, 15)));

                Console.SetCursorPosition(contProgressBar, alturaInicio);

                Console.WriteLine(charProgressBar);

                Thread.Sleep(r.Next(10, 50));

                contProgressBar += charProgressBar.Length;

                Thread.Sleep(r.Next(10, 50));

                Console.SetCursorPosition(0, alturaInicio);

                Console.WriteLine("/");

                Thread.Sleep(r.Next(10, 50));

                Console.SetCursorPosition(0, alturaInicio);

                Console.WriteLine("-");

                Thread.Sleep(r.Next(10, 50));

                Console.SetCursorPosition(0, alturaInicio);

                Console.WriteLine("\\");

                Thread.Sleep(r.Next(10, 50));
            }

        }

        static void ImprimirMenu(bool grafoDirecionado)
        {
            if (grafoDirecionado)
            {
                Console.WriteLine("-1 - Sair.\n");
                Console.WriteLine("0 - Criar outro grafo.\n");
                Console.WriteLine("1 - Imprimir grafo.");
                Console.WriteLine("2 - Obter grau de entrada de um vértice.");
                Console.WriteLine("3 - Obter grau de saída de um vértice.");
                Console.WriteLine("4 - Verificar se possui ciclo.");
            }
            else
            {
                Console.WriteLine("-1 - Sair.\n");
                Console.WriteLine("0 - Criar outro grafo.\n");
                Console.WriteLine("1 - Imprimir grafo.");
                Console.WriteLine("2 - Verificar se dois vértices são adjacentes.");
                Console.WriteLine("3 - Obter grau de um vértice.");
                Console.WriteLine("4 - Verificar um vértice é pendente.");
                Console.WriteLine("5 - Verificar se o grafo é regular.");
                Console.WriteLine("6 - Verificar se o grafo é nulo.");
                Console.WriteLine("7 - Verificar se o grafo é completo.");
                Console.WriteLine("8 - Verificar se o grafo é conexo.");
                Console.WriteLine("9 - Verificar se o grafo é Euleriano.");
                Console.WriteLine("10 - Verificar se o grafo é Unicursal.");
                Console.WriteLine("11 - Obter grafo complementar.");
                Console.WriteLine("12 - Obter grafo AGM Prim.");
                Console.WriteLine("13 - Obter grafo AGM Kruskal.");
            }
        }

        static void ImprimirNomeGrupo()
        {
            Console.WriteLine("\t------------Exercício - Algoritmo em Grafos------------");

            Console.WriteLine("\nGRUPO:\tNOME:\t\t\t\tMATRICULA:" +

                            "\n\tPedro H. Ferreira Fonseca\t580544" +

                            "\n\tRayan Mateus Pereira Drummond\t573948" +

                            "\n\tLetícia Elias Bomfin Ramos\t573962\n");
        }


        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            ImprimirNomeGrupo();

            BarraProgresso(7);

            // Classe para acesso aos dados (Data Access Object).
            int opcaoMenu;
            string resposta;
            GrafoNaoDir grafoComum = null;
            GrafoDirigido digrafo = null;
            Vertice v1, v2;

            // Em cada do arquivo linha haverá informações de um vértice, sendo que o arquivo lido pode conter
            // informações de um grafo direcionado ou não-dir.
            // Exemplo: "3;2;5;-1" ou "3;2;5" em que "nomeVertice1; nomeVertice2; pesoAresta; direção".
            string[] conteudoArquivo;

            Console.WriteLine("Informe o nome do arquivo: ");
            nomeArq = Console.ReadLine();

            arqDAO = new ArquivoDAO(nomeArq);

            conteudoArquivo = arqDAO.LerAquivo();

            grafoDirecionado = IsDirecionado(conteudoArquivo[1]);

            CriarGrafo(grafoDirecionado, conteudoArquivo, ref grafoComum, ref digrafo);

            if (grafoDirecionado)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção:\n");
                    ImprimirMenu(grafoDirecionado);
                    Console.WriteLine();
                    opcaoMenu = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (opcaoMenu)
                    {
                        case 0:
                            Console.WriteLine("Informe o nome do arquivo: ");
                            nomeArq = Console.ReadLine();

                            CriarGrafo(grafoDirecionado, conteudoArquivo, ref grafoComum, ref digrafo);
                            break;
                        case 1:
                            ImprimirGrafo(digrafo);
                            break;
                        case 2:

                            break;

                        case 3:

                            break;

                        case 4:

                            break;


                        default:
                            if (opcaoMenu != -1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nA opção escolhida é inválida. Pressione qualquer tecla e tente novamente.");
                                Console.ResetColor();
                            }
                            break;
                    }
                    if (opcaoMenu != -1)
                    {
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                        Console.ReadKey();
                    }
                } while (opcaoMenu != -1);
            }
            else
            {
                string nomeVert;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Escolha uma opção:\n");
                    ImprimirMenu(grafoDirecionado);
                    Console.WriteLine();
                    opcaoMenu = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (opcaoMenu)
                    {
                        case 0:
                            Console.WriteLine("Informe o nome do arquivo: ");
                            nomeArq = Console.ReadLine();

                            CriarGrafo(grafoDirecionado, conteudoArquivo, ref grafoComum, ref digrafo);
                            break;
                        case 1:
                            ImprimirGrafo(grafoComum);
                            break;
                        case 2:
                            string nomeVert1, nomeVert2;
                            Console.WriteLine("Informe o nome do vértice 1:");
                            nomeVert1 = Console.ReadLine();
                            Console.WriteLine("\nInforme o nome do vértice 2:");
                            nomeVert2 = Console.ReadLine();

                            v1 = new Vertice(nomeVert1);
                            v2 = new Vertice(nomeVert2);

                            resposta = (grafoComum.IsAdjacente(v1, v2)) ? "Os vértices são adjacentes!" : "Os vértices não são adjacentes.";
                            Responder(resposta);
                            break;

                        case 3:
                            int grauVertice;
                            Console.WriteLine("Informe o nome do vértice:");
                            nomeVert = Console.ReadLine();

                            v1 = new Vertice(nomeVert);

                            grauVertice = grafoComum.GetGrau(v1);

                            resposta = (grauVertice == -1) ? "O vértice não existe!" : "O grau do vértice é " + grauVertice + ".";
                            Responder(resposta);
                            break;

                        case 4:
                            Console.WriteLine("Informe o nome do vértice:");
                            nomeVert = Console.ReadLine();

                            v1 = new Vertice(nomeVert);

                            resposta = (grafoComum.IsPendente(v1)) ? "O vértice é pendente!" : "O vértice não é pendente.";
                            Responder(resposta);
                            break;
                        case 5:
                            resposta = (grafoComum.IsRegular()) ? "O grafo é regular!" : "O grafo não é regular.";
                            Responder(resposta);
                            break;

                        case 6:
                            resposta = (grafoComum.IsNulo()) ? "O grafo é nulo!" : "O grafo não é nulo.";
                            Responder(resposta);
                            break;

                        case 7:
                            resposta = (grafoComum.IsCompleto()) ? "O grafo é completo!" : "O grafo não é completo.";
                            Responder(resposta);
                            break;
                        case 8:
                            resposta = (grafoComum.IsConexo()) ? "O grafo é conexo!" : "O grafo não é conexo.";
                            Responder(resposta);
                            break;

                        case 9:

                            break;

                        case 10:

                            break;
                        case 11:

                            break;

                        case 12:

                            break;

                        case 13:

                            break;

                        default:
                            if (opcaoMenu != -1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nA opção escolhida é inválida. Pressione qualquer tecla e tente novamente.");
                                Console.ResetColor();
                            }
                            break;
                    }
                    if (opcaoMenu != -1)
                    {
                        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
                        Console.ReadKey();
                    }

                } while (opcaoMenu != -1);
            }

            Console.ReadKey();
        }
    }
}
