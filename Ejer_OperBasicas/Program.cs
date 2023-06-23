using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_OperBasicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Operaciones basicas con linq");

            //Creamos la lista
            List<CEstudiante> estudiante = new List<CEstudiante>
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientada a Objetos",9.0),
                new CEstudiante("Juan","S875","Programacion Basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","A456","Orientada a Objetos",8.3)
            };

            //Conteo
            int cantidad = (from e in estudiante
                            where e.Promedio > 5
                            select e).Count();

            Console.WriteLine("La cantidad aprobada es {0}", cantidad);

            //Reserva
            var aprobados = from e in estudiante
                            where e.Promedio > 5
                            select e;

            Console.WriteLine("Aprobados");

            foreach (CEstudiante est in aprobados)
            {
                Console.WriteLine(est);
            }

            Console.WriteLine("Orden inverso");

            foreach (CEstudiante est in aprobados.Reverse())
            {
                Console.WriteLine(est);
            }

            //Orden descendente
            Console.WriteLine("Orden Descendente");

            var ordenados = from e in estudiante
                            where e.Promedio > 5
                            orderby e.Promedio descending
                            select e;

            foreach (CEstudiante est in ordenados)
            {
                Console.WriteLine(est);
            }

            //Orden Ascendente
            Console.WriteLine("Orden Ascendente");

            var ordenadosA = from e in estudiante
                             where e.Promedio > 5
                             orderby e.Promedio ascending
                             select e;

            foreach (CEstudiante est in ordenadosA)
            {
                Console.WriteLine(est);
            }

            int[] numeros = { 2, 5, 3, 9, 1, 6, 4, 7, 8 };

            //Encontrar el maximo
            int maximo = (from n in numeros select n).Max();
            Console.WriteLine(maximo);

            //Encontrar el minimo
            int minimo = (from n in numeros select n).Min();
            Console.WriteLine(minimo);

            //Encontramos el promedio
            double promedio = (from n in numeros select n).Average();
            Console.WriteLine(promedio);

            int sumatoria = (from n in numeros select n).Sum();
            Console.WriteLine(sumatoria);

            Console.ReadKey ();
        }
    }
}
