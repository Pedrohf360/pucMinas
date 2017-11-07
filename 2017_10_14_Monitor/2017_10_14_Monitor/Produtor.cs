using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_10_14_Monitor
{
    // Adiciona itens ao buffer. Se o buffer está cheio, deve esperar!
    class Produtor
    {
        string nome;
        string matricula;
        static int cont;

        Random randomTime;

        Buffer buf;

        public static  int Cont { get {return cont; }set {cont = value; }}
        public string Nome { get {return nome;} set {nome = value; }}
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
    }

