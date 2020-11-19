using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER_11._11._2020
{
    class ContaJuridica : Conta
    {
        public double EmprestimoLimite { get; set; } //encapsulamento

        //Criação de contrutor padrão e outro com paramêtros
        public ContaJuridica() { }
        public ContaJuridica(int numero, string titular, double saldo, double emprestimolimte) : base(numero, titular, saldo)
        {
            EmprestimoLimite = emprestimolimte;
        }

        //Método para Empréstimo
        public void Emprestimo(double total)
        {
            if(total <= EmprestimoLimite)
            {
                Saldo += total;
            }
        }
    }
}
