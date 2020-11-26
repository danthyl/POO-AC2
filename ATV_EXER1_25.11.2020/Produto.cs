using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER1_25._11._2020
{
    class Produto
    {
        //Encapsulamento
        public string Nome { get; set; }
        public double Preco { get; set; } 

        //Construtor
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual String PrecoTag()
        {
            return precoTag();
        }
    }
}
