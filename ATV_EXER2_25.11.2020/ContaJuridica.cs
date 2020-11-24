using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER2_25._11._2020
{
    class ContaJuridica : Conta
    {
        //encapsulamento
        public double EmprestimoLimite { get; set; } 

        //Construtor padrão
        public ContaJuridica() { }
        //Construtor com paramêtros
        public ContaJuridica(int numero, string titular, double saldo, double emprestimolimte) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimolimte;
        }

        //Método para Empréstimo
        public void Emprestimo(double total)
        {
            if (total <= EmprestimoLimite)
            {
                Saldo += total;
            }
        }
    }
}
