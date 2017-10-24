using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    class Agua : Conta
    {
        public Agua(double leituraAtual, double leituraAnterior, int id, int mes, Titular titular) : base(leituraAtual, leituraAnterior, id, mes, titular)
        {
            this.leituraAnterior = leituraAnterior;
            this.leituraAtual = leituraAtual;
            this.id = id;
            this.mes = mes;
            this.titular = titular;
        }

        public int GetTipo()
        {
            return 2;
        }
    }
}
