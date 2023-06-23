using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer8_ExprecionesLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios con expreciones landda!");

            int[] fibNum = { 1, 1, 2, 3, 5, 8, 13, 21, 34 };

            double Promedio = fibNum.Where(num => num % 2 == 1).Average();
            Console.WriteLine(Promedio);

            //Ejer 2 con linq
            Console.WriteLine("Usando Or");
            List<int> numeros = new List<int> { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8 };

            IEnumerable<int> filtro = from num in numeros
                                      where num <= 3 || num >= 7
                                      orderby num ascending
                                      select num;
            foreach(int num in filtro)
            {
                Console.WriteLine(num);
            }

            //Ejer 2 con lamda
            Console.WriteLine("Con Lamda");
            int[] source = new[] { 3, 8, 4, 6, 1, 7, 9, 2, 4, 8 };

            var result = source.OrderBy(n => n);

            foreach (int i in result.Where(num =>
            {
                if (num <= 3)
                    return true;
                else if (num >= 7)
                    return false;
            })) 
                Console.WriteLine(i);
            Console.ReadLine();

            //Ejer 3 com linq
            string[] names =
            {
                "Burke", "Connor", "Frank","Everett", "Albert", "Gearge","Harris", "David"
            };

            IEnumerable<string> query = from s in names
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();
            foreach(string item in query)
                Console.WriteLine(item);

            //Ejercicio 3 con lamda
            IEnumerable<string> queryl = names
                .Where(s => s.Length == 5)
                .OrderBy(s => s)
                .Select(s => s.ToUpper());

            foreach (string item in queryl)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
