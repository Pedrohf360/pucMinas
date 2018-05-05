using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_17_Algor_Grafos
{
    interface IGrafoNaoDir
    {
        bool IsAdjacente(Vertice v1, Vertice v2);

        int GetGrau(Vertice v1);

        bool IsIsolado(Vertice v1);

        bool IsPendente(Vertice v1);

        bool IsRegular();

        bool IsNulo();

        bool isCompleto();

        bool IsConexo();

        bool IsEuleriano();

        bool IsUnicursal();

        Grafo GetComplementar();

        Grafo GetAGMPrim(Vertice v1);

        Grafo GetAGMKruskal(Vertice v1);
    }
}
