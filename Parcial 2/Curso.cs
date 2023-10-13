using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<Estudiante> alumnosdelcurso = new List<Estudiante>();

        public Profesor     Profesor {  get; set; }

        public Curso(string nombre, string codigo, string descripcion, DateTime fechaInicio, DateTime fechaFin, int capacidadMaxima, Profesor profesor)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.CapacidadMaxima = capacidadMaxima;
            this.Profesor = profesor;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            if (alumnosdelcurso.Count < CapacidadMaxima)
            {
                alumnosdelcurso.Add(estudiante);
                
            }
            else
            {
                MessageBox.Show("El curso esta lleno");
            }
        }
    }
}
