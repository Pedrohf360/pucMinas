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
        Random r = new Random(); // O filósofo irá comer e pensar por períodos de tempo randômico

        public Filosofo(string nome, int posMesa, Garfo garfoDir, Garfo garfoEsq, Random r)
        {
            this.nome = nome;
            this.posMesa = posMesa;
            this.garfoDir = garfoDir;
            this.garfoEsq = garfoEsq;

            this.r = r;

            Console.WriteLine("O filósofo {0} sentou-se à mesa na posição {1}.+", this.nome, this.posMesa);
        }

        public void Pensar()
        {
            Console.WriteLine("O filósofo " + this.nome + " está pensando.");
            Thread.Sleep(r.Next(300, 500));   
        }

        public void Comer()
        {
            while (true)
            {
                if (garfos.GarfoDir == 5)
                {
                    Console.WriteLine("O filósofo " + this.nome + " pegou o garfo " + garfos.GarfoDir);

                    if (garfos.GarfoEsq == 1)
                    {
                        Console.WriteLine("O filósofo " + this.nome + " pegou o garfo " + garfos.GarfoEsq);
                        Console.WriteLine("O filósofo " + this.nome + " está comendo...");
                        Thread.Sleep(r.Next(500, 800));
                        Console.WriteLine("O filósofo " + this.nome + " largou o garfo da direita.");
                        Console.WriteLine("O filósofo " + this.nome + " largou o garfo da esquerda.");
                    }
                    else
                    {
                        Console.WriteLine("O filósofo " + this.nome + " largou o garfo " + garfos.GarfoDir);
                    }
                }
                else
                {
                    try
                    {
                        Pensar();
                    }
                    catch (ThreadInterruptedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            
        }
    }
}