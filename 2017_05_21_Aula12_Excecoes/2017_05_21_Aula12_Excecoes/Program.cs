using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _2017_05_21_Aula12_Ex1_Excecoes
{
    class Program
    {
        static bool VerificaPrimo(double valor)
        {
            if (valor == 1 || valor == 0)
            {
                throw new ArgumentException("\nThis isn't a cousin number! =D");
            }

            for (int i = 2; i < valor; i++)
            {
                
                if (valor % i == 0)
                {
                    throw new ArgumentException("\nThis isn't a cousin number! =D");
                }
            }

            Console.WriteLine("\nThis is a cousing number!");

            return true;
        }

        static void Main(string[] args)
        {
            double opcao;
            double valorQualquer;

            ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();

            do
            {
                Console.WriteLine("Verificador de primo 2000!!!");

                Console.WriteLine(new string('-', 40));

                Console.WriteLine("\nType any number and just see if it is a cousin number!! =DDDDD");

                try
                {
                    valorQualquer = double.Parse(Console.ReadLine());
                    VerificaPrimo(valorQualquer);
                }
                catch (FormatException forex)
                {
                    Console.WriteLine("\n" + forex.Message);
                }
                catch (ArgumentException nenao)
                {
                    Console.WriteLine("\n" + nenao.Message);
                }
                Console.WriteLine("=D");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("\n\nDeseja sair? FICA AEW BRÓD, VAMOS VERIFICAR OUTRO NÚMERO!!! - Processador.\n1- Sair.");

                keyinfo = Console.ReadKey();

                Console.Clear();
            } while (keyinfo.KeyChar != '1');
        }
    }
}
