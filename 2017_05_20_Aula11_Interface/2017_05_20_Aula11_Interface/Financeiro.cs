using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_05_20_Aula11_Interface
{
    class Financeiro
    {
        public static void CadastroFuncs(IFuncionario[] nomeClasse, int tipoFunc)
        {
            Console.Clear();
            string nome, cargo;
            double salarioBase;
            int quantHoraExtra;

            Console.WriteLine("\nVocê terá que cadastrar " + nomeClasse.Length + " funcionários deste tipo.");

            Console.WriteLine();

            for (int i = 0; i < nomeClasse.Length; i++)
            {
                Console.Write(i+1 + ") " + "Nome: ");
                nome = Console.ReadLine();

                Console.Write("Cargo: ");
                cargo = Console.ReadLine();

                Console.Write("Salário base: R$");
                salarioBase = double.Parse(Console.ReadLine());

                // GAMBIARRA DA BOA!! =D
                if (tipoFunc == 2)
                {
                    Console.Write("Quant. de horas extra: ");
                    quantHoraExtra = int.Parse(Console.ReadLine());

                    nomeClasse[i] = new Senior(nome, cargo, salarioBase, quantHoraExtra);
                }
                else if (tipoFunc == 1)
                {
                    Console.Write("Quant. de horas extra: ");
                    quantHoraExtra = int.Parse(Console.ReadLine());

                    nomeClasse[i] = new Junior(nome, cargo, salarioBase, quantHoraExtra);
                }
                else if (tipoFunc == 3)
                {
                    nomeClasse[i] = new Gerente(nome, cargo, salarioBase);
                }
                else if (tipoFunc == 4)
                {
                    nomeClasse[i] = new Diretor(nome, cargo, salarioBase, 500); // As horas extras serão o bônus por produtiv... Direitos trabalhistas é issó aí KKK
                }

                Console.WriteLine(new string('-', 30));
                Console.Clear();
            }
        }

        public static double CalcFolhaPag(IFuncionario[] nomeClasse)
        {
            double valor = 0;

            for (int i = 0; i < nomeClasse.Length && nomeClasse[i] != null; i++)
            {
                valor += nomeClasse[i].SalarioTotal();
            }

            return valor;
        }

        static void ImprimeDados(IFuncionario[] nomeClasse)
        {
            for (int i = 0; i < nomeClasse.Length && nomeClasse[i] != null; i++)
            {
                Console.WriteLine(nomeClasse[i].ToString());
                Console.WriteLine();
            }
        }

        static int Menu()
        {
            int opcao = 0;
            Boolean verifErro;

            do
            {
                Console.Clear();
                Console.WriteLine("Seja bem-vindo ao SUPER CADASTRATOR 2000!");
                Console.WriteLine(new string('-', 30));

                try
                {
                    verifErro = false;

                    while (opcao <= 0 || opcao > 4)
                    {
                        Console.WriteLine("\n\n1- Cadastrar novo funcionário");
                        Console.WriteLine("2- Ver funcionários cadastrados");
                        Console.WriteLine("3- Ver total folha pagamento");
                        Console.WriteLine("4- Sair.");

                        opcao = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException formex)
                {
                    Console.WriteLine("\n" + formex.Message);
                    verifErro = true;
                }
                catch
                {
                    Console.WriteLine("\nThere's something wrong with prog... you*! ;)");
                    verifErro = true;
                }
            } while (verifErro == true);

            Console.Clear();

            return opcao;
        }


        static void Main(string[] args)
        {
            bool verifErro = false;
            int opcao = 0, tipoFunc = 0; // 1 = junior, 2 = sênior, 3 = gerente, 4 = diretor
            double totalFolhaPag = 0;

            IFuncionario[] junior = new Junior[3];
            IFuncionario[] senior = new Senior[2];
            IFuncionario[] gerente = new Gerente[2];
            IFuncionario[] diretor = new Diretor[1];

            do
            {

                opcao = Menu();

            switch (opcao)
            {
                case 1: // Cadastro de funcionários
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Qual tipo de funcionário deseja cadastrar?");
                        Console.WriteLine("\nAnalista:\n1- Junior\n2- Sênior");
                        Console.WriteLine("Outros:");
                        Console.WriteLine("3- Gerente");
                        Console.WriteLine("4- Diretor *kkk, diretor = outros... okay, ficou bom! :'(");

                        try
                        {
                            verifErro = false;
                            tipoFunc = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException formex)
                        {
                            Console.WriteLine("\n" + formex.Message);
                            verifErro = true;
                        }
                        catch
                        {
                            Console.WriteLine("EROUUU (voz do Silvio S.)!!");
                            verifErro = true;
                        }
                    } while (verifErro == true);

                    if (tipoFunc == 1)
                        CadastroFuncs (junior, 1);
                    else if (tipoFunc == 2)
                        CadastroFuncs (senior, 2);
                    else if(tipoFunc == 3)
                        CadastroFuncs (gerente, 3);
                    else if (tipoFunc == 4)
                        CadastroFuncs (diretor, 4);

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 2: //Listar todos funcionários
                    Console.Clear();

                    Console.WriteLine("Analistas:");
                    Console.WriteLine("\nJuniores:");
                    ImprimeDados(junior);

                    Console.WriteLine(new string('-', 30));

                    Console.WriteLine("Seniores:");
                    ImprimeDados(senior);

                    Console.WriteLine(new string('-', 30));

                    Console.WriteLine("Gerentes:");
                    ImprimeDados(gerente);

                    Console.WriteLine(new string('-', 30));

                    Console.WriteLine("Diretor(es):");
                    ImprimeDados(diretor);

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    totalFolhaPag = 0;

                    Console.Clear();
                    Console.WriteLine("Total folha pagamento:");

                    totalFolhaPag = CalcFolhaPag(junior);
                    totalFolhaPag += CalcFolhaPag(senior);
                    totalFolhaPag += CalcFolhaPag(gerente);
                    totalFolhaPag += CalcFolhaPag(diretor);

                    Console.WriteLine("R${0}", totalFolhaPag);

                    Console.WriteLine("\n\nPressione qualquer tecla para voltar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
            } while (opcao != 4);
        }
    }
}
