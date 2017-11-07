using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_10_14_Monitor
{
    // Acessa itens do buffer. Se o buffer está vazio, deve esperar!
    class Consumidor
    {
        string dadosConsumidos;

        Buffer buf;

        Random randomTime;

        public Consumidor (Buffer b, Random r)
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
}
