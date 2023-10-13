using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2
{
    public partial class Gestion_Notas : Form
    {
        List<string> NombreCursos;
        List<string> EstudianteEnCursos;
        Logistica logistica = new Logistica();
        public Gestion_Notas(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
            NombreCursos = logistica.listadeCursos.Select(cursos => cursos.Nombre).ToList();
            EstudianteEnCursos = logistica.listaEstudiantes.Select(estudiante => estudiante.Nombre).ToList();
            ConfigureDomainUpDown();
            
        }

        private void Gestion_Notas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(logistica);
            this.Hide();
            inicio.Show();
        }

        private void TablaNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConfigureDomainUpDown()
        {
            SeleccionarCursos.Items.AddRange(NombreCursos.ToArray());
        }

        private void SeleccionarCursos_SelectedItemChanged(object sender, EventArgs e)
        {
            string cursoSeleccionado = SeleccionarCursos.Text;


            Curso curso = logistica.listadeCursos.FirstOrDefault(Curso => Curso.Nombre == cursoSeleccionado);

            if (curso != null)
            {

                List<string> estudiantesEnCurso = curso.alumnosdelcurso.Select(estudiante => estudiante.Nombre).ToList();

                SeleccionarAlumnos.Items.Clear();
                SeleccionarAlumnos.Items.AddRange(estudiantesEnCurso.ToArray());
            }
            else
            {
                MessageBox.Show("El curso seleccionado no cuenta con alumnos");
            }
        }

        private void ReporteBoton_Click(object sender, EventArgs e)
        {
            double nota;
            if (double.TryParse(Notatxt.Text, out nota))
            {
                string cursoSeleccionado = SeleccionarCursos.Text;
                Curso curso = logistica.listadeCursos.FirstOrDefault(Curso => Curso.Nombre == cursoSeleccionado);
                string estudianteDelCurso = SeleccionarAlumnos.Text;
                Estudiante estudiante = curso.alumnosdelcurso.FirstOrDefault(alumno => alumno.Nombre == estudianteDelCurso);

                if (curso != null && estudiante != null)
                {
                    logistica.Calificaciones.Add(new Nota(curso, estudiante, nota));
                    TablaNotas.Rows.Clear();
                    llenarTabla();
                }
            }
            else
            {
                MessageBox.Show("El formato de la nota no es válido. Ingrese un número válido.", "Error");
            }
        }

        private void Notatxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Notatxt.Text) && !int.TryParse(Notatxt.Text, out _) && Notatxt.Text != null)
            {
                MessageBox.Show("Solo se permiten números enteros en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void llenarTabla()
        {
            foreach (Nota nota in logistica.Calificaciones)
            {
                int rowIndex = TablaNotas.Rows.Add();
                DataGridViewRow row = TablaNotas.Rows[rowIndex];
                row.Cells[0].Value = nota.Curso.Nombre;
                row.Cells[1].Value = nota.Estudiante.Nombre;
                row.Cells[2].Value = nota.Valor;

            }
        }
    }
}
