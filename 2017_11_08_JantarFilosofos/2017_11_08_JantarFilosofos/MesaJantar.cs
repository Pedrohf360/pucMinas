using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_11_08_JantarFilosofos
{
    class MesaJantar
    {
        Random rand;
        Filosofo[] filosofos;
        Garfo[] garfos;

        public MesaJantar(Filosofo[] filosofos, Garfo[] garfos, Random rand)
        {
            this.rand = rand;

            this.filosofos = filosofos;

            this.garfos = garfos;

            this.filosofos[0] = new Filosofo("Platão", 1, garfos[4], garfos[0], rand);
            this.filosofos[1] = new Filosofo("Aristóteles", 2, garfos[0], garfos[1], rand);
            this.filosofos[2] = new Filosofo("Sócrates", 3, garfos[1], garfos[2], rand);
            this.filosofos[3] = new Filosofo("Descartes", 4, garfos[2], garfos[3], rand);
            this.filosofos[4] = new Filosofo("Euclides", 5, garfos[3], garfos[4], rand);

            Console.WriteLine();
        }

        public void IniciarJantar()
        {

            for (int i = 0; i < filosofos.Length; i++)
            {
                filosofos[i].Comer();
            }
        }

    }
}


            //int garf1, garf2, garf3, garf4;

            //while (true)
            //{
            //    garf1 = rand.Next(1, 3);
            //    garf2 = rand.Next(2, 4);
            //    garf3 = rand.Next(3, 5);
            //    garf4 = rand.Next(4, 6);

            //    // Filósofo I
            //    // Lembrar de verificar disponibilidade dos garfos ao final.
            //    Monitor.Enter(this);
            //    if (filosofos[0].GarfoDir.Posicao == garf4)
            //    {
            //        if (filosofos[0].GarfoDir.Ocupado)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[0].GarfoDir.Posicao);
            //            Console.ResetColor();

            //            Monitor.Wait(this);
            //        }

            //        filosofos[0].GarfoDir.Ocupado = true;

            //        Console.WriteLine("O Filósofo " + filosofos[0].Nome + " pegou o garfo " + filosofos[0].GarfoDir.Posicao);

            //        Monitor.Pulse(this);

            //        if (filosofos[0].GarfoEsq.Posicao == garf1)
            //        {
            //            if (filosofos[0].GarfoEsq.Ocupado)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Blue;
            //                Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[0].GarfoEsq.Posicao);
            //                Console.ResetColor();

            //                Monitor.Wait(this);
            //            }

            //            filosofos[0].GarfoEsq.Ocupado = true;

            //            Console.WriteLine("O Filósofo " + filosofos[0].Nome + " pegou o garfo " + filosofos[0].GarfoEsq.Posicao);

            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("O Filósofo " + filosofos[0].Nome + " está comendo...");
            //            Console.ResetColor();
            //            Thread.Sleep(rand.Next(1000, 2000));
            //            Console.WriteLine("O Filósofo " + filosofos[0].Nome + " largou o garfo da direita.");
            //            Console.WriteLine("O Filósofo " + filosofos[0].Nome + " largou o garfo da esquerda.");
            //            filosofos[0].GarfoDir.Ocupado = false;
            //            filosofos[0].GarfoEsq.Ocupado = false;
            //            Monitor.Pulse(this);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O Filósofo " + filosofos[0].Nome + " largou o garfo " + filosofos[0].GarfoDir.Posicao);
            //            filosofos[0].GarfoDir.Ocupado = false;
            //        }
            //    }
            //    else
            //    {
            //        filosofos[0].Pensar();
            //    }

            //    Monitor.Exit(this);

            //    // Filósofo II
            //    Monitor.Enter(this);
            //    if (filosofos[1].GarfoDir.Posicao == garf1)
            //    {
            //        if (filosofos[1].GarfoDir.Ocupado)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[1].GarfoDir.Posicao);
            //            Console.ResetColor();

            //            Monitor.Wait(this);
            //        }

            //        filosofos[1].GarfoDir.Ocupado = true;

            //        Console.WriteLine("O Filósofo " + filosofos[1].Nome + " pegou o garfo " + filosofos[1].GarfoDir.Posicao);

            //        Monitor.Pulse(this);

            //        if (filosofos[1].GarfoEsq.Posicao == garf2)
            //        {
            //            if (filosofos[1].GarfoEsq.Ocupado)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Blue;
            //                Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[1].GarfoEsq.Posicao);
            //                Console.ResetColor();

            //                Monitor.Wait(this);
            //            }

            //            filosofos[1].GarfoEsq.Ocupado = true;

            //            Console.WriteLine("O Filósofo " + filosofos[1].Nome + " pegou o garfo " + filosofos[1].GarfoEsq.Posicao);
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("O Filósofo " + filosofos[1].Nome + " está comendo...");
            //            Console.ResetColor();
            //            Thread.Sleep(rand.Next(1000, 2000));
            //            Console.WriteLine("O Filósofo " + filosofos[1].Nome + " largou o garfo da direita.");
            //            Console.WriteLine("O Filósofo " + filosofos[1].Nome + " largou o garfo da esquerda.");
            //            filosofos[1].GarfoDir.Ocupado = false;
            //            filosofos[1].GarfoEsq.Ocupado = false;

            //            Monitor.Pulse(this);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O Filósofo " + filosofos[1].Nome + " largou o garfo " + filosofos[1].GarfoDir.Posicao);
            //            filosofos[1].GarfoDir.Ocupado = false;
            //        }
            //    }
            //    else
            //    {
            //        filosofos[1].Pensar();
            //    }
            //    Monitor.Exit(this);

            //    // Filósofo III
            //    Monitor.Enter(this);
            //    if (filosofos[2].GarfoDir.Posicao == garf2)
            //    {
            //        if (filosofos[2].GarfoDir.Ocupado)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[2].GarfoDir.Posicao);
            //            Console.ResetColor();

            //            Monitor.Wait(this);
            //        }

            //        filosofos[2].GarfoDir.Ocupado = true;

            //        Console.WriteLine("O Filósofo " + filosofos[2].Nome + " pegou o garfo " + filosofos[2].GarfoDir.Posicao);

            //        Monitor.Pulse(this);

            //        if (filosofos[2].GarfoEsq.Posicao == garf3)
            //        {
            //            if (filosofos[2].GarfoEsq.Ocupado)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Blue;
            //                Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[2].GarfoEsq.Posicao);
            //                Console.ResetColor();

            //                Monitor.Wait(this);
            //            }

            //            filosofos[2].GarfoEsq.Ocupado = true;

            //            Console.WriteLine("O Filósofo " + filosofos[2].Nome + " pegou o garfo " + filosofos[2].GarfoEsq.Posicao);
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("O Filósofo " + filosofos[2].Nome + " está comendo...");
            //            Console.ResetColor();
            //            Thread.Sleep(rand.Next(1000, 2000));
            //            Console.WriteLine("O Filósofo " + filosofos[2].Nome + " largou o garfo da direita.");
            //            Console.WriteLine("O Filósofo " + filosofos[2].Nome + " largou o garfo da esquerda.");
            //            filosofos[2].GarfoDir.Ocupado = false;
            //            filosofos[2].GarfoEsq.Ocupado = false;

            //            Monitor.Pulse(this);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O Filósofo " + filosofos[2].Nome + " largou o garfo " + filosofos[2].GarfoDir.Posicao);
            //            filosofos[2].GarfoDir.Ocupado = false;
            //        }
            //    }
            //    else
            //    {
            //        filosofos[2].Pensar();
            //    }

            //    Monitor.Exit(this);

            //    // Filósofo IV
            //    Monitor.Enter(this);
            //    if (filosofos[3].GarfoDir.Posicao == garf3)
            //    {
            //        if (filosofos[3].GarfoDir.Ocupado)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[3].GarfoDir.Posicao);
            //            Console.ResetColor();

            //            Monitor.Wait(this);
            //        }

            //        filosofos[3].GarfoDir.Ocupado = true;

            //        Console.WriteLine("O Filósofo " + filosofos[3].Nome + " pegou o garfo " + filosofos[3].GarfoDir.Posicao);

            //        Monitor.Pulse(this);

            //        if (filosofos[3].GarfoEsq.Posicao == garf4)
            //        {
            //            if (filosofos[3].GarfoEsq.Ocupado)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Blue;
            //                Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[3].GarfoEsq.Posicao);
            //                Console.ResetColor();

            //                Monitor.Wait(this);
            //            }

            //            filosofos[3].GarfoEsq.Ocupado = true;

            //            Console.WriteLine("O Filósofo " + filosofos[3].Nome + " pegou o garfo " + filosofos[3].GarfoEsq.Posicao);
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("O Filósofo " + filosofos[3].Nome + " está comendo...");
            //            Console.ResetColor();
            //            Thread.Sleep(rand.Next(1000, 2000));
            //            Console.WriteLine("O Filósofo " + filosofos[3].Nome + " largou o garfo da direita.");
            //            Console.WriteLine("O Filósofo " + filosofos[3].Nome + " largou o garfo da esquerda.");
            //            filosofos[3].GarfoDir.Ocupado = false;
            //            filosofos[3].GarfoEsq.Ocupado = false;

            //            Monitor.Pulse(this);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O Filósofo " + filosofos[3].Nome + " largou o garfo " + filosofos[3].GarfoDir.Posicao);
            //            filosofos[3].GarfoDir.Ocupado = false;
            //        }
            //    }
            //    else
            //    {
            //        filosofos[3].Pensar();
            //    }

            //    Monitor.Exit(this);

            //    // Filósofo V
            //    Monitor.Enter(this);
            //    if (filosofos[4].GarfoDir.Posicao == garf3)
            //    {
            //        if (filosofos[4].GarfoDir.Ocupado)
            //        {
            //            Console.ForegroundColor = ConsoleColor.Blue;
            //            Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[4].GarfoDir.Posicao);
            //            Console.ResetColor();

            //            Monitor.Wait(this);
            //        }

            //        filosofos[4].GarfoDir.Ocupado = true;

            //        Console.WriteLine("O Filósofo " + filosofos[4].Nome + " pegou o garfo " + filosofos[4].GarfoDir.Posicao);

            //        Monitor.Pulse(this);

            //        if (filosofos[4].GarfoEsq.Posicao == garf4)
            //        {
            //            if (filosofos[4].GarfoEsq.Ocupado)
            //            {
            //                Console.ForegroundColor = ConsoleColor.Blue;
            //                Console.WriteLine("O Filósofo {0} está aguardando para usar o garfo ", filosofos[4].GarfoEsq.Posicao);
            //                Console.ResetColor();

            //                Monitor.Wait(this);
            //            }

            //            filosofos[4].GarfoEsq.Ocupado = true;

            //            Console.WriteLine("O Filósofo " + filosofos[4].Nome + " pegou o garfo " + filosofos[4].GarfoEsq.Posicao);
            //            Console.ForegroundColor = ConsoleColor.Green;
            //            Console.WriteLine("O Filósofo " + filosofos[4].Nome + " está comendo...");
            //            Console.ResetColor();
            //            Thread.Sleep(rand.Next(1000, 2000));
            //            Console.WriteLine("O Filósofo " + filosofos[4].Nome + " largou o garfo da direita.");
            //            Console.WriteLine("O Filósofo " + filosofos[4].Nome + " largou o garfo da esquerda.");
            //            filosofos[4].GarfoDir.Ocupado = false;
            //            filosofos[4].GarfoEsq.Ocupado = false;

            //            Monitor.Pulse(this);
            //        }
            //        else
            //        {
            //            Console.WriteLine("O Filósofo " + filosofos[4].Nome + " largou o garfo " + filosofos[4].GarfoDir.Posicao);
            //            filosofos[4].GarfoDir.Ocupado = false;
            //        }
            //    }
            //    else
            //    {
            //        filosofos[4].Pensar();
            //    }

            //    Monitor.Exit(this);