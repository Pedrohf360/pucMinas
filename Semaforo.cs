using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_07_Semaforo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t------------Monitor - MultiThreads------------");
            Console.WriteLine("\nGRUPO:\tNOME:\t\t\tMATRICULA:" +
                            "\n\tPedro Henrique\t\t580544" +
                            "\n\tLucas Gomes\t\t578927" +
                            "\n\tHenrique Kirschke\t573948" +
                            "\n\tItalo Fabricio\t\t573962\n");

            ConsoleKeyInfo k = new ConsoleKeyInfo();

            Buffer buffer = new Buffer();

            Random random = new Random();

            Produtor[] prod = new Produtor[4];

            prod[0] = new Produtor(buffer, random, "Pedro H. - ", "580544");
            prod[1] = new Produtor(buffer, random, "Lucas G. - ", "578927");
            prod[2] = new Produtor(buffer, random, "Henrique K. - ", "573948");
            prod[3] = new Produtor(buffer, random, "Italo F. - ", "573962");

            Consumidor[] consum = new Consumidor[4];

            consum[0] = new Consumidor(buffer, random);
            consum[1] = new Consumidor(buffer, random);
            consum[2] = new Consumidor(buffer, random);
            consum[3] = new Consumidor(buffer, random);

            Thread[] prodThreads = new Thread[4];
            prodThreads[0] = new Thread(new ThreadStart(prod[0].Produzir));
            prodThreads[1] = new Thread(new ThreadStart(prod[1].Produzir));
            prodThreads[2] = new Thread(new ThreadStart(prod[2].Produzir));
            prodThreads[3] = new Thread(new ThreadStart(prod[3].Produzir));

            prodThreads[0].Name = "Thread producao 1 ";
            prodThreads[1].Name = "Thread producao 2";
            prodThreads[2].Name = "Thread producao 3";
            prodThreads[3].Name = "Thread producao 4";

            Thread[] consumThreads = new Thread[4];
            consumThreads[0] = new Thread(new ThreadStart(consum[0].Consumir));
            consumThreads[1] = new Thread(new ThreadStart(consum[1].Consumir));
            consumThreads[2] = new Thread(new ThreadStart(consum[2].Consumir));
            consumThreads[3] = new Thread(new ThreadStart(consum[3].Consumir));

            consumThreads[0].Name = "Thread consumo 1 ";
            consumThreads[1].Name = "Thread consumo 2 ";
            consumThreads[2].Name = "Thread consumo 3 ";
            consumThreads[3].Name = "Thread consumo 4 ";

            for (int i = 0; i < prod.Length; i++)
            {

                prodThreads[i].Start();

                consumThreads[i].Start();

                Thread.Sleep(5000);

                if (i != prod.Length - 1)
                {
                    Console.WriteLine("\nDeseja pausar? (T)");

                    k = Console.ReadKey();

                    while (k.Key == ConsoleKey.T)
                    {
                        Console.Clear();

                        Console.WriteLine("\nDeseja continuar? (C)");

                        k = Console.ReadKey();
                    }
                }
                Produtor.Cont = 0;
            }

            Console.WriteLine("\n\nPressione qualquer tecla para sair.");
            Console.ReadKey();
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
                Thread.Sleep(randomTime.Next(1, 200));
                buf.Caractere = texto[i];

                Buffer.SemaphCons.Release();
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
                Thread.Sleep((randomTime.Next(1, 200)));
                this.dadosConsumidos += buf.Caractere;

                Buffer.SemaphProd.Release();
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
        private static Semaphore semaphCons = new Semaphore(0, 1);

        private static Semaphore semaphProd = new Semaphore(1, 1);


        public char Caractere
        {
            get
            {
                semaphCons.WaitOne();

                Console.WriteLine("\n" + Thread.CurrentThread.Name + " leu " + caractere);

                char aux = caractere;

                return aux;
            }

            set
            {
                semaphProd.WaitOne();

                this.caractere = value;

                Console.WriteLine("\n" + Thread.CurrentThread.Name + " escreveu " + caractere);
            }
        }

        public static Semaphore SemaphCons { get => semaphCons; set => semaphCons = value; }
        public static Semaphore SemaphProd { get => semaphProd; set => semaphProd = value; }
    }

}
