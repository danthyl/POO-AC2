using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER2_19._10._2020
{
    class Hospedes
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        //Construtor
        public Hospedes(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        //String para aparecer o nome e email nos quartos ocupados
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
