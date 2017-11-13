using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_12_BarbeiroSonolento
{
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

        public int QtdCadeirasOcup
        {
            get
            {
                return this.qtdCadeirasOcup;
            }

            set
            {
                qtdCadeirasOcup = value;
            }
        }

        public int QtdCadeiras { get => qtdCadeiras; set => qtdCadeiras = value; }
        public Semaphore SemaphAtendimento { get => semaphAtendimento; set => semaphAtendimento = value; }
        public Semaphore SemaphNovoCliente { get => semaphNovoCliente; set => semaphNovoCliente = value; }

        public void NovoCliente()
        {
            while (true)
            {
                if (this.qtdCadeirasOcup == 5)
                {
                    Console.WriteLine("\nUm cliente chegou na loja mas foi embora, pois nao havia lugar disponível.");
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

//for (int i = 0; i < qtdClientes; i++)
//{
//    this.clientes.Push(i);
//}

//clientes.Push(clientes.Count);

//public Stack<int> Clientes
//{
//    get
//    {


//        return clientes;
//    }
//    set
//    {


//        clientes = value;
//    }
//}