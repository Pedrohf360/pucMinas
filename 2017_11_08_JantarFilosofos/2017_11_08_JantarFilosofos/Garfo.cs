using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_11_08_JantarFilosofos
{
    class Garfo
    {
        int garfoDir;
        int garfoEsq;

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
        

        public Garfo(int garfoDir, int garfoEsq)
        {
            this.garfoDir = garfoDir;
            this.garfoEsq = garfoEsq;
        }

        public int SortearGarfoDir()
        {
            Random r = new Random();

            return r.Next(1, 5);
        }

        public int SortearGarfoEsq()
        {
            Random r = new Random();

            return r.Next(1, 5);
        }
    }
}
