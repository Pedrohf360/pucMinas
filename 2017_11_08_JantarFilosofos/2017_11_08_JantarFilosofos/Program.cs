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
        static void Main(string[] args)
        {
            Console.WriteLine("\t------------Monitor - Jantar dos Filósofos------------");
            Console.WriteLine("\nGRUPO:\tNOME:\t\t\tMATRICULA:" +
                            "\n\tPedro Henrique\t\t580544" +
                            "\n\tLucas Gomes\t\t578927" +
                            "\n\tHenrique Kirschke\t573948" +
                            "\n\tItalo Fabricio\t\t573962\n");

            Semaphore semaph = new Semaphore(1, 1);

            Garfo[] garfos = new Garfo[5];

            garfos[0] = new Garfo(1, 2);
            garfos[1] = new Garfo(2, 3);
            garfos[2] = new Garfo(3, 4);
            garfos[3] = new Garfo(4, 5);
            garfos[4] = new Garfo(5, 1);

            Filosofo[] filosofos = new Filosofo[5];
            filosofos[0] = new Filosofo("Platão", garfos[0]);
            filosofos[1] = new Filosofo("Aristóteles", garfos[1]);
            filosofos[2] = new Filosofo("Sócrates", garfos[2]);
            filosofos[3] = new Filosofo("Descartes", garfos[3]);
            filosofos[4] = new Filosofo("Euclides", garfos[4]);

            Thread[] threads = new Thread[5];

            threads[0] = new Thread(new ThreadStart(filosofos[0].TentarComer));
            threads[1] = new Thread(new ThreadStart(filosofos[1].TentarComer));
            threads[2] = new Thread(new ThreadStart(filosofos[2].TentarComer));
            threads[3] = new Thread(new ThreadStart(filosofos[3].TentarComer));
            threads[4] = new Thread(new ThreadStart(filosofos[4].TentarComer));

            threads[0].Start();
            threads[1].Start();
            threads[2].Start();
            threads[3].Start();
            threads[4].Start();

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey();       
        }
    }
}
