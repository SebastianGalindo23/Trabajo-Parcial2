using Parcial_2;
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
    public partial class GestionCursos : Form
    {
        List<string> nombresEstudiantes;
        List<string> NombreCursos;
        Logistica logistica = new Logistica();
        public GestionCursos(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
            Llenartabla();
            nombresEstudiantes = logistica.listaEstudiantes.Select(estudiante => estudiante.Nombre).ToList();
            NombreCursos = logistica.listadeCursos.Select(cursos => cursos.Nombre).ToList();
            ConfigureDomainUpDown();
        }

        private void GestionCursos_Load(object sender, EventArgs e)
        {

        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            FormRegistrarCurso formRegistrarCurso = new FormRegistrarCurso(logistica);
            this.Hide();
            formRegistrarCurso.Show();
        }

        public void Llenartabla()
        {
            foreach(Curso curso in logistica.listadeCursos)
            {
                int rowIndex = TablaCursos.Rows.Add();
                DataGridViewRow row = TablaCursos.Rows[rowIndex];
                row.Cells[0].Value = curso.Nombre;
                row.Cells[1].Value = curso.Codigo;
                row.Cells[2].Value = curso.Descripcion;
                row.Cells[3].Value = curso.FechaInicio;
                row.Cells[4].Value = curso.FechaFin;
                row.Cells[5].Value = curso.CapacidadMaxima;
                row.Cells[6].Value = curso.Profesor.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(logistica);
            this.Hide();
            inicio.Show();
        }

        private void SeleccionarEstudiante_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void ConfigureDomainUpDown()
        {
            SeleccionarEstudiante.Items.AddRange(nombresEstudiantes.ToArray());
            SeleccionarCursos.Items.AddRange(NombreCursos.ToArray());
        }

        private void agrearalumnos_Click(object sender, EventArgs e)
        {
            SeleccionarCursos.Visible = true;
            SeleccionarEstudiante.Visible = true;
            AgregarCurso.Visible = true;
        }

        private void AgregarCurso_Click(object sender, EventArgs e)
        {
            string Alumno = SeleccionarEstudiante.Text;
            string Curso = SeleccionarCursos.Text;
            if (!string.IsNullOrEmpty(Alumno) && (!string.IsNullOrEmpty(Curso)))
            {
                Estudiante estudianteEncontrado = logistica.listaEstudiantes.Find(estudiante => estudiante.Nombre == Alumno);
                Curso cursoencontrado = logistica.listadeCursos.Find(cus => cus.Nombre == Curso);

                if (estudianteEncontrado != null && cursoencontrado != null)
                {
                    cursoencontrado.AgregarEstudiante(estudianteEncontrado);
                    MessageBox.Show($"Se agrego el estudiante: {estudianteEncontrado.Nombre} al curso: {cursoencontrado.Nombre}");
                    SeleccionarCursos.Visible = false;
                    SeleccionarEstudiante.Visible = false;
                    AgregarCurso.Visible = false;
                }
                else
                {
                    MessageBox.Show("Estudiante o curso no encontrado.");
                }

            }

        }

        private void TablaCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SeleccionarCursos_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}

