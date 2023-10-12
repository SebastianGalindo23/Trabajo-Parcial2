using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    public class Usuarios
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Usuarios(string usuario, string contraseña) 
        {
            this.Usuario = usuario;
            this.Contraseña = contraseña;
        }
    }
}
