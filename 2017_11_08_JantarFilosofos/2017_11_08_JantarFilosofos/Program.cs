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
            Semaphore semaph = new Semaphore(1, 1);

            Filosofo[] filosofos = new Filosofo[5];
            filosofos[0] = new Filosofo("Platão", 1, 5);
            filosofos[1] = new Filosofo("Aristóteles", 2, 1);
            filosofos[2] = new Filosofo("Sócrates", 3, 2);
            filosofos[3] = new Filosofo("Descartes", 4, 3);
            filosofos[4] = new Filosofo("Euclides", 5, 4);

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
