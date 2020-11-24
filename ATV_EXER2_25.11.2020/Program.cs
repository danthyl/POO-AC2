using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ATV_EXER2_25._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista da classe conta
            List<Conta> list = new List<Conta>();

            list.Add(new ContaPoupanca(1001, "Terry", 500.0, 0.01));
            list.Add(new ContaJuridica(1002, "Andy", 500.0, 400.00));
            list.Add(new ContaPoupanca(1003, "Joe", 500.0, 0.01));
            list.Add(new ContaJuridica(1004, "Mae", 500.0, 400.00));

            double sum = 0.0;
            //Soma dos saldos
            foreach(Conta acc in list)
            {
                sum += acc.Saldo;
            }

            Console.WriteLine("\nTotal do saldo de todas as contas: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Conta acc in list)
            {
                acc.Saque(10.0);
            }

            foreach(Conta acc in list)
            {
                Console.WriteLine("\nAtualização do saldo das contas: " +
                    acc.Numero + ": " + acc.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }           

            Console.ReadKey();
        }
    }
}
