using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer2_TiposImplicitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            //Usando tipo implicito para el query
            var valores = from n in numeros
                          where n % 2 == 0
                          select n;

            //Mostrar los resultados
            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine(".........");
            Console.ReadKey();

            //Ejercicio 2
            //Ejecucion diferida 
            //La exprecion no se evalua hasta que se itera sobre el arreglo
            //Por lo que nos permite ir modificando ese query viendo los resultados en tiempo real
            Console.WriteLine(".........");
            Console.WriteLine("..ejecucion diferida..");

            //Modifico el arreglo
            numeros[1] = 12;

            //Mostrar los resultados
            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine(".........");
            Console.ReadKey();

            //La ejecucion inmediata, ejecuta el query en el momento exacto, por lo tanto si se hace modificacion no realiza la actualizacion de query
            Console.WriteLine(".........");
            Console.WriteLine("..Ejecucion inmediata");
            Console.ReadKey();

            //Ejemplo con enteros guardamos los resultados con un arreglo
            int[] arrayValores = (from n in numeros
                                  where n % 2 == 0
                                  select n).ToArray<int>();

            //Ejemplo con lista guardamos los resultados con un list
            List<int> listValores = (from n in numeros where n % 2 == 0 select n).ToList<int>();

            //Mostramos
            Console.WriteLine("El arreglo");

            //Mostramos los resultados
            foreach (int num in arrayValores)
                Console.WriteLine(num);

            //Se actualiza despues de la modificacion
            numeros[0] = 28;

            Console.WriteLine("Se actualiza despues de la modificacion?");

            //Mostramos los resultados
            foreach (int num in arrayValores)
                Console.WriteLine(num);

            Console.WriteLine("La lista");
            //Mostrar los resultados
            foreach(int num in listValores)
                Console.WriteLine(num);

            Console.WriteLine(".........");
            Console.ReadKey();
        }
    }
}
