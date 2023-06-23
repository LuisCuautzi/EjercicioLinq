using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1Ordenar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //Utilizar linq con arreglo de números
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };

            IEnumerable<int> valores = from n in numeros
                                       where n > 3 && n < 8
                                       orderby n
                                       select n;

            //Mostrar los numeros
            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine("....");
            Console.ReadKey();
        }
    }
}
