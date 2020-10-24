using System;
using System.Globalization;

namespace ATV_EXER1_16._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares irá comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = Dolar.CotacaoDolar(cotacao, quantia);
            Console.WriteLine("Valor a ser pago: " + result.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
