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
    public partial class FormRegistrarCurso : Form
    {
        public FormRegistrarCurso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {

            string nombre = txtNombreCurso.Text;
            string codigo = txtCodigo.Text;
            string descripcion = txtDescripcion.Text;
            DateTime fechaInicio = DateTime.Parse(txtFechaInicio.Text);
            DateTime fechaFin = DateTime.Parse(txtFechaFin.Text);
            int capacidadMaxima = int.Parse(txtCapacidadMax.Text);


            Curso nuevoCurso = new Curso(nombre, codigo, descripcion, fechaInicio, fechaFin, capacidadMaxima);


            GestorCursos gestorCursos = new GestorCursos();
            gestorCursos.CursosList.Add(nuevoCurso);


            DialogResult = DialogResult.OK;


            MessageBox.Show("Curso registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
    

