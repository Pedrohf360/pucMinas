using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_10_10_Contas
{
    class Titular: IDado
    {
        string cpf;
        List<Conta> contas = new List<Conta>();

        internal List<Conta> Contas
        {
            get { return contas; }
            set { contas = value; }
        }

        public string Cpf { get { return cpf; } set { cpf = value; }}

        public Titular(string cpf)
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

            return (this.cpf == t.cpf);
        }

        public int CompareTo(IDado obj)
        {
            Titular t = (Titular)(obj);

            // Remove pontuação da string.
            string cpfProcurado = FormataCPF(t.cpf);
            string cpfAtual = FormataCPF(this.cpf);

            long diferenca = (long.Parse(cpfProcurado) - long.Parse(cpfAtual));

            if (diferenca > 0) return 1;
            else if (diferenca < 0) return -1;
            else return 0;
        }

        string FormataCPF(string text)
        {
            text = text.Replace(".", "").Replace("-", "");

            return text;
        }

        public int CompareTo(int i)
        {
            throw new NotImplementedException();
        }
    }
}
