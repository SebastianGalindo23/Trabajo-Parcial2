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
    public partial class Form1 : Form
    {
        Logistica logistica = new Logistica();
 
        public Form1()
        {
            InitializeComponent();
    
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuarioIngresado = Usuario.Text;
            string contraseñaIngresada = Contraseña.Text;

            foreach (Usuarios usuario in logistica.UsuariosExistentes)
            {
                if (usuario.Usuario == nombreUsuarioIngresado && usuario.Contraseña == contraseñaIngresada)
                {
    
                    Inicio inicio = new Inicio(logistica);
                    this.Hide();
                    inicio.Show();
                    return;
                }
            }

            MessageBox.Show("Nombre de usuario o contraseña incorrectos.");

        }
    }
}
