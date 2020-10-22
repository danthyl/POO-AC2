using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ATV_EXER1_07._10._2020
{
    class Dados
    {
        public int Conta;
        public string Nome;
        public double Deposito;

        public Dados(int conta, string nome, double deposito, double saque)
        {
            Conta = conta;
            Nome = nome;
            Deposito = deposito;
        }

        public void Depositar(double quant)
        {
            Deposito += quant;
        }

        public void Sacar(double quant)
        {
            Deposito -= quant;
            Deposito -= 5;
        }

        public override string ToString()
        {
            return "N° da conta: " + Conta
                + " Titular: " + Nome
                + " Saldo: R$" + Deposito.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
