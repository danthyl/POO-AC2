using System;
using System.Globalization;

namespace ATV_EXER_11._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(1001, "Goku", 0.0);
            ContaJuridica conta2 = new ContaJuridica(8010, "Lara Croft", 100.0, 500.0);

            //UPCASTING
            Conta acc = conta2;
            Conta conta3 = new ContaJuridica(1003, "Trunks", 0.0, 200.00);
            Conta conta4 = new ContaPoupanca(1004, "Vegeta", 0.0, 0.01);
            //DOWNCASTING
            ContaJuridica conta5 = (ContaJuridica)conta2;
            conta5.Emprestimo(100.0);

            if(conta3 is ContaJuridica)
            {
                ContaJuridica conta6 = conta3 as ContaJuridica;
                conta6.Emprestimo(200.0);
                Console.WriteLine("Empréstimo!");
            }
            else if(conta3 is ContaPoupanca)
            {
                ContaPoupanca conta6 = conta3 as ContaPoupanca;
                conta6.AtualizacaoSaldo();
                Console.WriteLine("Atualizado!");
            }

            Console.Write("Dados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo);

            Console.WriteLine("\nDeclare a quantidade para saque: ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(qtd);

            Console.WriteLine("Dados atualizados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("\nDeclare a quantidade para depósito: ");
            qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(qtd);

            Console.WriteLine("Dados atualizados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            //Caso o valor total do saldo seja menor que o empréstimo
            /*if (conta.Saldo <= conta.EmprestimoLimite)
            {
                Console.WriteLine("\nDeclare a quantidade para empréstimo: ");
                qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Emprestimo(qtd);

                Console.WriteLine("Dados atualizados da conta: N°" + conta.Numero + ", Titular: " + conta.Titular
                + ", Saldo: " + conta.Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + ", Empréstimo Limite: " + conta.EmprestimoLimite);
            }*/
            Console.ReadKey();
        }
    }
}
