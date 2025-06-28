using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Mascotas
{
    public class Mascota
    {
        public string Nombre { get; }
        public int Edad { get; }
        public string Raza { get; }
        public Dueño Dueño { get; }

        public Mascota(string nombre, int edad, string raza, Dueño dueño)
        {
            Nombre = nombre;
            Edad = edad;
            Raza = raza;
            Dueño = dueño;
        }
    }
}
