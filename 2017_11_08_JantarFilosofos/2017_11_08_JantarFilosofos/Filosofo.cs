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

            Console.WriteLine("O Filósofo {0} sentou-se à mesa na posição {1}.", this.nome, this.posMesa);
        }

        public void Pensar()
        {
            Console.WriteLine("O Filósofo " + this.nome + " está pensando.");
            Thread.Sleep(r.Next(300, 500));   
        }

        public void Comer()
        {
            int[] garfo = new int[2];

            while (true)
            {

                garfo[0] = this.r.Next(this.garfoDir.Posicao, this.garfoDir.Posicao); // Direita
                garfo[1] = this.r.Next(this.garfoDir.Posicao, this.garfoEsq.Posicao); // Esquerda

                if (this.GarfoDir.Posicao == garfo[0])
                {
                    if (this.GarfoDir.Ocupado)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", this.GarfoDir.Posicao);
                        Console.ResetColor();
                    }

                    this.GarfoDir.Ocupado = true;

                    Console.WriteLine("O Filósofo " + this.Nome + " pegou o garfo " + this.GarfoDir.Posicao);

                    if (this.GarfoEsq.Posicao == garfo[1])
                    {
                        if (this.GarfoEsq.Ocupado)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", this.GarfoEsq.Posicao);
                            Console.ResetColor();
                        }

                        this.GarfoEsq.Ocupado = true;

                        Console.WriteLine("O Filósofo " + this.Nome + " pegou o garfo " + this.GarfoEsq.Posicao);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("O Filósofo " + this.Nome + " está comendo...");
                        Console.ResetColor();
                        Thread.Sleep(this.r.Next(1000, 2000));
                        Console.WriteLine("O Filósofo " + this.Nome + " largou o garfo da direita.");
                        Console.WriteLine("O Filósofo " + this.Nome + " largou o garfo da esquerda.");
                        this.GarfoDir.Ocupado = false;
                        this.GarfoEsq.Ocupado = false;
                    }
                    else
                    {
                        Console.WriteLine("O Filósofo " + this.Nome + " largou o garfo " + this.GarfoDir.Posicao);
                        this.GarfoDir.Ocupado = false;
                    }
                }
                else
                {
                    this.Pensar();
                }
            }
        }
    }
}
