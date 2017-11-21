using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    class ABB
    {
        Nodo raiz;
        public ABB()
        {
            this.raiz = null;
        }

        public void Inserir(IDado d)
        {
            Nodo novo = new Nodo(d);

            this.raiz = Inserir(novo, this.raiz);
        }

        private Nodo Inserir(Nodo novo, Nodo onde)
        {
            if (onde == null)
                return novo;
            else
            {
                if (novo.D.CompareTo(onde.D) < 0)
                    onde.Esq = Inserir(novo, onde.Esq);
                else if (novo.D.CompareTo(onde.D) > 0)
                    onde.Dir = Inserir(novo, onde.Dir);
                return onde;
            }
        }

        private Nodo Buscar(Nodo procurado, Nodo onde)
        {
            if (onde == null)
                return null;
            else
            {
                if (procurado.D.CompareTo(onde.D) < 0)
                    return Buscar(procurado, onde.Esq);
                else if (procurado.D.CompareTo(onde.D) > 0)
                    return Buscar(procurado, onde.Dir);
                return onde;
            }
        }
        public IDado Buscar (IDado d)
        {
            Nodo procurado = new Nodo(d);

            Nodo achou = Buscar(procurado, raiz);

            if (achou == null) return null;

            else return achou.D;
        }

        public IDado Buscar(int d)
        { 
            IDado achou = Buscar(d, raiz);

            if (achou == null) return null;

            else return achou;
        }

        private IDado Buscar(int procurado, Nodo onde)
        {
            if (onde == null)
                return null;
            else
            {
                if (onde.D.CompareTo(procurado) > 0)
                    return Buscar(procurado, onde.Esq);
                else if (onde.D.CompareTo(procurado) < 0)
                    return Buscar(procurado, onde.Dir);
                return onde.D;
            }
        }

        private int Grau(Nodo onde)
        {
            int qtdFilhos;

            if (onde.Dir != null && onde.Esq != null) qtdFilhos = 2;
            else if (onde.Dir != null || onde.Esq != null) qtdFilhos = 1;
            else qtdFilhos = 0;

            return qtdFilhos;
        }

        //public IDado Remover(IDado d)
        //{
        //    Nodo retirado = null;
        //    this.raiz = Remover(d, this.raiz, retirado);

        //    if (retirado != null) return retirado.D;
        //    else return null;
        //}

        //public Nodo Remover(IDado d, Nodo onde, out Nodo ret)
        //{
        //    if (onde == null) return null;
        //    else
        //    {
        //        if (d.CompareTo(onde.D) < 0)
        //            onde.Esq = Remover(d, onde.Esq, out ret);
        //        else if (d.CompareTo(onde.D) > 0)
        //            onde.Dir = Remover(d, onde.Dir, out ret);
        //        else
        //        {
        //            int grau = Grau(onde);
        //            ret.Copiar(onde);

        //            switch (grau)
        //            {
        //                case 0:
        //                    return null;
        //                    break;

        //                case 1:
        //                    return onde.Esq;
        //                    break;

        //                case -1:
        //                    return onde.Dir;
        //                    break;

        //                case 2:
        //                    Nodo anterior = onde.Antecessor();

        //                    onde.Copiar(anterior);

        //                    onde.Esq = Remover(anterior, d, out onde.Esq);
        //                    return onde;
        //                    break;
        //            }
        //        }
        //    }
        //}
    }
}
