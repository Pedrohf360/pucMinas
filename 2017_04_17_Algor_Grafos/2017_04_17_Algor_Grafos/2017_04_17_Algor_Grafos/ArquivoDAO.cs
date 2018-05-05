using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2017_04_17_Algor_Grafos
{
    class ArquivoDAO
    {
        string nomeArquivo;
        StreamReader read;

        /// <summary>
        /// Recebe o nome do arquivo e prepara para acesso aos dados.
        /// </summary>
        /// <param name="nomeArquivo">Nome do arquivo com extensão.</param>
        public ArquivoDAO(string nomeArquivo)
        {
            this.nomeArquivo = nomeArquivo;

            if (this.nomeArquivo.IndexOf(".txt") == -1)
            {
                this.nomeArquivo = this.nomeArquivo + ".txt";
            }

            this.read = new StreamReader(this.nomeArquivo);
        }

        public string[] LerAquivo()
        {
            string texto = this.read.ReadToEnd();
            string[] conteudoArq;

            texto = texto.Replace("\r", "");

            conteudoArq = texto.Split('\n');

            this.read.Close();

            return conteudoArq;
        }
    }
}
