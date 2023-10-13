using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int CapacidadMaxima { get; set; }
       

        public Curso(string nombre, string codigo, string descripcion, DateTime fechaInicio, DateTime fechaFin, int capacidadMaxima )
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.CapacidadMaxima = capacidadMaxima;
            
        }
    }
}
