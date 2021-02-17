using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ_POO_Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string logradouro, localidade, bairro, nome;
            double cpf, numeroCasa, saldo, transferencia, deposito, saque;
            Cliente p1 = new Cliente
            {
                conta = new Conta
                {
                    Agencia = 145673,
                    Numero = 36654,
                    Saldo = 0,
                }
            };
            Cliente zezinho = new Cliente
            {
                Nome = "Zezinho Malandro",
                CPF = 45376289001,
                endereco = new Endereco
                {
                    Logradouro = "Rua Parnaíba",
                    NumeroCasa = 157,
                    Localidade = "Araraquara",
                    Bairro = "Melhado",
                },
                conta = new Conta
                {
                    Agencia = 145673,
                    Numero = 12346,
                    Saldo = 1500.00,
                }
            };

            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("#**************************************#");
                Console.WriteLine("#                                      #");
                Console.WriteLine("# ---       MENU PRINCIPAL        ---  #");
                Console.WriteLine("#                                      #");
                Console.WriteLine("# 1 -    Informar todos os dados       #");
                Console.WriteLine("# 2 -    Fazer Depósito                #");
                Console.WriteLine("# 3 -    Fazer Saque                   #");
                Console.WriteLine("# 4 -    Fazer transfêrencia           #");
                Console.WriteLine("# 5 -    Imprimir Saldo                #");
                Console.WriteLine("# ---                              --- #");
                Console.WriteLine("#                                      #");
                Console.WriteLine("#**************************************#");
                Console.WriteLine();
                Console.Write("Digite sua opcao: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Iniciando seu cadastro\n");
                        Console.Write("Informe seu nome completo: ");
                        nome = Console.ReadLine();
                        Console.Write("Informe seu CPF: ");
                        cpf = double.Parse(Console.ReadLine());
                        Console.Write("Informe seu logradouro: ");
                        logradouro = Console.ReadLine();
                        Console.Write("Informe seu bairro: ");
                        bairro = Console.ReadLine();
                        Console.Write("Informe sua cidade: ");
                        localidade = Console.ReadLine();
                        Console.Write("Informe o numero de sua casa: ");
                        numeroCasa = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        do
                        {
                            Console.Write("Digite um valor para o depósito em sua conta: $ ");
                            deposito = double.Parse(Console.ReadLine())
                        } while (deposito <= 0);
                        p1.conta.Saldo += deposito;
                        Console.WriteLine("Deposito efetuado com sucesso");
                        string voltar = "";
                        Console.Write("Deseja voltar para o menu inicial? _");
                        Console.ReadLine();
                        if (voltar == "s" || voltar == "sim")
                        {
                            menu = 6;
                            Console.Clear();
                        }
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        string voltar2 = "";
                        Console.WriteLine("Seu saldo é: " + p1.conta.Saldo);
                        Console.Write("Deseja voltar para o menu inicial? _");
                        Console.ReadLine();
                        if (voltar2 == "s" || voltar2 == "sim")
                        {
                            menu = 6;
                            Console.Clear();
                        }
                        break;
                }
            } while (menu > 5);

            Console.ReadKey();
           
        }
    }
}
