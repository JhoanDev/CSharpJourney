using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double ConverteParaReais(double cotacaoDoDolar, double qntDeDolares)
        {
            double valorEmReais = cotacaoDoDolar * qntDeDolares;
            valorEmReais += valorEmReais * IOF;
            return valorEmReais;
        }
    }
}
