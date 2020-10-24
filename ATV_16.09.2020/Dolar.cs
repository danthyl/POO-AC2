using System;
using System.Collections.Generic;
using System.Text;

namespace ATV_EXER1_16._09._2020
{
    class Dolar
    {
        public static double IOF = 6.0;

        public static double CotacaoDolar(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF / 100.0;
        }
    }
}
