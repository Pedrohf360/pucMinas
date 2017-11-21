using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_31_BolhaInsercao
{
    class PreencheVetor
    {
        static public int[] vetCrescente(int tamVetor, int limInf, int limSup)
        {
            int[] aux = new int[tamVetor+1];

            for (int i = 0; i <= tamVetor; i++)
            {
                aux[i] = (limInf++);
            }
            return aux;
        }

        static public int[] vetDecrescente(int tamVetor, int limInf, int limSup)
        {
            int[] aux = new int[tamVetor+1];

            for (int i = 0; i <= tamVetor; i++)
            {
                aux[i] = (limSup--);
            }
            return aux;
        }

        static public int[] quaseOrdenado(int tamVetor, int limInf, int limSup)
        {
            Random aleat = new Random(42);

            int[] aux = new int[tamVetor+1];

            for (int i = 0; i <= tamVetor; i++)
            {
                aux[i] = (i + 1);
            }

            for (int i = 0; i <= (tamVetor / 20); i++)
            {
                int p1 = aleat.Next(0, tamVetor);
                int p2 = aleat.Next(0, tamVetor);
                int temp = aux[p1];
                aux[p1] = aux[p2];
                aux[p2] = temp;
            }
            return aux;
        }

        static public int[] vetAleatorio(int tamVetor, int limInf, int limSup)
        {
            Random aleat = new Random(42);

            int[] aux = new int[tamVetor+1];

            for (int i = 0; i <= tamVetor; i++)
            {
                aux[i] = aleat.Next(0, tamVetor);
            }

            return aux;
        }

    }
}
