using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Mascotas
{
    public class Dueño
    {
        public string Nombre { get; }
        public string Direccion { get; }
        public string Telefono { get; }

        public Dueño(string nombre, string direccion, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
