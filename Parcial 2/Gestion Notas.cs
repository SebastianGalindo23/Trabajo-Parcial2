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
            EstudianteEnCursos = logistica.listadeCursos.Select(estudiante => estudiante.Nombre).ToList() ;
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
            SeleccionarAlumnos.Items.AddRange(EstudianteEnCursos.ToArray());
        }
    }
}
