using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7_OperConjuntos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios con conjuntos");
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            //Except(Left y Right) nos da la diferencia entre dos contenedores}
            var expt = (from n2 in conjunto2 select n2)
                .Except(from n1 in conjunto1 select n1);

            Console.WriteLine("Except");
            foreach (int num in expt)
            {
                Console.WriteLine(num);
            }

            //El Inner join nis da la Interseccion entre dos contenedores
            var ints = (from n1 in conjunto1 select n1)
                .Intersect(from n2 in conjunto2 select n2);

            Console.WriteLine("Intersec");
            foreach (int num in ints)
            {
                Console.WriteLine(num);
            }

            //Nos da la coleccion que une a ambos sin repeticiones entre dos contenedores
            var union = (from n1 in conjunto1 select n1)
                .Union(from n2 in conjunto2 select n2);

            var unionasc = from n in union orderby n ascending select n;

            Console.WriteLine("Union");
            foreach (int num in unionasc)
            {
                Console.WriteLine(num);
            }

            //Nos da la concatenacion a los dos contenedores
            var cnt = (from n1 in conjunto1 select n1).Concat(from n2 in conjunto2 select n2);

            Console.WriteLine("Concatenar");
            foreach (int num in cnt)
            {
                Console.WriteLine(num);
            }

            //Nos da la diferencia y remueve los duplicados
            Console.WriteLine("Distinc");
            foreach (int num in cnt.Distinct())
            {
                Console.WriteLine(num);
            }

            List<int> numeros = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            IEnumerable<int> filtteringQuery = from num in numeros
                                               where num < 3 || num > 7
                                               orderby num ascending
                                               select num;

            Console.WriteLine("Usando Or");
            foreach (int num in filtteringQuery)
            {
                Console.WriteLine(num);
            }

            //Ejemplo de ToUpper con string
            string[] names = {"Burke", "Connor", "Frank",
                               "Everett", "Albert", "Gearge",
                                "Harris", "David"};

            IEnumerable<string> query = from s in names
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();

            foreach (string item in  query)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
