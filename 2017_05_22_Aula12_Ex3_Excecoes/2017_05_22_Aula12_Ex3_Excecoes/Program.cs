using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_22_Aula12_Ex3_Excecoes
{
    class Program
    {
        static void PreencherVetor(int[] soVetorMalucoFormat)
        {
            Boolean verifErro = false;

            Console.WriteLine();

            do
            {
                Console.WriteLine("Digite 10 número para preencher o vetor:\n");
                try
                {
                    for (int i = 0; i < soVetorMalucoFormat.Length; i++)
                    {
                        do
                        {
                            try
                            {
                                verifErro = false;

                                Console.Write(i + 1 + ") ");

                                soVetorMalucoFormat[i] = int.Parse(Console.ReadLine());
                            }
                            catch (FormatException forex)
                            {
                                Console.WriteLine("\n" + forex.Message);
                                verifErro = true;

                                Console.WriteLine("\nPressione qualquer tecla para prosseguir!");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Digite 10 número para preencher o vetor:\n");
                            }
                            catch (IndexOutOfRangeException inex)
                            {
                                Console.WriteLine("\n" + inex.Message);
                                verifErro = true;

                                Console.WriteLine("\nPressione qualquer tecla para prosseguir!");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Digite 10 número para preencher o vetor:\n");
                            }
                            catch
                            {
                                Console.WriteLine("\nDeu erro, parceiro!");
                                verifErro = true;

                                Console.WriteLine("\nPressione qualquer tecla para prosseguir!");
                                Console.ReadKey();
                                Console.Clear();

                                Console.WriteLine("Digite 10 número para preencher o vetor:\n");
                            }
                        } while (verifErro == true);
                    }
                }
                catch (IndexOutOfRangeException inex)
                {
                    Console.WriteLine("\n" + inex.Message);
                    verifErro = true;

                    Console.WriteLine("\nPressione qualquer tecla para prosseguir!");
                    Console.ReadKey();
                    Console.Clear();
                    PreencherVetor(soVetorMalucoFormat);
                }
            } while (verifErro == true);

                Console.WriteLine();
        }
    

        static void ImprimirVetor(int[] aquiTambemSoVetorMalucoFormat)
        {
            Console.WriteLine("\nVUALÁ!!");

            Console.WriteLine();

            foreach (int i in aquiTambemSoVetorMalucoFormat)
            {
                Console.WriteLine(i);
            }
        }

        static double MediaAritmetica(int[] oMaiorNomeDeVetorDaHistoriaVoceSoEncontraAquiAewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww)
        {
            double soma = 0;
            double resultado;

            for (int i = 0; i < oMaiorNomeDeVetorDaHistoriaVoceSoEncontraAquiAewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww.Length; i++)
            {
                soma += oMaiorNomeDeVetorDaHistoriaVoceSoEncontraAquiAewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww[i];
            }

            resultado = soma / oMaiorNomeDeVetorDaHistoriaVoceSoEncontraAquiAewwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww.Length;

            return resultado;
        }

        static void Main(string[] args)
        {
            int[] vetorMaluco = new int[10];

            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();

            PreencherVetor(vetorMaluco);

            Console.WriteLine("Deseja imprimir o vetor? (Y/N)");

            keyinfo = Console.ReadKey(true);

            if (keyinfo.Key == ConsoleKey.Y)
                ImprimirVetor(vetorMaluco);

            Console.WriteLine("\nPressione qualquer tecla para continuar.");
            Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine("Deseja ver a média aritmética dos valores digitados? (Y/N)");

            keyinfo = Console.ReadKey(true);

            if (keyinfo.Key == ConsoleKey.Y)
                Console.WriteLine("\nMédia Aritmética: " + MediaAritmetica(vetorMaluco));

            Console.WriteLine("\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }
}
