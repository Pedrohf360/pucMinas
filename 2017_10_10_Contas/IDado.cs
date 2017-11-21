using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    interface IDado: IComparable <IDado>
    {
        int CompareTo(int i);
    }
}
