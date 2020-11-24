using System;
using ATV_EXER3_25._11._2020.Entities;
using ATV_EXER3_25._11._2020.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;

namespace ATV_EXER3_25._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista da classe Forma
            List<Forma> list = new List<Forma>();
            Console.WriteLine("Entre com o n° da forma: ");
            int n = int.Parse(Console.ReadLine());

            //for para entrada de dados
            for(int i = 1; i < n; i++)
            {
                Console.Write($"\nForma #{i}:");
                Console.Write("\nRetângulo ou Circulo [R/C]? ");
                char ch = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Cor: Preto, Azul ou Vermelho? ");
                Color cor = Enum.Parse<Color>(Console.ReadLine());

                //Escolha da forma
                if(ch == 'R')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Adição na lista com paramêtros da classe Retangulo
                    list.Add(new Retangulo(largura, altura, cor));
                }
                else if(ch == 'C')
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Adição na lista com paramêtros da classe Circulo
                    list.Add(new Circulo(raio, cor));
                }
            }

            Console.WriteLine("\nÁrea de cada forma: ");
            foreach(Forma f in list)
            {
                Console.WriteLine(f.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
