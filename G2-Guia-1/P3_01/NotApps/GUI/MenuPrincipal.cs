using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.GUI
{
    class MenuPrincipal
    {
        //Logica.ServicioEstudiante ServicioEstudiante = new Logica.ServicioEstudiante();
        EstudiantesGUI estudiantesGUI = new EstudiantesGUI();
        public void Menu()
        {
            
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5); Console.Write(" M E N U   P R I N C I P A L");

                Console.SetCursorPosition(8, 8); Console.Write("1. Agregar Estudiante ");
                Console.SetCursorPosition(8, 10); Console.Write("2. Listado General de Estudiantes");
                Console.SetCursorPosition(8, 12); Console.Write("3. Buscar Estudiante");
                Console.SetCursorPosition(8, 14); Console.Write("4. Actualizar Estudiante");
                Console.SetCursorPosition(8, 16); Console.Write("5. Eliminar Estudiante");
                Console.SetCursorPosition(8, 20); Console.Write("9. salir");
                Console.SetCursorPosition(8, 22); Console.Write("Seleccione una opcion: ");

                Console.SetCursorPosition(31, 22); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        
                        estudiantesGUI.CapturarNotas();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        estudiantesGUI.ImprimirResultados();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("aqui va el code del ejecicio 3");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("Gracias por usar productos johnp");
                        Console.ReadKey();
                        break;

                }

            } while (op != 9);

        }

    }
}
