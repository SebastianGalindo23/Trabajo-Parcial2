using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    public class Logistica
    {
        public List<Estudiante> listaEstudiantes = new List<Estudiante>();
        public List<Profesor> listaProfesores = new List<Profesor>();
        public List<Curso> listadeCursos = new List<Curso>();
        public List<Nota> Calificaciones = new List<Nota>();
        public List<Usuarios> UsuariosExistentes = new List<Usuarios>();
        public Logistica() 
        {
            listaEstudiantes.Add(new Estudiante("Juan", "Pérez", new DateTime(2000, 1, 15), "Calle 123", 14, "juan@gmail.com", 123456789));
            listaEstudiantes.Add(new Estudiante("Calos", "Landa", new DateTime(2010, 4, 18), "Calle 2", 1, "Carlos@gmail.com", 12389580));
            listaEstudiantes.Add(new Estudiante("Ana", "Monroy", new DateTime(2004, 11, 19), "Calle 6", 17, "Ana@gmail.com", 839554923));

            listadeCursos.Add(new Curso("Matematicas", "1", "Analitico", new DateTime(2023, 1, 15), new DateTime(2023, 11, 25), 5));
            UsuariosExistentes.Add(new Usuarios("Admin", "Original"));
        }

        
    }
}
