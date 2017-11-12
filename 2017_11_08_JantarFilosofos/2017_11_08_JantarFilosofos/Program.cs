using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_08_JantarFilosofos
{
    class Program
    {
        static Random r = new Random();

        static void CriarGarfos(int quantidade, Garfo[] vetorGarfos)
        {
            for (int i = 0; i < vetorGarfos.Length; i++)
            {
                vetorGarfos[i] = new Garfo(i+1);
            }
        }

        static void ImprimirLegendaCores()
        {
            Console.WriteLine("\t\t\t\t\tLEGENDA:\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  -> AGUARDANDO PARA UTILIZAR GARFO;");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t-> COMENDO;");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\t-> TERMINOU DE COMER.");
            Console.ResetColor();

            BarraProgresso(12);
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
                Thread.Sleep(r.Next(50, 200));
                contProgressBar += charProgressBar.Length;

                Thread.Sleep(r.Next(50, 200));
                Console.SetCursorPosition(0, alturaInicio);
                Console.WriteLine("/");
                Thread.Sleep(r.Next(50, 200));
                Console.SetCursorPosition(0, alturaInicio);
                Console.WriteLine("-");
                Thread.Sleep(r.Next(50, 200));
                Console.SetCursorPosition(0, alturaInicio);
                Console.WriteLine("\\");
                Thread.Sleep(r.Next(50, 200));

            }
        }

        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            Console.WriteLine("\t------------Monitor - Jantar dos Filosofos------------");
            Console.WriteLine("\nGRUPO:\tNOME:\t\t\tMATRICULA:" +
                            "\n\tPedro Henrique\t\t580544" +
                            "\n\tLucas Gomes\t\t578927" +
                            "\n\tHenrique Kirschke\t573948" +
                            "\n\tItalo Fabricio\t\t573962\n");

            Random rand = new Random();

            Garfo[] garfos = new Garfo[5];

            CriarGarfos(5, garfos);

            Filosofo[] filosofos = new Filosofo[5];

            ImprimirLegendaCores();

            filosofos[0] = new Filosofo("Platao", 1, garfos[4], garfos[0], rand);
            filosofos[1] = new Filosofo("Aristoteles", 2, garfos[0], garfos[1], rand);
            filosofos[2] = new Filosofo("Socrates", 3, garfos[1], garfos[2], rand);
            filosofos[3] = new Filosofo("Descartes", 4, garfos[2], garfos[3], rand);
            filosofos[4] = new Filosofo("Euclides", 5, garfos[3], garfos[4], rand);

            BarraProgresso(19);

            Console.WriteLine();

            Thread[] threads = new Thread[5];
            threads[0] = new Thread(new ThreadStart(filosofos[0].Comer));
            threads[1] = new Thread(new ThreadStart(filosofos[1].Comer));
            threads[2] = new Thread(new ThreadStart(filosofos[2].Comer));
            threads[3] = new Thread(new ThreadStart(filosofos[3].Comer));
            threads[4] = new Thread(new ThreadStart(filosofos[4].Comer));

            threads[0].Name = "Platao";
            threads[1].Name = "Aristoteles";
            threads[2].Name = "Socrates";
            threads[3].Name = "Descartes";
            threads[4].Name = "Euclides";


            foreach (Thread t in threads)
                t.Start();

            Thread.Sleep(10000);

            foreach (Thread t in threads)
                t.Abort();

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey();       
        }

        //Thread[] threads = new Thread[5];

        //threads[0] = new Thread(new ThreadStart(filosofos[0].TentarComer));
        //threads[1] = new Thread(new ThreadStart(filosofos[1].TentarComer));
        //threads[2] = new Thread(new ThreadStart(filosofos[2].TentarComer));
        //threads[3] = new Thread(new ThreadStart(filosofos[3].TentarComer));
        //threads[4] = new Thread(new ThreadStart(filosofos[4].TentarComer));
    }
}
