using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    abstract class Conta: IDado
    {
        protected int id;
        protected int mes;
        protected Titular titular;

        protected double leituraAtual, leituraAnterior;

        public Conta(double leituraAtual, double leituraAnterior, int id, int mes, Titular titular)
        {
            this.id = id;
            this.mes = mes;
            this.leituraAtual = leituraAtual;
            this.leituraAnterior = leituraAnterior;
            
        }
        public double CalcConsumo()
        {
            return this.leituraAtual - this.leituraAnterior;
        }

        public override bool Equals(object obj)
        {
            Conta c = (Conta)(obj);

            return c.id == this.id;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int CompareTo(IDado d)
        {
            Conta c = (Conta)(d);

            return this.id - c.id;
        }
    }
}
