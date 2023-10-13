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
    public partial class Inicio : Form
    {
        Logistica logistica = new Logistica();
        public Inicio(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();

        }

        private void GestionAlumnos_Click(object sender, EventArgs e)
        {
            Gestion_Alumnos gestionalumnos = new Gestion_Alumnos(logistica);
            this.Hide();
            gestionalumnos.Show(); 


        }

        private void GestionProfesores_Click(object sender, EventArgs e)
        {
            using (FormRegistrarProfesor form = new FormRegistrarProfesor())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            using (FormRegistrarCurso form = new FormRegistrarCurso())
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {

                }
            }
        }
    }
}
