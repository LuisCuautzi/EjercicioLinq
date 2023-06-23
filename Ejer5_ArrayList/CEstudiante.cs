using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer5_ArrayList
{
    internal class CEstudiante
    {
        public string nombre, id, curso;
        public double promedio;

        public string Nombre { get { return nombre; } }
        public string ID { get { return id; } }
        public string Curso { get { return curso; } }
        public double Promedio { get { return promedio; } }

        public CEstudiante(string pNombre, string pID, string pCurso, double pPromedio)
        {
            nombre = pNombre;
            id = pID;
            curso = pCurso;
            promedio = pPromedio;

        }

        public override string ToString()
        {
            return string.Format("Nombre: {0},{1}, Curso: {2}, Promedio{3}", nombre, id, curso, promedio);
        }
    }
}
