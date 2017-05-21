using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_20_Aula11_Interface
{
    class Gerente : Funcionario, IFuncionario
    {
        private double taxaAcrescCargo;

        public Gerente (string nomeFunc, string nomeCargo, double salarioBase) : base(salarioBase)
        {
            base.nome = nomeFunc;
            base.cargo = nomeCargo;
            base.salarioBase = salarioBase;
            this.taxaAcrescCargo = 0.5;
        }

        public double CalcAcrescCargo()
        {
            return base.salarioBase * taxaAcrescCargo;
        }

        public double SalarioTotal()
        {
            return base.salarioBase + CalcAcrescCargo();
        }

        public string ToString()
        {
            return base.ToString() + "\n" +
                   "Salário total: " + SalarioTotal();
        }
    }
}
