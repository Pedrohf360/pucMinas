using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    class Energia : Conta
    {
        public Energia(double leituraAtual, double leituraAnterior, string id, int mes, Titular titular) : base(leituraAtual, leituraAnterior, id, mes, titular)
        {
            this.leituraAnterior = leituraAnterior;
            this.leituraAtual = leituraAtual;
            this.Id = id;
            this.mes = mes;
            this.Titular = titular;
        }

        public int GetTipo()
        {
            return 1;
        }
    }
}
