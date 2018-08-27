using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_2018
{
    public class lt_ex1
    {
        public static void ex1()
        {
            Int32 Aux;
            Int32 i;
            Int32 Max = 0;
            Int32 Min = 0;
            float Prom;
            Int32 Acum = 0;
            string AuxStr;

            Console.WriteLine("Ingrese 5 numeros: ");

            for (i = 0; i < 5; i++)
            {
                AuxStr = Console.ReadLine();
                int.TryParse(AuxStr, out Aux);
                if (i == 0)
                {
                    Max = Aux;
                    Min = Aux;
                }
                if (Aux >= Max)
                {
                    Max = Aux;
                }
                if (Aux <= Min)
                {
                    Min = Aux;
                }
                Acum = Acum + Aux;
            }
            Prom = (float)Acum / 5;
            Console.WriteLine("el valor minimo es : {0} ", Min);
            Console.WriteLine("el valor maximo es : {0} ", Max);
            Console.WriteLine("el promedio es  : {0} ", Prom);

            Console.ReadKey();
        }
    }
}
