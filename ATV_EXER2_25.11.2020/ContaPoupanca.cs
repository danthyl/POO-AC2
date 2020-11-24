using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER2_25._11._2020
{
    class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca() { }
        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) :
            base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizacaoSaldo()
        {
            Saldo += Saldo * TaxaJuros;
        }

        //sobreposição
        public override void Saque(double total)
        {
            base.Saque(total);
            Saldo -= 2.0;
        }
    }
}

