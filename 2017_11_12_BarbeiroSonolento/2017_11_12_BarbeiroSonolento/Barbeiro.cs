using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_12_BarbeiroSonolento
{
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
}
