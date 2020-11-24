using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER2_25._11._2020
{
    /*no tipo de classe abstract não consegue criar um objeto direto dela,
     * e podem herdar de outras classes abstract
     */
    abstract class Conta
    {
        //Encapsulamento com protected pra haver alterações entre as classes
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        //Construtores, um padrão e outro com paramêtros
        public Conta() { }
        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        //Métodos para Saque e Déposito e virtual para sobreposição
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
