using System;
using System.Globalization;

namespace ATV_EXER_11._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaJuridica conta = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);

            Console.Write("Dados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo + ", Empréstimo Limite: " + conta.EmprestimoLimite);

            Console.WriteLine("\nDeclare a quantidade para saque: ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(qtd);

            Console.WriteLine("Dados atualizados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture) 
                + ", Empréstimo Limite: " + conta.EmprestimoLimite);

            Console.WriteLine("\nDeclare a quantidade para depósito: ");
            qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(qtd);

            Console.WriteLine("Dados atualizados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + ", Empréstimo Limite: " + conta.EmprestimoLimite);

            //Caso o valor total do saldo seja menor que o empréstimo
            if (conta.Saldo <= conta.EmprestimoLimite)
            {
                Console.WriteLine("\nDeclare a quantidade para empréstimo: ");
                qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Emprestimo(qtd);

                Console.WriteLine("Dados atualizados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + ", Empréstimo Limite: " + conta.EmprestimoLimite);
            }
            Console.ReadKey();
        }
    }
}
