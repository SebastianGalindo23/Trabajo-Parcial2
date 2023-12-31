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
                string nombre = Nombretext.Text;
                string apellido = Apellidotext.Text;
                DateTime fechanacimiento = Fechanacimiento.Value;
                string direccion= Direcciontext.Text;
                string correo = Correotext.Text;
                logistica.listaEstudiantes.Add(new Estudiante(nombre, apellido, fechanacimiento, direccion, id, correo, numero));
            }
            else
            {
                MessageBox.Show("Asegúrate de que los campos Id y Número sean números enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Gestion_Alumnos gestionaalumnos = new Gestion_Alumnos(logistica);
            this.Hide();
            gestionaalumnos.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gestion_Alumnos gestionalumnos = new Gestion_Alumnos(logistica);
            this.Hide();
            gestionalumnos.Show();
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Fechanacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    
}
