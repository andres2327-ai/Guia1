using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApss.Presentacion
{
    class MenuPrincipal
    {
        EstudiantePresentacion estudiantePresentacion = new EstudiantePresentacion();

        public void menu()
        {

            int op;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU PRINCIPAL");

                Console.WriteLine("1. Agregar estudiante");
                Console.WriteLine("2. listado general de estudiante");
                Console.WriteLine("3. buscar estudiante");
                Console.WriteLine("4. actualizar estudiante");
                Console.WriteLine("5. eliminar estudiante");
                Console.WriteLine("9. salir");

                Console.WriteLine("digite la opcion"); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Clear();
                        estudiantePresentacion.capturar();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        estudiantePresentacion.ImprimirResultados();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        estudiantePresentacion.BuscarEstudiante();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        estudiantePresentacion.ActualizarEstudiante();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        estudiantePresentacion.EliminarEstudiante();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("gracias por usar el programa");
                        break;
                }
            } while (op != 9);
        }
    }
}
