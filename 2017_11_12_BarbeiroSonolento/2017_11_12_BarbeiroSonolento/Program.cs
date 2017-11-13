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

            //BarraProgresso(15);

            Salao salao = new Salao(r);

            Barbeiro barbeiro = new Barbeiro(salao, r);

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
}
