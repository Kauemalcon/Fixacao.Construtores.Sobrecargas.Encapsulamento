using System;
using System.Globalization;

namespace Fixacao.Construtores.Sobrecargas.Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco c = new ContaBanco();

            Console.Write("Entre com o número da conta: ");
            c.Conta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta:");
            c.Titular = Console.ReadLine();
            Console.WriteLine();

            double saldo = 0.0;


            Console.Write("Haverá depósito inicial (s/n)? : ");
            char sinal = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if (sinal == 's' || sinal == 'S' )
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Depositar(saldo);
                Console.WriteLine();
                Console.WriteLine("Dados da conta: " + c);
            }
            else
            {
                Console.WriteLine("Dados da conta: " + c);
            }

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(saldo);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: " + c);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Sacar(saque);
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: " + c);

        }
    }
}
