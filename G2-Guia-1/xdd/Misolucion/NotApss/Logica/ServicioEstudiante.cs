using NotApss.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NotApss.Logica
{
    public class ServicioEstudiante
    {
        
        List<Estudiante> listaEstudiantes;

        public ServicioEstudiante()
        {
            listaEstudiantes = new List<Estudiante>();
        }

        public string AgregarEstudiante(Estudiante estudiante)
        {

            if (ExisteEstudiante(estudiante))
            {
                return "el estudiante ya esta registrado";
            }
            listaEstudiantes.Add(estudiante);
            return "Datos agregados";
        }

        private bool ExisteEstudiante(Estudiante estudiante)
        {
            foreach (var item in listaEstudiantes)
            {
                if (item.Id == estudiante.Id)
                {
                    return true;
                }

                
            }
            return false;
        }

        public List<Estudiante> consultarTodos()
        {
            return listaEstudiantes;
        }

        public Estudiante BuscarEstudiante(int id)
        {
            foreach (var item in listaEstudiantes)
            {
                if (item.Id == id )
                {
                    return item;
                }
            }
            return null;
        }
        
        public string ActualizarEstudiante(Estudiante EstudianteActualizado)
        {
            foreach (var item in listaEstudiantes)
            {
                if (item.Id == EstudianteActualizado.Id )
                {
                    item.Numb = EstudianteActualizado.Numb;
                    item.Sexo = EstudianteActualizado.Sexo;
                    item.Nota1 = EstudianteActualizado.Nota1;
                    item.Nota2 = EstudianteActualizado.Nota2;
                    item.Nota3 = EstudianteActualizado.Nota3;
                    return "actualizado correctamente";
                }
            }
            return "estudiante no encontrado";
        }
        
        public string EliminarEstudiante(int id)
        {
            foreach (var item in listaEstudiantes)
            {
                if (item.Id == id)
                {
                    listaEstudiantes.Remove(item);
                    return "eliminado correctamente";
                }
            }

            return "no se encuentra el estudiante";
        }
    }
}
