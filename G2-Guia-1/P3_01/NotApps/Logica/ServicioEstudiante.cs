using NotApps.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.Logica
{
    public class ServicioEstudiante
    {
        List<Estudiante> listaEstudiantes;
        public ServicioEstudiante()
        {
            listaEstudiantes = new List<Estudiante>();
        }
        public string AgregarEstudiante( Estudiante estudiante)
        {
            if (ExisteEstudiante(estudiante))
            {
                return "El estudiante ya esta registrado";
            }
            listaEstudiantes.Add(estudiante);
            return $"datos almacenados del estudiante {estudiante.Nombre} ";
        }

        private bool ExisteEstudiante(Estudiante estudiante)
        {
            foreach (var item in listaEstudiantes)
            {
                if (item.Id==estudiante.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Estudiante> ConsultarTodos()
        {
            return listaEstudiantes;
        }
    }
}
