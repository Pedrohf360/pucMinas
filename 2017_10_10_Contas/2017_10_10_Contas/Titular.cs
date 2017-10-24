using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    class Titular: IDado
    {
        long cpf;
        List<Conta> contas = new List<Conta>();

        public Titular(long cpf)
        {
            this.cpf = cpf;
        }

        public void AdicionarConta(Conta conta)
        {
            contas.Add(conta);
        }
        public override bool Equals(object obj)
        {
            Titular t = (Titular)(obj);

            return (this.Equals(t));
        }

        public int CompareTo(IDado obj)
        {
            Titular t = (Titular)(obj);

            long diferenca = this.cpf - t.cpf;

            if (diferenca > 0) return 1;
            else if (diferenca < 0) return -1;
            else return 0;
        }
    }
}
