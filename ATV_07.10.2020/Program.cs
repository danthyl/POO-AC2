using System;
using System.Globalization;

namespace ATV_EXER1_07._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados a = new Dados(0, "Sem Nome", 0.0, 0.0);
            Console.WriteLine("Entre com o n° da conta: ");
            a.Conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta: ");
            a.Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') 
            { 
                Console.Write("Entre o valor de depósito inicial: ");
                double dpstInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                a.Deposito += dpstInicial;
            }
            else if(resp == 'n' || resp == 'N')
            {
                a.Deposito = 0;
            }

            Console.WriteLine("Dados da conta: " + a);

            Console.WriteLine("Entre com um valor para depósito: ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Depositar(qtd);

            Console.WriteLine("Dados atualizados: " + a);

            Console.WriteLine("Entre com um valor para saque: ");
            qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Sacar(qtd);

            Console.WriteLine("Dados atualizados: " + a);
        }
    }
}
