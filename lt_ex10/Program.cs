using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lt_ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 aux = 0, i, acum = 0, acum2 = 0;
            string auxstr = "*";
            string aster = "*";
            string space = " ";
            Console.Write("Ingrese la altura de la piramide: ");
            auxstr = Console.ReadLine();
            Int32.TryParse(auxstr, out aux);
            while (aux <= 0)
            {
                Console.Write("ERROR, REINGRESE NUMERO (mayor a cero): ");
                auxstr = Console.ReadLine();
                int.TryParse(auxstr, out aux);
            }
            Console.Clear();

            for (i = 0; i < (aux * 2); i += 2)  //calculo la cantidad de espacios al igual que lo hago con el asterisco
            {                                       //para que quede centrado.
                space += " ";
            }
            for (i = 0; i < (aux * 2); i += 2)
            {
                Console.Write(space);

                Console.Write(aster);
                Console.WriteLine("");
                aster += "**";          //sumo dos asteriscos por iteracion

                space = space.Remove(space.Length - 1); //borro el ultimo caracter de el string pasado como parametro

            }

            Console.ReadKey();
        }
    }
}
