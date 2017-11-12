using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_08_JantarFilosofos
{
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
}
