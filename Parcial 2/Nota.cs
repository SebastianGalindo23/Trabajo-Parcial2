using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    public class Nota
    {
        public Curso Curso { get; set; }
        public Estudiante Estudiante { get; set; }
        public double Valor { get; set; }
        public Nota(Curso curso, Estudiante estudiante, double valor)
        {
            this.Curso = curso;
            this.Estudiante = estudiante;
            this.Valor = valor;
        }
    }
}
