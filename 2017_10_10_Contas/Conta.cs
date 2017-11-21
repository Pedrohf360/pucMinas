using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    abstract class Conta: IDado
    {
        string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public Titular Titular { get => titular; set => titular = value; }

        protected int mes;
        private Titular titular;

        protected double leituraAtual, leituraAnterior;

        public Conta(double leituraAtual, double leituraAnterior, string id, int mes, Titular titular)
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

            int idIntAtual = int.Parse(this.id);
            int idProcurado = int.Parse(c.id);

            if (idIntAtual < idProcurado) return -1;
            else if (idIntAtual > idProcurado) return 1;
            else return 0;
        }

        public int CompareTo(int i)
        {
            int idAtual = int.Parse(this.id);

            if (idAtual < i) return -1;
            else if (idAtual > i) return 1;
            else return 0;
        }

    
    }
}
