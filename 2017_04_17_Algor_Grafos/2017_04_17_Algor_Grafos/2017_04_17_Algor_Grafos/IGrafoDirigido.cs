using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_04_17_Algor_Grafos
{
    interface IGrafoDirigido
    {
        int GetGrauEntrada(Vertice v1);

        int GetGrauSaida(Vertice v1);

        bool HasCiclo();
    }
}
