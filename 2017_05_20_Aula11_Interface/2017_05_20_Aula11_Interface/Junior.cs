using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_20_Aula11_Interface
{
    class Junior : Analista
    {
        public Junior(string nome, string cargo, double salarioBase, int quantHoraExtra) : base(nome, cargo, salarioBase, quantHoraExtra)
        {
        }
    }
}
