using System;
using System.Globalization;

namespace ATV_EXERC1_28._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto a = new Produto("PS5", 6000.00, 10);

            a.SetNome("XBOX X");

            Console.WriteLine("Nome do Produto: " + a.GetNome());
            Console.WriteLine("Preço do Produto: " + a.GetPreco().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Quantidade: " + a.GetQuantidade());

            Console.ReadKey();
        }
    }
}
