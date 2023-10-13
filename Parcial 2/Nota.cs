using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void CalcularPromedio(Logistica logistica, string nombreCurso, DataGridView dataGridView)
        {
            var notasPorCurso = logistica.Calificaciones.Where(nota => nota.Curso.Nombre == nombreCurso);

            if (notasPorCurso.Any())
            {
                double promedio = notasPorCurso.Average(nota => nota.Valor);   
                dataGridView.Rows.Add(new object[] { nombreCurso, promedio });
            }
            else
            {  
                dataGridView.Rows.Add(new object[] { nombreCurso, "No hay notas" });
            }
        }

    }
}
