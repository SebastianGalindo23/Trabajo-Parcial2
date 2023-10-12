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
    public partial class Gestion_Alumnos : Form
    {
        Logistica logistica = new Logistica();

        public Gestion_Alumnos(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
            rellenarTabla();

        }

        private void TablaEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        public void rellenarTabla()
        {
            foreach (Estudiante estudiante in logistica.listaEstudiantes)
            {
                int rowIndex = TablaEstudiantes.Rows.Add();
                DataGridViewRow row = TablaEstudiantes.Rows[rowIndex];
                row.Cells[0].Value = estudiante.Nombre;
                row.Cells[1].Value = estudiante.Apellido;
                row.Cells[2].Value = estudiante.FechaNacimiento;
                row.Cells[3].Value = estudiante.Direccion;
                row.Cells[4].Value = estudiante.IdEstudiente;
                row.Cells[5].Value = estudiante.CorreoElectronico;
                row.Cells[6].Value = estudiante.NumeroCelular;
                row.Cells[7].Value = estudiante.Matricula;



            }
        }
        private void Gestion_Alumnos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(logistica);
            this.Hide();
            inicio.Show();
            
        }

        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            CrearUsuario estudiante = new CrearUsuario(logistica);
            this.Hide();
            estudiante.Show();
        }

        private void EditarBoton_Click(object sender, EventArgs e)
        {
            EditarAlumno editaralumnos = new EditarAlumno(logistica);
            this.Hide();
            editaralumnos.Show();
        }
    }
}
