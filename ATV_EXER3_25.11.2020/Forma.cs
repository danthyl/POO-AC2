using System;
using System.Collections.Generic;
using System.Text;
using ATV_EXER3_25._11._2020.Entities.Enums;

namespace ATV_EXER3_25._11._2020.Entities
{
    //Classe abstrata
    abstract class Forma
    {
        public Color Color { get; set; }

        public Forma(Color cor)
        {
            Color = cor;
        }

        public abstract double Area();
    }
}
