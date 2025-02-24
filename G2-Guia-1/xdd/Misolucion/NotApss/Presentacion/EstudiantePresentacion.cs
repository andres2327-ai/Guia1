using NotApss.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApss.Presentacion
{
    public class EstudiantePresentacion
    {
        Logica.ServicioEstudiante servicioEstudiante = new Logica.ServicioEstudiante();

        public void capturar()
        {
            Estudiante estudiante = new Estudiante();
            Console.WriteLine("Sistema de captura de notas");

            Console.Write("id: ");
            estudiante.Id = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            estudiante.Numb = Console.ReadLine();

            Console.Write("sexo :");
            estudiante.Sexo = Console.ReadLine();



            Console.WriteLine("Digite la nota 1: ");
            estudiante.Nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2: ");
            estudiante.Nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 3: ");
            estudiante.Nota3 = float.Parse(Console.ReadLine());

            Console.Write(servicioEstudiante.AgregarEstudiante(estudiante));
        }

        public void ImprimirResultados()
        {
            Console.Clear();

            Console.WriteLine("sistemas de procesamiento de notas");
            int i = 0;

            foreach (var item in servicioEstudiante.consultarTodos())
            {
                Console.WriteLine($"nombre : {item.Numb}");
                Console.WriteLine($"primer parcial : {item.Nota1}");
                Console.WriteLine($"segundo parcial: {item.Nota2}");
                Console.WriteLine($"tercer parcial: {item.Nota3}");

                Console.WriteLine($"definitiva : {item.CalcularDefinitiva()}");

                Console.WriteLine("-------------------------------------------------");

                Console.WriteLine("");
            }
        }

        public void BuscarEstudiante()
        {
            Console.Write("Ingrese el ID del estudiante a buscar: ");
            int id = int.Parse(Console.ReadLine());

            var estudiante = servicioEstudiante.BuscarEstudiante(id);
            if (estudiante == null)
            {
                Console.WriteLine("Estudiante no encontrado.");
                return;
            }

            Console.WriteLine("\n--- Datos del Estudiante ---");
            Console.WriteLine($"Nombre: {estudiante.Numb}");
            Console.WriteLine($"Sexo: {estudiante.Sexo}");
            Console.WriteLine($"Nota 1: {estudiante.Nota1}");
            Console.WriteLine($"Nota 2: {estudiante.Nota2}");
            Console.WriteLine($"Nota 3: {estudiante.Nota3}");
            Console.WriteLine($"Definitiva: {estudiante.CalcularDefinitiva():F2}");
            Console.WriteLine($"Estado: {estudiante.EstadoEstudiante()}");
        }

        public void ActualizarEstudiante()
        {
            Console.Write("Ingrese el ID del estudiante a actualizar: ");
            int id = int.Parse(Console.ReadLine());

            var estudianteExistente = servicioEstudiante.BuscarEstudiante(id);
            if (estudianteExistente == null)
            {
                Console.WriteLine("Estudiante no encontrado.");
                return;
            }

            Console.WriteLine("\n--- Actualizar Estudiante ---");
            Console.Write("Nuevo nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Nuevo sexo: ");
            string sexo = Console.ReadLine();

            Console.Write("Nueva nota 1: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Nueva nota 2: ");
            float nota2 = float.Parse(Console.ReadLine());

            Console.Write("Nueva nota 3: ");
            float nota3 = float.Parse(Console.ReadLine());

            Estudiante estudianteActualizado = new Estudiante
            {
                Id = id,
                Numb = nombre,
                Sexo = sexo,
                Nota1 = nota1,
                Nota2 = nota2,
                Nota3 = nota3
            };

            Console.WriteLine(servicioEstudiante.ActualizarEstudiante(estudianteActualizado));
        }

        public void EliminarEstudiante()
        {
            Console.Write("Ingrese el ID del estudiante a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine(servicioEstudiante.EliminarEstudiante(id));
        }


    }

    
}
