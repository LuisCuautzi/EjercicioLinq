using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer4_Collecciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq en Clases!");

            //Crear la Lista
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientada a Objetos",9.0),
                new CEstudiante("Juan","S875","Programacion Basica",5.0),
                new CEstudiante("Susana","A432","Mercadotecnia",8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","A456","Orientada a Objetos",8.3)
            };

            //Vamos a encontrar a los reprobados
            var reprobados = from e in estudiantes
                             where e.Promedio <= 5.0
                             select e;

            //Mostramos los resultados regresando todo el objecto
            Console.WriteLine("Reprobados");
            foreach (CEstudiante e in reprobados)
            {
                Console.WriteLine(e);
            }

            //Vamos a encontrar a los Aprobados
            var aprobados = from e in estudiantes
                            where e.Promedio > 5.0
                            select e;

            //Mostramos los resultados regresando todo el objecto
            Console.WriteLine("Aprobados");
            foreach (CEstudiante e in aprobados)
            {
                Console.WriteLine(e);
            }

            //Mostramos solo un atributo de los encontrados por medio de la propiedad
            Console.WriteLine("Solo un atributo");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r.Nombre);
            }

            //Encontramos los nombres y el identificador de los mercadotenia
            var mercadotecnia2 = from e in estudiantes
                                 where e.Curso == "Mercadotecnia"
                                 select e;

            Console.WriteLine("Nombres y Id de los alumnos de mercadotecnia");
            foreach (CEstudiante n in mercadotecnia2)
            {
                Console.WriteLine("{0}, {1}", n.Nombre, n.ID);
            }

            //Encontramos solo los nombres de los de mercadotecnia
            var mercadoctenia = from e in estudiantes
                                where e.Curso == "Mercadotecnia"
                                select e.Nombre;
            //Se muestran los resultados en donde se toma en cuenta el tipo del dato que esta regresando
            Console.WriteLine("Nombre de los alumnos de mercadotecnia");
            foreach (string n in mercadoctenia)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
