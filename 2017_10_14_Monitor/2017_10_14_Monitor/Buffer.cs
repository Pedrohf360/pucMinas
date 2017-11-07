using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _2017_10_14_Monitor
{
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
