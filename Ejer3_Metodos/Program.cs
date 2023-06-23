using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Obtener los resultados desde metodos
            //Invocamos el metodo obtener numeros pares el cual regresa una coleccion

            IEnumerable<int> resultados = CClaseExplicita.ObtenerNumeros();

            //Mostrar los resultados
            foreach (int num int resultados)
                    Console.WriteLine(num);

            Console.WriteLine(".........");

            //Invocar el metodo obtenerPostres
            IEnumerable<int> postres = CClaseExplicita.ObtenerNumerosImpares();
            //Mostrar los resultados
            foreach (string p int postres)
                    Console.WriteLine(p);

            Console.WriteLine(".........");

            //Ejemplo del resultado de query inmediato
            int[] impares = CClaseExplicita.ObtenerNumerosImpares();

            //Mostrar los resulatdos
            foreach (int m in impares)
            {
                Console.WriteLine(m);
            }
            Console.ReadKey();
        }
    }
}
