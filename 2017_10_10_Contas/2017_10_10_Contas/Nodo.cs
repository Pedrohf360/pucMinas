using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    class Nodo
    {
        IDado d;

        Nodo esq, dir;

        public Nodo(IDado d)
        {
            this.d = d;
            this.esq = null;
            this.dir = null;
        }

        internal IDado D
        {
            get { return d; }
            set { d = value; }
        }

        internal Nodo Esq
        {
            get { return esq; }
            set { esq = value; }
        }

        public Nodo Dir
        {
            get { return this.dir; }
            set { this.dir = value; }
        }
    }
}
