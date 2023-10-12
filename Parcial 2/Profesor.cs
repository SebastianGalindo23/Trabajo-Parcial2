using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    public class Profesor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }
        public int NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public Profesor(string nombre, string apellido, string especialidad, int telefono, string direccion, string correo ) 
        { 
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Especialidad = especialidad;
            this.NumeroTelefono = telefono;
            this.Direccion = direccion;
            this.Correo = correo;
        }
    }
}
