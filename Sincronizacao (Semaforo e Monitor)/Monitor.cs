using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_10_14_Monitor
{
    class Program
    {
        static Thread[] consumThreads = new Thread[3];
        static Thread[] prodThreads = new Thread[3];
        static Thread pauseThread;
        static int i = 0;
        static bool pause;

        static void PauseThreads()
        {
            ConsoleKeyInfo k = new ConsoleKeyInfo();

            k = Console.ReadKey(true);

            if (pause)
            {
                consumThreads[i].Resume();
                prodThreads[i].Resume();

                pause = false;

                pauseThread = new Thread(new ThreadStart(PauseThreads));
                pauseThread.Start();
            }
            else if (k.Key == ConsoleKey.T)
            {
                consumThreads[i].Suspend();

                prodThreads[i].Suspend();

                pause = true;

                pauseThread = new Thread(new ThreadStart(PauseThreads));
                pauseThread.Start();

                Console.WriteLine("\nPAUSADO...\nPara continuar, pressione qualquer tecla.");
            }
            
        }

        static void ContagemRegressiva(int quantSegundos, string textoContagem)
        {
            Console.Write(textoContagem+ " ");
            for (int i = quantSegundos; i > 0; i--)
            {
                Console.Write(i + ", ");

                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            int quantSegPause;

            consumThreads = new Thread[3];
            prodThreads = new Thread[3];

            Console.WriteLine("\t------------Monitor - MultiThreads------------");
            Console.WriteLine("\nGRUPO:\tNOME:\t\t\tMATRICULA:" +
                            "\n\tPedro Henrique\t\t580544" +
                            "\n\tLucas Gomes\t\t578927" +
                            "\n\tItalo Fabricio\t\t573962\n");

            ConsoleKeyInfo k = new ConsoleKeyInfo();

            Buffer buffer = new Buffer();

            Random random = new Random();

            pauseThread = new Thread(new ThreadStart(PauseThreads));

            Produtor[] prod = new Produtor[3];

            prod[0] = new Produtor(buffer, random, "Pedro H. - ", "580544");
            prod[1] = new Produtor(buffer, random, "Lucas G. - ", "578927");
            prod[2] = new Produtor(buffer, random, "Italo F. - ", "573962");

            Consumidor[] consum = new Consumidor[3];

            consum[0] = new Consumidor(buffer, random);
            consum[1] = new Consumidor(buffer, random);
            consum[2] = new Consumidor(buffer, random);

            
            prodThreads[0] = new Thread(new ThreadStart(prod[0].Produzir));
            prodThreads[1] = new Thread(new ThreadStart(prod[1].Produzir));
            prodThreads[2] = new Thread(new ThreadStart(prod[2].Produzir));

            prodThreads[0].Name = "Thread producao 1 ";
            prodThreads[1].Name = "Thread producao 2";
            prodThreads[2].Name = "Thread producao 3";

            consumThreads[0] = new Thread(new ThreadStart(consum[0].Consumir));
            consumThreads[1] = new Thread(new ThreadStart(consum[1].Consumir));
            consumThreads[2] = new Thread(new ThreadStart(consum[2].Consumir));

            consumThreads[0].Name = "Thread consumo 1 ";
            consumThreads[1].Name = "Thread consumo 2 ";
            consumThreads[2].Name = "Thread consumo 3 ";

            Console.WriteLine("\n\t\t\t(T) = PAUSE/CONTINUE\n\n");
            
            quantSegPause = 5;
            ContagemRegressiva(quantSegPause, "Iniciando em");

            Console.WriteLine("\n" + new string('-', 50));

            prodThreads[0].Start();
            pauseThread.Start();

            while (i < prod.Length)
            {
                if (i == 0)
                consumThreads[i].Start();
                else
                {
                    prodThreads[i].Start();
                    consumThreads[i].Start();
                }

                consumThreads[i].Join();
                prodThreads[i].Join();

                Produtor.Cont = 0;
                i++;

                if (i < prod.Length)
                    ContagemRegressiva(5, "Continua em");
                else pauseThread.Abort();
            }

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey(true);
        }
    }

    // Adiciona itens ao buffer. Se o buffer está cheio, deve esperar!
    class Produtor
    {
        string nome;
        string matricula;
        static int cont;

        Random randomTime;

        Buffer buf;

        public static int Cont { get { return cont; } set { cont = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Matricula { get { return matricula; } set { matricula = value; } }

        static Produtor()
        {
            cont = 0;
        }

        public Produtor(Buffer b, Random r, string nome, string matricula)
        {
            this.buf = b;
            this.nome = nome;
            this.matricula = matricula;
            this.randomTime = r;
        }

        public void Produzir()
        {
            string texto = this.nome + " " + this.matricula;

            cont = texto.Length;

            for (int i = 0; i < cont; i++)
            {
                Thread.Sleep(randomTime.Next(200, 500));
                buf.Caractere = texto[i];
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + Thread.CurrentThread.Name +
                " terminou de produzir.\nTerminando " + Thread.CurrentThread.Name + ".\n");
            Console.ResetColor();
        }
    }

    // Acessa itens do buffer. Se o buffer está vazio, deve esperar!
    class Consumidor
    {
        string dadosConsumidos;

        Buffer buf;

        Random randomTime;

        public Consumidor(Buffer b, Random r)
        {
            this.buf = b;
            this.dadosConsumidos = "";
            this.randomTime = r;
        }

        public string DadosConsumidos { get { return dadosConsumidos; } set { dadosConsumidos = value; } }

        public void Consumir()
        {
            Thread current = Thread.CurrentThread;

            for (int i = 0; i < Produtor.Cont; i++)
            {
                Thread.Sleep((randomTime.Next(200, 500)));
                this.dadosConsumidos += buf.Caractere;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + current.Name +
                    " leu: " + dadosConsumidos + "\nTerminando " +
                        current.Name + ".\n");
            Console.ResetColor();
        }
    }

    class Buffer
    {
        char caractere;
        bool cheio = false;

        public bool Cheio { get { return cheio; } set { this.cheio = value; } }

        public char Caractere
        {
            get
            {

                Monitor.Enter(this);

                if (!this.cheio)
                {
                    Console.WriteLine("\n" + Thread.CurrentThread.Name + " tentou ler.");

                    Console.WriteLine("\nBuffer vazio. " + Thread.CurrentThread.Name + " esperando...");

                    Monitor.Wait(this);
                }

                this.cheio = false;

                Console.WriteLine("\n" + Thread.CurrentThread.Name + " leu " + caractere);

                Monitor.Pulse(this);

                char aux = caractere;

                Monitor.Exit(this);

                return aux;
            }

            set
            {
                Monitor.Enter(this);

                if (this.cheio)
                {
                    Console.WriteLine("\n" + Thread.CurrentThread.Name + " tentou escrever.");

                    Console.WriteLine("\nBuffer cheio. " + Thread.CurrentThread.Name + " esperando...");

                    Monitor.Wait(this);
                }

                this.cheio = true;

                this.caractere = value;

                Console.WriteLine("\n" + Thread.CurrentThread.Name + " escreveu " + caractere);

                Monitor.Pulse(this);

                Monitor.Exit(this);
            }

        }
    }
}

