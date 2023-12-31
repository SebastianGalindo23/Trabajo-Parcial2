﻿using System;
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
        List<string> nombresProfesores;
        Logistica logistica = new Logistica();
        public FormRegistrarCurso(Logistica logistica)
        {
            InitializeComponent();
            this.logistica = logistica;
            nombresProfesores = logistica.listaProfesores.Select(profesor => profesor.Nombre).ToList();
            ConfigureDomainUpDown();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCurso_Click(object sender, EventArgs e)
        {
            string profesor = SeleccionarProfesores.Text;
            if (!string.IsNullOrEmpty(profesor)){

                Profesor Profesorencontrado = logistica.listaProfesores.Find(profe => profe.Nombre == profesor);
                if (Profesorencontrado != null)
                {
                    string nombre = txtNombreCurso.Text;
                    string codigo = txtCodigo.Text;
                    string descripcion = txtDescripcion.Text;
                    DateTime fechaInicio = txtFechaInicio.Value;
                    DateTime fechaFin = txtFechaFin.Value;
                    int capacidadMaxima = int.Parse(txtCapacidadMax.Text);


                    logistica.listadeCursos.Add(new Curso(nombre, codigo, descripcion, fechaInicio, fechaFin, capacidadMaxima, Profesorencontrado));

                    DialogResult = DialogResult.OK;


                    MessageBox.Show("Curso registrado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
        }

        private void limpiar()
        {
            txtCapacidadMax.Clear();
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtNombreCurso.Clear();
        }

        private void FormRegistrarCurso_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionCursos gestioncurso = new GestionCursos(logistica);
            this.Hide();
            gestioncurso.Show();
        }

        private void txtCapacidadMax_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCapacidadMax.Text) && !int.TryParse(txtCapacidadMax.Text, out _))
            {
                MessageBox.Show("Solo se permiten números enteros en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCapacidadMax.Text = string.Empty;
            }
        }

        private void SeleccionarProfesores_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        private void ConfigureDomainUpDown()
        {
            SeleccionarProfesores.Items.AddRange(nombresProfesores.ToArray());
            
        }
    }
}
    

