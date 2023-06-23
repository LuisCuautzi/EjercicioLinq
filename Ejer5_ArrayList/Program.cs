using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq ArrayList");

            ArrayList lista = new ArrayList();

            lista.AddRange(new object[] { "hola", 5, 6.7, false, 4, 2, "saludos", 3.5, 3 });

            //Ejrcicio 1 
            //Obtener solo los enteros
            var enteros = lista.OfType<int>();

            Console.WriteLine("Solo un atributo");
            foreach(int n in enteros)
            {
                Console.WriteLine(n);
            }

            //Ejercicio 2
            //Creemos un arraylist
            //Creemos la lista
            ArrayList estudiantes = new ArrayList()
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientada a Objetos",9.0),
                new CEstudiante("Juan","S875","Programacion Basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","A456","Orientada a Objetos",8.3)
            };

            //ArrayList no implementa a IEnumerable por lo que no puedo usar Linq para eso hay que transformarlo en un tipo que implementa IEnumerable de la sig manera
            var estl = estudiantes.OfType<CEstudiante>();

            //Ahora si se puede usar linq y encontramos los reprobado
            var reprobados = from e in estl
                             where e.Promedio <= 5.0
                             select e;

            //Mostramos los resultados regresando todo el objeto
            Console.WriteLine("Reprobados");
            foreach (CEstudiante e in reprobados)
            {
                Console.WriteLine(e);
            }

            //Ejercicio proyeccion
            //Hacemos proyeccion a un nuevo tipo por medio de tipos anonimos
            //Creemos la lista

            List<CEstudiante> estudiante = new List<CEstudiante>
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientada a Objetos",9.0),
                new CEstudiante("Juan","S875","Programacion Basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","A456","Orientada a Objetos",8.3)
            };

            var nombrePromedio = from e in estudiante
                                 select new { e.Nombre, e.Promedio };

            foreach (var np in nombrePromedio)
                Console.WriteLine(np);

            Console.ReadKey();
        }
    }
}
