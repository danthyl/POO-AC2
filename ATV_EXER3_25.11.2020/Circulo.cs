using System;
using System.Collections.Generic;
using System.Text;
using ATV_EXER3_25._11._2020.Entities.Enums;

namespace ATV_EXER3_25._11._2020.Entities
{
    class Circulo : Forma
    {
        //Encapsulamento
        public double Raio { get; set; }

        //Construtor
        public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
        }

        //Override para sobreposição
        public override double Area()
        {
            return MathF.PI * Raio * Raio;
        }
    }
}
