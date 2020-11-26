using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER1_25._11._2020
{
    class ProdutoImportado : Produto
    {
        //Encapsulamento
        public double Taxa { get; set; }

        //Construtor
        public ProdutoImportado(string nome, double preco, double taxa) : base(nome, preco)
        {
            Taxa = taxa;
        }

        public override string PrecoTag()
        {
            return base.precoTag();
        }
    }
}
