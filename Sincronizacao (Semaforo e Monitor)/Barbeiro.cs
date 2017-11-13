using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_12_BarbeiroSonolento
{
    class Program
    {
        static Random r = new Random();

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

            Console.WriteLine("Afiando tesouras...");
            BarraProgresso(11);

            Salao salao = new Salao(r);

            Barbeiro barbeiro = new Barbeiro(salao, r);
            BarraProgresso(15);

            Thread threadBarbeiro = new Thread(new ThreadStart(barbeiro.AtenderCliente));
            Thread threadNovoCliente = new Thread(new ThreadStart(salao.NovoCliente));

            threadBarbeiro.Start();
            threadNovoCliente.Start();

            Thread.Sleep(10000);

            threadBarbeiro.Abort();
            threadNovoCliente.Abort();

            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
            
        }
    }

    class Barbeiro
    {
        private bool trabalhando;
        Salao salao;
        Random r;

        public Barbeiro(Salao salao, Random r)
        {
            this.salao = salao;
            this.r = r;
            this.trabalhando = false;

            Console.WriteLine("\nO barbeiro abriu o salao!");
        }

        public void AtenderCliente()
        {
            int numCliente;

            while (true)
            {
                numCliente = salao.QtdCadeirasOcup;

                if (salao.QtdCadeirasOcup == 0)
                    Dormir();
                else
                {


                    if (salao.QtdCadeirasOcup == 5)
                    {
                        while (salao.QtdCadeirasOcup != 0)
                        {
                            salao.SemaphAtendimento.WaitOne();
                            this.trabalhando = true;
                            Console.WriteLine("\nAtendendo cliente " + numCliente);

                            Thread.Sleep(r.Next(90, 150));

                            Console.WriteLine("\nTerminou de atender o cliente " + numCliente);

                            salao.QtdCadeirasOcup--;
                            numCliente--;

                            Console.WriteLine("Cadeiras ocupadas: " + salao.QtdCadeirasOcup);

                            Thread.Sleep(r.Next(15, 50));

                            this.trabalhando = false;

                            salao.SemaphNovoCliente.Release();
                        }
                    }
                    else
                    {
                        salao.SemaphAtendimento.WaitOne();
                        this.trabalhando = true;

                        Console.WriteLine("\nAtendendo cliente " + numCliente);

                        Thread.Sleep(r.Next(150, 300));

                        Console.WriteLine("Terminou de atender o cliente " + numCliente);

                        salao.QtdCadeirasOcup--;
                        numCliente--;

                        Console.WriteLine("Cadeiras ocupadas: " + salao.QtdCadeirasOcup);

                        Thread.Sleep(r.Next(300, 500));

                        this.trabalhando = false;

                        salao.SemaphNovoCliente.Release();

                    }
                }
            }
        }

        public void Dormir()
        {
            Console.WriteLine("\nO barbeiro está dormindo.");
            Console.WriteLine("zzzZZZzzzZZZzzz");
            Thread.Sleep(1000);
        }
    }

    class Salao
    {
        Semaphore semaphAtendimento;
        Semaphore semaphNovoCliente;
        int qtdCadeiras;
        int qtdCadeirasOcup;
        Random r;

        //Semaphore semaphAtendimento;
        //Semaphore semaphNovoCliente;

        public Salao(Random r)
        {
            this.qtdCadeiras = 5;
            this.qtdCadeirasOcup = 0;

            this.r = r;

            semaphAtendimento = new Semaphore(0, this.qtdCadeiras); // Começa sem nenhum cliente a atender e pode atender no máximo 1 por vez.
            semaphNovoCliente = new Semaphore(this.qtdCadeiras, this.qtdCadeiras); // Começa com a possibilidade de gerar x clientes.
        }

        public int QtdCadeirasOcup { get { return this.qtdCadeirasOcup; } set {qtdCadeirasOcup = value;} }

        public int QtdCadeiras { get => qtdCadeiras; set => qtdCadeiras = value; }
        public Semaphore SemaphAtendimento { get => semaphAtendimento; set => semaphAtendimento = value; }
        public Semaphore SemaphNovoCliente { get => semaphNovoCliente; set => semaphNovoCliente = value; }

        public void NovoCliente()
        {
            while (true)
            {
                if (this.qtdCadeirasOcup == 5)
                {
                    Console.WriteLine("\nUm cliente chegou na salao mas foi embora, pois nao havia lugar disponível.");
                    Thread.Sleep(2000);
                }
                else
                {
                    if (this.qtdCadeirasOcup == 0)
                    {
                        while (this.qtdCadeirasOcup != 5)
                        {
                            Thread.Sleep(r.Next(130, 260));

                            this.semaphNovoCliente.WaitOne();

                            Console.WriteLine("\nUm novo cliente entrou no salao.");

                            this.qtdCadeirasOcup++;

                            Console.WriteLine("Cadeira ocupadas: " + this.qtdCadeirasOcup);
                            this.semaphAtendimento.Release();
                        }
                    }
                    else
                    {
                        Thread.Sleep(r.Next(500, 800));
                        this.semaphNovoCliente.WaitOne();
                        Console.WriteLine("\nUm novo cliente entrou no salao.");

                        this.qtdCadeirasOcup++;

                        Console.WriteLine("Cadeira ocupadas: " + this.qtdCadeirasOcup);
                        this.semaphAtendimento.Release();
                    }
                }
            }
        }
    }
}
