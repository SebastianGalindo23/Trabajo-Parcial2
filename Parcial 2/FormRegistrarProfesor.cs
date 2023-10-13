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
    public partial class FormRegistrarProfesor : Form
    {
        public FormRegistrarProfesor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text; 
            string apellido = txtApellido.Text;
            string especialidad = txtEspecialidad.Text;
            int telefono = int.Parse(txtTelefono.Text);
            string direccion = txtDireccion.Text;
            string correo = txtCorreo.Text;
            Profesor nuevoProfesor = new Profesor(nombre, apellido, especialidad, telefono, direccion, correo);

            
            GestorProfesores gestorProfesores = new GestorProfesores();
            gestorProfesores.ProfesoresList.Add(nuevoProfesor);

            
            DialogResult = DialogResult.OK;

            
            MessageBox.Show("Guardado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            this.Close();
        }
    }
}
