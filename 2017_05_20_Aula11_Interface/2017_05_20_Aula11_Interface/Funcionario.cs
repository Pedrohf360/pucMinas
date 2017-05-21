using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_20_Aula11_Interface
{
    public abstract class Funcionario
    {
        protected string nome;
        protected string cargo;
        protected double salarioBase;

        public Funcionario(double salarioBase)
        {
            this.salarioBase = salarioBase;
        }

        public Funcionario()
        {
            this.salarioBase = 5000;
        }

        public string ToString()
        {
            return "Nome: " + this.nome + "\n" +
                   "Cargo: " + this.cargo + "\n" +
                   "Salário base: " + this.salarioBase;
        }

        public double CalcHoraTrab()
        {
            return this.salarioBase / 160;
        }
    }
}
