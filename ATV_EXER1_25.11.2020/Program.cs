using System;
using System.Collections.Generic; 
using System.Globalization;

namespace ATV_EXER1_25._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();
            Console.WriteLine("Entre com o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i < n; i++)
            {
                Console.Write("\nPRODUTO #{i}: ");
                Console.Write("Comum, Importado, Usado (C/I/U)? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());

                if(ch == 'C')
                {
                    string nome = Console.ReadLine();
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Produto(nome, preco));
                }

                else if(ch == 'I')
                {
                    string nome = Console.ReadLine();
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ProdutoImportado(nome, preco, taxa));
                }

                else if(ch == 'U')
                {
                    string nome = Console.ReadLine();
                    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    DateTime fab = DateTime.Parse(Console.ReadLine());

                    list.Add(new ProdutoUsado(nome, preco, fab));
                }
            }

            Console.WriteLine("\nEtiquetas: ");
            foreach(Produto obj in list)
            {
                Console.WriteLine(list);
            }
        }
    }
}
