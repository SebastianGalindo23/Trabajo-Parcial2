using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int IdEstudiente { get; set; }
        public string CorreoElectronico{ get; set; }
        public int NumeroCelular { get; set; }
        public Guid Matricula { get; set; }

        

        public Estudiante(string nombre, string apellido, DateTime fechanacimiento, string direccion, int idestudiante, string correo, int numerocelular)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this. FechaNacimiento = fechanacimiento;
            this.Direccion = direccion;
            this.IdEstudiente = idestudiante;
            this.CorreoElectronico = correo;
            this.NumeroCelular = numerocelular;
            this.Matricula = Guid.NewGuid();
      
        }

        public void EditarDatos(string nombre, string apellido, DateTime fechanacimiento, string direccion, int idestudiante, string correo, int numerocelular)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaNacimiento = fechanacimiento;
            this.Direccion = direccion;
            this.CorreoElectronico = correo;
            this.NumeroCelular = numerocelular;
        }

   

    }
}
