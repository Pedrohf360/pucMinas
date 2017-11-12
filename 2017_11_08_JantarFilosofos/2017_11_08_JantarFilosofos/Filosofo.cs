using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_08_JantarFilosofos
{
    class Filosofo
    {
        string nome;
        int posMesa;
        Garfo garfoEsq;
        Garfo garfoDir;
        Random r = new Random(); // O Filósofo irá comer e pensar por períodos de tempo randômico

        public string Nome { get => nome; set => nome = value; }
        public int PosMesa { get => posMesa; set => posMesa = value; }
        internal Garfo GarfoEsq { get => garfoEsq; set => garfoEsq = value; }
        internal Garfo GarfoDir { get => garfoDir; set => garfoDir = value; }

        public Filosofo(string nome, int posMesa, Garfo garfoDir, Garfo garfoEsq, Random r)
        {
            this.nome = nome;
            this.posMesa = posMesa;
            this.garfoDir = garfoDir;
            this.garfoEsq = garfoEsq;

            this.r = r;

            Console.WriteLine("O Filósofo {0} sentou-se à mesa na posicao {1}.", this.nome, this.posMesa);
        }

        public void Pensar()
        {
            Console.ResetColor();
            Console.WriteLine("\nO Filósofo " + this.nome + " está pensando.");
            Thread.Sleep(r.Next(300, 500));   
        }

        public void Comer()
        {
            int verifDisponDir;
            int verifDisponEsq;

            while (true)
            {
                Pensar();
                verifDisponEsq = GarfoEsq.Posicao;
                verifDisponDir = GarfoDir.Posicao;

                if (verifDisponDir != 0 && verifDisponEsq != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nO Filósofo " + this.nome + " está comendo.");
                    Console.ResetColor();
                }

                Thread.Sleep(this.r.Next(1000, 2000));

                garfoDir.Ocupado = false;
                garfoEsq.Ocupado = false;
                verifDisponEsq = 0;
                verifDisponDir = 0;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nO Filósofo " + this.nome + " terminou de comer.");
                Console.ResetColor();
            }
        }
    }
}
