using System;

namespace ATV_EXER1_02._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da Matriz
            Console.WriteLine("Declare o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            //Leitura 
            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for(int a = 0; a < n; a++)
                {
                    mat[i, a] = int.Parse(values[a]);
                }
            }

            //Impressão
            Console.WriteLine("Diagonal Principal: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }

            int count = 0;
            for(int i = 0; i < n; i++)
            {
                for(int a = 0; a < n; a++)
                {
                    if(mat[i,a] < 0)
                    {
                        count++;
                    }
                }
            }

            //Demonstração dos N° negativos
            Console.WriteLine("\nNúmeros negativos: " + count);         
        }
    }
}
