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
        Garfo garfos;

        public Filosofo(string nome, Garfo garfos)
        {
            this.nome = nome;
            this.garfos = garfos;

            Console.WriteLine("O filósofo " + this.nome + " sentou-se à mesa.");
        }

        public void Pensar()
        {
            Console.WriteLine("O filósofo " + this.nome + " está pensando.");
            Thread.Sleep(1000);   
        }

        public void Comer()
        {
            int esquerda, direita;

            esquerda = garfos.SortearGarfoEsq();
            direita = garfos.SortearGarfoDir();

            if (esquerda == cc)
            {
                Console.WriteLine("O filósofo " + this.nome + " pegou o garfo " + this.garfoDir);

                if (esquerda == this.)
                {
                    Console.WriteLine("O filósofo " + this.nome + " pegou o garfo " + this.garfoEsq);
                    Console.WriteLine("O filósofo " + this.nome + " está comendo...");
                    Thread.Sleep(1000);
                    Console.WriteLine("O filósofo " + this.nome + " largou o garfo da direita.");
                    Console.WriteLine("O filósofo " + this.nome + " largou o garfo da esquerda.");
                }
                else
                {
                    Console.WriteLine("O filósofo " + this.nome + " largou o garfo " + esquerda);
                }
            } else {
                try
                {
                    Pensar();
                } catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}