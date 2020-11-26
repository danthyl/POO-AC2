using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER1_25._11._2020
{
    class ProdutoUsado : Produto
    {
        //Encapsulamento
        public DateTime Fabricacao { get; set; }

        //Construtor
        public ProdutoUsado(string nome, double preco, DateTime fab) : base(nome, preco)
        {
            Fabricacao = fab;
        }

        public override string PrecoTag()
        {
            return base.precoTag();
        }
    }
}
