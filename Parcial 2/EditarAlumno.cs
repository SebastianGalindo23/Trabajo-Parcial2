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
        Logistica logistica = new Logistica();
        public EditarAlumno(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
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
    }
}
