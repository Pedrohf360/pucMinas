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

        private Nodo Inserir(Nodo novo, Nodo onde)
        {
            if (onde == null)
                return novo;
            else {
                if (novo.D.CompareTo(onde.D) < 0)
                    onde.Esq = Inserir(novo, onde.Esq);
                else
                    onde.Dir = Inserir(novo, onde.Dir);
                return onde;
                }
        }

        public void Inserir(IDado d)
        {
            Nodo novo = new Nodo(d);

            this.raiz = Inserir(novo, this.raiz);

          
        }

        public int Tamanho()
        {
            return this.tamanhoArvore;
        }

        private Nodo Buscar(IDado d, Nodo onde)
        {
            if (onde == null)
                return null;
            else
            {
                if (onde.Equals(d))
                    return onde;
                else if (onde.D.CompareTo(d) < 0)
                    return Buscar(d, onde.Dir);
                else
                    return Buscar(d, onde.Esq);
            }
        }

        public IDado Buscar (IDado d)
        {
            Nodo achou = Buscar(d, raiz);

            if (achou == null) return null;

            else return achou.D;
        }

        //public IDado Remover(IDado d)
        //{
        //    Nodo retirado = null;

        //    this.raiz = Remover(d, this.raiz, out retirado);

        //    if (retirado != null) return retirado.D;
        //    else return null;
        //}

        //public Nodo Remover (IDado d, Nodo onde, out Nodo ret)
        //{
        //    if (onde == null) return null;
        //    else
        //    {
        //        if (d < onde.D)
        //            onde.Esq = Remover(d, onde.Esq, out ret); // ??
        //        else if (d > onde.D)
        //            onde.Dir = Remover(d, onde.Dir, out ret);
        //        else
        //        {
        //            int grau = onde.Grau();
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
