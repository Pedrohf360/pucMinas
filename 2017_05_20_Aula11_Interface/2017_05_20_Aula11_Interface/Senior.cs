using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_20_Aula11_Interface
{
    class Senior : Analista
    {
        private double taxaAcrescCargo;

        public Senior(string nome, string cargo, double salarioBase, int quantHoraExtra) : base (nome, cargo, salarioBase, quantHoraExtra)
        { 
        }

        public Senior() : base ()
        {
            this.nome = "This is default name of a Senior!";
            this.taxaAcrescCargo = 0.3;
        }

        public double CalcAcrescCargo()
        {
            return this.salarioBase * taxaAcrescCargo;
        }

        public double SalarioTotal()
        {
            return base.SalarioTotal() + CalcAcrescCargo(); 
        }
    }
}
