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
    public partial class EditarAlumno : Form
    {
        List<string> nombresEstudiantes;
        Logistica logistica = new Logistica();
        public EditarAlumno(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
            nombresEstudiantes = logistica.listaEstudiantes.Select(estudiante => estudiante.Nombre).ToList();
            ConfigureDomainUpDown();
        }
        private void ConfigureDomainUpDown()
        {
            SeleccionarEstudiante.Items.AddRange(nombresEstudiantes.ToArray());
        }

        private void EditarAlumno_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion_Alumnos gestionalumnos = new Gestion_Alumnos(logistica);
            this.Hide();
            gestionalumnos.Show();
        }

        private void SeleccionarEstudiante_SelectedItemChanged(object sender, EventArgs e)
        {
            textbox();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            string estudianteSeleccionado = SeleccionarEstudiante.Text;
            if (!string.IsNullOrEmpty(estudianteSeleccionado))
            {
                Estudiante estudianteEncontrado = logistica.listaEstudiantes.FirstOrDefault(est => est.Nombre == estudianteSeleccionado);
                if (estudianteEncontrado != null)
                {

                    estudianteEncontrado.Nombre = Nombretext.Text;
                    estudianteEncontrado.Apellido = Apellidotext.Text;
                    estudianteEncontrado.FechaNacimiento = Fechanacimiento.Value;
                    estudianteEncontrado.CorreoElectronico = Correotext.Text;
                    estudianteEncontrado.Direccion = Direcciontext.Text;
                    int numeroCelular;
                    if (int.TryParse(Numerotext.Text, out numeroCelular))
                    {
                        estudianteEncontrado.NumeroCelular = numeroCelular;
                    }
                    else
                    {
                        MessageBox.Show("Número de celular no válido. No se realizó la actualización.");
                        
                    }
                    MessageBox.Show("Datos actualizados exitosamente");
                }
                else
                {
                    MessageBox.Show($"Estudiante no encontrado: {estudianteSeleccionado}");
                }
            }
        }

        private void textbox()
        {
            string estudianteSeleccionado = SeleccionarEstudiante.Text;
            if (!string.IsNullOrEmpty(estudianteSeleccionado))
            {
                Estudiante estudianteEncontrado = logistica.listaEstudiantes.FirstOrDefault(est => est.Nombre == estudianteSeleccionado);
                this.Nombretext.Text = estudianteEncontrado.Nombre;
                this.Apellidotext.Text = estudianteEncontrado.Apellido;
                this.Fechanacimiento.Value = estudianteEncontrado.FechaNacimiento;
                this.Numerotext.Text = estudianteEncontrado.NumeroCelular.ToString();
                this.Correotext.Text = estudianteEncontrado.CorreoElectronico;
                this.Direcciontext.Text = estudianteEncontrado.Direccion;
            }
        }

        private void Numerotext_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Numerotext.Text) && !int.TryParse(Numerotext.Text, out _))
            {
                MessageBox.Show("Solo se permiten números enteros en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Numerotext.Text = string.Empty;
            }
        }
    }
}
