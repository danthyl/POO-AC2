using System;

namespace ATV_EXER2_02._11._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definiçaõ das linhas e colunas
            Console.WriteLine("\nDeclare a linha e coluna: ");
            Console.WriteLine("Dê espaço após declarar a linha para declarar a coluna ");
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            //Matriz 
            int[,] mat = new int[m, n];

            //Valores dentro da matriz
            for (int i = 0; i < m; i++)
            {
                string[] value = Console.ReadLine().Split(' ');
                for (int a = 0; a < n; a++)
                {
                    mat[i, a] = int.Parse(value[a]);
                }
            }

            //Declaração de um número para encontrar na Matriz
            Console.WriteLine("\nDeclare um número inteiro que tem na matriz: ");
            int x = int.Parse(Console.ReadLine());

            //Busca da posição do número na Matriz
            for (int i = 0; i < m; i++)
            {
                for (int a = 0; a < n; a++)
                {
                    if (mat[i, a] == x)
                    {
                        Console.WriteLine("\nPosicionamento: " + i + ", " + a + ": ");
                        if (a > 0)
                        {
                            //Número posicionado na esquerda
                            Console.WriteLine("Esquerda: " + mat[i, a - 1]);
                        }
                        else if (i > 0)
                        {
                            //Número posicionado acima
                            Console.WriteLine("Acima: " + mat[i - 1, a]);
                        }
                        else if (a < n - 1)
                        {
                            //Número posicionado na direita
                            Console.WriteLine("Direita: " + mat[i, a + 1]);
                        }
                        else if (a < m - 1)
                        {
                            //Número posicionado abaixo
                            Console.WriteLine("Abaixo: " + mat[i + 1, a]);
                        }
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
