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
        int garfoDir;
        int garfoEsq;
        bool garfoDirOcupado;
        bool garfoEsqOcupado;

        public Garfo(int garfoDir, int garfoEsq)
        {
            this.garfoDir = garfoDir;
            this.garfoEsq = garfoEsq;
            this.garfoDirOcupado = false;
            this.garfoEsqOcupado = false;
        }

        public void SortearGarfos()
        {
            while (true)
            {
                try
                {
                    SortearGarfoDir();
                    SortearGarfoEsq();
                    Thread.Sleep(1000);
                } 
                catch (ThreadInterruptedException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
            }
        }

        public void SortearGarfoDir()
        {
            Random r = new Random();

            this.garfoDir = r.Next(1, 5);
        }

        public void SortearGarfoEsq()
        {
            Random r = new Random();

            this.garfoEsq = r.Next(1, 5);
        }

        public int GarfoEsq
        {
            get { return garfoEsq; }
            set { garfoEsq = value; }
        }

        public int GarfoDir
        {
            get { return garfoDir; }
            set { garfoDir = value; }
        }
    }
}
