using System;
using System.Globalization;

namespace ATV_EXER1_19._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Declare a quantidade de produtos: ");
            //Variável para entrada de usuário
            int n = int.Parse(Console.ReadLine());
            //Array com variável anterior
            Produto[] vect = new Produto[n];

            //For para percorrer vect
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Declare o nome do produto: ");
                string name = Console.ReadLine();
                Console.WriteLine("Declare o preço do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                //vect com entrada do usuário
                vect[i] = new Produto { Name = name, Price = price };
            }
            //soma
            double s = 0.0;
            //for para soma do vect
            for(int i = 0; i < n; i++)
            {
                s += vect[i].Price;
            }
            //media da soma
            double media = s / vect.Length;

            Console.WriteLine("Média do preço: " + media.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
