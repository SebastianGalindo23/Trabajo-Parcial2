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
    public partial class CrearUsuario : Form
    {
        Logistica logistica = new Logistica();
        public CrearUsuario(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(Idtext.Text, out _))
            {
                MessageBox.Show("Solo se permiten números enteros en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Idtext.Text = string.Empty;
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

        private void crearboton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Idtext.Text, out int id) && int.TryParse(Numerotext.Text, out int numero))
            {
                logistica.listaEstudiantes.Add(new Estudiante(Nombretext.Text, Apellidotext.Text, Fechanacimiento.Value, Direcciontext.Text, id, Correotext.Text, numero));
            }
            else
            {
                MessageBox.Show("Asegúrate de que los campos Id y Número sean números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Gestion_Alumnos gestionaalumnos = new Gestion_Alumnos(logistica);
            this.Hide();
            gestionaalumnos.Show();

        }
    }
}
