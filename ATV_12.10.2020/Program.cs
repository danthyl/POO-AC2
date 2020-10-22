using System;
using System.Globalization;

namespace ATV_EXER1_12._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de pessoas: ");
            //Variável para a entrada de usuário
            int p = int.Parse(Console.ReadLine());
            
            //Array com a variável p para o número a ser usado
            double[] vect = new double[p];

            int n = 1;
            Console.WriteLine("Declare a altura das pessoas: ");

            //for para definição das alturas
            for(int i = 0; i < p; i++)
            {                
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Alturas das pessoas: " + "("+ n +") "+ vect[i]);
                n++;
            }

            //double para soma
            double s = 0.0;

            for(int i = 0; i < p; i++)
            {
                s += vect[i];
            }

            double media = s / vect.Length;
            Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture)); ;

            Console.ReadKey();
        }
    }
}
