using System;
using System.Numerics;

namespace ATV_EXER2_19._10._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array com n° de hospedes/quartos
            Hospedes[] vect = new Hospedes[10];

            Console.WriteLine("Declare a quantidade de hóspedes: ");
            //Entrada do usuário da quantidade de hospedes
            int n = int.Parse(Console.ReadLine());            

            //for para declarar nome, email e o quarto
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nDeclare o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Declare o e-mail: ");
                string email = Console.ReadLine();
                Console.Write("Declare o quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                //array com as informações
                vect[quarto] = new Hospedes(nome, email);
            }

            Console.WriteLine();
            //Demonstração dos quartos ocupados
            Console.WriteLine("Quartos Ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                //demonstrar os quartos ocupados
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }    
}
