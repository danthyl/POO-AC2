using System;
using System.Collections.Generic;
using System.Text;
using ATV_EXER3_25._11._2020.Entities.Enums;

namespace ATV_EXER3_25._11._2020.Entities
{
    class Retangulo : Forma
    {
        //Encapsulamento
        public double Largura { get; set; }
        public double Altura { get; set; }

        //Construtor
        public Retangulo(double largura, double altura, Color cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        //Override para sobreposição do mesmo método em outra classe
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
