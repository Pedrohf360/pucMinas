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
        static void CriarGarfos(int quantidade, Garfo[] vetorGarfos)
        {
            for (int i = 0; i < vetorGarfos.Length; i++)
            {
                vetorGarfos[i] = new Garfo(i+1);
            }
        }

        static void Main(string[] args)
        {

            Console.WriteLine("\t------------Monitor - Jantar dos Filósofos------------");
            Console.WriteLine("\nGRUPO:\tNOME:\t\t\tMATRICULA:" +
                            "\n\tPedro Henrique\t\t580544" +
                            "\n\tLucas Gomes\t\t578927" +
                            "\n\tHenrique Kirschke\t573948" +
                            "\n\tItalo Fabricio\t\t573962\n");

            Random rand = new Random();

            Garfo[] garfos = new Garfo[5];

            CriarGarfos(5, garfos);

            Filosofo[] filosofos = new Filosofo[5];

            //MesaJantar mesa = new MesaJantar(filosofos, garfos, rand);

            filosofos[0] = new Filosofo("Platão", 1, garfos[4], garfos[0], rand);
            filosofos[1] = new Filosofo("Aristóteles", 2, garfos[0], garfos[1], rand);
            filosofos[2] = new Filosofo("Sócrates", 3, garfos[1], garfos[2], rand);
            filosofos[3] = new Filosofo("Descartes", 4, garfos[2], garfos[3], rand);
            filosofos[4] = new Filosofo("Euclides", 5, garfos[3], garfos[4], rand);

            Thread[] threads = new Thread[5];
            threads[0] = new Thread(new ThreadStart(filosofos[0].Comer));
            threads[1] = new Thread(new ThreadStart(filosofos[1].Comer));
            threads[2] = new Thread(new ThreadStart(filosofos[2].Comer));
            threads[3] = new Thread(new ThreadStart(filosofos[3].Comer));
            threads[4] = new Thread(new ThreadStart(filosofos[4].Comer));


            foreach (Thread t in threads)
                t.Start();

            Thread.Sleep(30000);

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
