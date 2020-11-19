using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER_11._11._2020
{
    class Conta
    {
        public int Numero { get; private set; } //encapsulamento
        public string Titular { get; private set; } //encapsulamento
        public double Saldo { get; protected set; } //Protected para haver alterações entre classes

        //Construtor padrão e outro com paramêtros
        public Conta() { }
        public Conta(int numero, string titular, double saldo) 
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //Métodos para Saque e Déposito
        //virtual para sobreposição
        public virtual void Saque(double total)
        {
            Saldo -= total + 5.0;
        }

        public void Deposito(double total)
        {
            Saldo += total;
        }

    }
}
