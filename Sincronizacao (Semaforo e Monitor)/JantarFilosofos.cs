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

            BarraProgresso(13);
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

            BarraProgresso(20);

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
    }

    class Garfo
    {
        int posicao;
        bool ocupado;

        public Garfo(int pos)
        {
            this.posicao = pos;
            this.ocupado = false;
        }

        public int Posicao
        {
            get
            {
                Monitor.Enter(this);

                if (this.ocupado)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nO Filósofo " + Thread.CurrentThread.Name + " está aguardando para usar o garfo {0}. ", this.posicao + ".");
                    Console.ResetColor();

                    Monitor.Wait(this);
                }

                Console.ResetColor();
                this.ocupado = true;

                Console.WriteLine("\nO Filósofo " + Thread.CurrentThread.Name + " pegou o garfo " + this.posicao + ".");

                Monitor.Pulse(this);

                Monitor.Exit(this);

                return this.posicao;
            }
        }

        public bool Ocupado
        {
            get
            {
                return ocupado;
            }

            set
            {
                Monitor.Enter(this);

                this.ocupado = value;

                Console.ResetColor();
                Console.WriteLine("\nO Filósofo " + Thread.CurrentThread.Name + " largou o garfo " + this.posicao + ".");

                Monitor.Pulse(this);
                Monitor.Exit(this);
            }
        }
    }

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
