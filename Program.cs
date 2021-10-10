using System;
using System.Globalization;

namespace cap5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Número da conta: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string nTitular = Console.ReadLine();
            Console.Write("Depósito inicial? s/n : ");
            double sConta = 0;
            string resposta = Console.ReadLine();
            if (resposta.ToUpper() == "S")
            {
                Console.Write("Digite o valor: R$ ");
                sConta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            }
            else if (resposta.ToUpper() == "N")
                {
                    sConta = 0.00;
                }
            else
            {
                Console.WriteLine("Opção inválida! Digite S ou N : ");
            }


            //double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Instanciando uma classe (criando um novo objeto do tipo conta bancária) - lembrete: é posicional
            ContaBancaria conta = new ContaBancaria(nConta, nTitular, sConta);

            //Utiliza o método ToString na classe ContaBancaria
            Console.WriteLine(conta);

            Console.Write("Valor novo depósito: R$ ");
            conta.deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarSaldo();

            Console.WriteLine(conta);

            Console.Write("Valor do saque: R$ ");
            conta.saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RemoverSaldo();

            Console.WriteLine(conta);

            Console.ReadKey();
        }
    }
}
