using System;
using System.Collections.Generic;

namespace ATV_EXER1_26._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista de string
            List<string> list = new List<string>();

            //Adição na lista
            list.Add("Fábio");
            list.Add("Wilson");
            list.Add("Angelina");
            list.Add("Eliney");
            list.Add("Andre");

            //Adição de elemento
            list.Insert(2, "Lucas");

            //loop de leitura dos elementos
            foreach(string obj in list)
            {
                Console.WriteLine("Sobreviventes: " + obj);
            }

            //Contação dos elementos
            Console.WriteLine("\nQuantidade de elementos: " + list.Count);

            //Encontrar o primeiro elemento com letra A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("\n1° elemento que começa com letra A: " + s1);
            //Encontrar o último elemento com letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("1° elemento que começa com letra A: " + s2);

            //Buscar pela posição
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("\n1° posição da letra A: " + pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Última posição da letra A: " + pos2);

            //Buscar elementos com tamanhos igual a 5 caract.
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine();
            foreach(string obj in list2)
            {
                Console.WriteLine("Nomes com tamanho 5: " + obj);
            }

            //Remover elemento
            list.Remove("Andre");
            Console.WriteLine();
            foreach(string obj in list)
            {
                Console.WriteLine("Sobreviventes: " + obj);
            }

            //Remover determinado elemento
            list.RemoveAll(x => x[0] == 'W');
            Console.WriteLine();
            foreach(string obj in list)
            {
                Console.WriteLine("Sobreviventes: " + obj);
            }

            //Remover elemento de determinada posição
            list.RemoveAt(3);
            Console.WriteLine();
            foreach(string obj in list)
            {
                Console.WriteLine("Sobreviventes: " + obj);
            }

            //Remover elementos a partir da posição e quantos elementos
            list.RemoveRange(1, 2);
            Console.WriteLine();
            foreach(string obj in list)
            {
                Console.WriteLine("Sobreviventes: " + obj);
            }
        }
    }
}
