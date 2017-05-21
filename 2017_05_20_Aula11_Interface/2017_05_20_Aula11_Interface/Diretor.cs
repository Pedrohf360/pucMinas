using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_20_Aula11_Interface
{
    class Diretor : IFuncionario
    {
        private string nome;
        private string cargo;
        private double valorProlabore;
        private double bonusProdutiv;
        

        public void Init(string nome, string cargo, double valorProlabore, double bonusProd)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.valorProlabore = valorProlabore;
            this.bonusProdutiv = bonusProd;
        }

        public Diretor(string nome, string cargo, double valorProlabore, double bonusProd)
        {
            Init(nome, cargo, valorProlabore, bonusProd);
        }

        public Diretor()
        {
            this.nome = "Any name";
            this.cargo = "Diretor geral";
            this.valorProlabore = 5000;
            this.bonusProdutiv = 500;
        }

        public double SalarioTotal()
        {
            return this.valorProlabore + this.bonusProdutiv;
        }

        public string ToString()
        {
            return  "Nome: " + this.nome + "\n" +
                    "Cargo: " + this.cargo + "\n" +
                    "Valor prolabore: " + this.valorProlabore + "\n" +
                    "Bônus produtividades: " + this.bonusProdutiv;
        }
    }
}
