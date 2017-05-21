using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_20_Aula11_Interface
{
    public abstract class Analista : Funcionario, IFuncionario
    {
        // 1/3 salario base
        protected double valorFerias;
        // Mesmo valor salar. base
        protected double valorDecTerc;


        // Limite de 20h, 1h = 50% hora normal.
        protected int quantHoraExtra;

        public void Init(string nome, string cargo, double salarioBase, int quantHoraExtra)
        {
            this.cargo = cargo;
            this.nome = nome;
            this.quantHoraExtra = quantHoraExtra;
            this.salarioBase = salarioBase;
        }

        public Analista(string nome, string cargo, double salarioBase, int quantHoraExtra) : base(salarioBase)
        {
            Init(nome, cargo, salarioBase, quantHoraExtra);
        }

        public Analista ()
        {
            Init("Carlos", "Analista", 2000, 4);
        }

        public double CalcHoraExtra()
        {
            return CalcHoraTrab() + (CalcHoraTrab() * 0.5);
        }

        public double CalcValorTrabExtra()
        {
            if (quantHoraExtra > 20)
                throw new ArgumentException("A quantidade de horas extra informada ultrapassa o limite permitido (20h)!");

            return CalcHoraExtra() * this.quantHoraExtra;
        }

        /// <summary>
        /// 30% maior que do analista junior.
        /// </summary>
        /// <returns></returns>
        public double SalarioBase()
        {
            return base.salarioBase + CalcValorTrabExtra();
        }

        public double SalarioTotal()
        {
            return SalarioBase() + CalcValorTrabExtra();
        }

        public double CalcImpRenda()
        {
            double salar = SalarioBase();
            double impRenda = 0;

            if (salar < 0 || salar <= 1903.98)
                impRenda = 0;
            else if (salar >= 1904.01 && salar <= 2826.65)
                impRenda = (salar * 0.075) - 142.80;
            else if (salar >= 2826.66 && salar <= 3751.05)
                impRenda = (salar * 0.15) - 354.8;
            else if (salar >= 3751.06 && salar <= 4664.68)
                impRenda = (salar * 0.2250) - 636.13;
            else if (salar >= 4664.68)
                impRenda = (salar * 0.2750) - 869.36;

            return impRenda;
        }

        public int QuantHoraExtra
        {
            get { return this.quantHoraExtra; }
            set
            {
                if (value <= 20)
                this.quantHoraExtra = value;
            }
        }

        public double CalcFerias()
        {
            return this.salarioBase / 3;
        }

        public string ToString()
        {
            return base.ToString() + "\n" +
                    "Quant. horas extra: " + this.quantHoraExtra + "\n" +
                    "Adicional (hora extra): " + this.CalcValorTrabExtra() + "\n" +
                    "Desc. Imp. Renda: " + this.CalcImpRenda();
        }
    }
}
