using NotApps.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.GUI
{
    public class EstudiantesGUI
    {
        Logica.ServicioEstudiante ServicioEstudiante = new Logica.ServicioEstudiante();
        public void CapturarNotas()
        {
            Estudiante estudiante = new Estudiante();
            Console.Clear();
            Console.WriteLine("SISTEMAS DE PROCESAMIENTO DE NOTAS V:0.1");

            Console.Write("ID: ");
            estudiante.Id =int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            estudiante.Nombre = Console.ReadLine();

            Console.Write("Sexo: ");
            estudiante.Sexo = Console.ReadLine();

            Console.Write("NOTA 1: ");
            estudiante.Nota1 = float.Parse(Console.ReadLine());

            Console.Write("NOTA 2: ");
            estudiante.Nota2 = float.Parse(Console.ReadLine());

            Console.Write("NOTA 3: ");
            estudiante.Nota3 = float.Parse(Console.ReadLine());

            Console.Write(ServicioEstudiante.AgregarEstudiante(estudiante));
        }
        public void ImprimirResultados()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 5); Console.Write("SISTEMAS DE PROCESAMIENTO DE NOTAS V:0.1");
            int i=0;
            foreach (var item in ServicioEstudiante.ConsultarTodos())
            {
                Console.SetCursorPosition(8, 8); Console.Write("Nombre");
                Console.SetCursorPosition(15, 8); Console.Write("Primer Parcial");
                Console.SetCursorPosition(30, 8); Console.Write("Segundo Parcial");
                Console.SetCursorPosition(48, 8); Console.Write("Examen Final");
                Console.SetCursorPosition(65, 8); Console.Write("Definitiva");
                Console.SetCursorPosition(8, 9); Console.Write("-----------------------------------------------------------------");
                Console.SetCursorPosition(8, 10+i); Console.Write(item.Nombre);
                Console.SetCursorPosition(18, 10+i); Console.Write(item.Nota1);
                Console.SetCursorPosition(39, 10 + i); Console.Write(item.Nota2);
                Console.SetCursorPosition(54, 10 + i); Console.Write(item.Nota3);
                Console.SetCursorPosition(70, 10 + i); Console.Write(item.CalcularDefinitiva());
                
                i++;
                //Console.SetCursorPosition(28, 12); Console.Write(EstadoEstudiante());

            }
            Console.SetCursorPosition(8, 11 + i); Console.Write("-----------------------------------------------------------------");
        }


    }
}
