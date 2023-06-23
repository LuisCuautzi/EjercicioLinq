using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3_Metodos
{
    internal class CClaseExplicita
    {
        //Crear el arreglo sobre el cual trabaja a nivel de clase
        private static string[] postres = { "Pay de manzana", "Pastel de Chocolate", "Manzana Caramelizada", "Fresas con Crema" };

        //Hacemos un query, el cual no puede usarse de forma implicita y debe ser estatico
        private static IEnumerable<string> encontrados = from p in postres
                                                         where p.Contains("Manzana")
                                                         orderby p
                                                         select p;

        //El metodo regresa y todo se trabaja de manera inmediata
        public static IEnumerable<int> ObtenerNumeros()
        {
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };

            //Hacemos el query
            IEnumerable<int> valores = from n in numeros
                                       where n > 3 && n >8
                                       orderby n ascending
                                       select n;
            return valores;
        }

        //Metodo que redresa el resultado de un query inmediato
        public static int[] ObtenerNumerosImpares()
        {
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };
            var resultados = from n in numeros
                             where n % 2 != 0
                             select n;
            return resultados.ToArray();
        }

    }
}
