using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    public class MenuPrincipal
    {
        public void Menu()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(8, 6); Console.WriteLine("M E N U   P R I N C I P A L");

                Console.SetCursorPosition(10, 8); Console.Write("1. Ejercico Calculo de Promedio");
                Console.SetCursorPosition(10, 10); Console.Write("2. Ejercicoo 2");
                Console.SetCursorPosition(10, 18); Console.Write("5. salir");
                Console.SetCursorPosition(10, 20); Console.Write("Seleccione un opcion: ");
                Console.SetCursorPosition(33, 20); op=int.Parse(Console.ReadLine());

                switch (op)
                {
                   case 1:
                        Console.Clear();
                        Ejercicio_1 ejercicio_1 = new Ejercicio_1();

                        ejercicio_1.CapturarNotas();
                        ejercicio_1.ImprimirResultados();
                        break;
                   case 2:
                        Console.Clear();
                        Ejercicio_2 ejercicio_2 = new Ejercicio_2();
                        ejercicio_2.CapturarDatos();
                        ejercicio_2.Resultados();
                        break;

                    case 3:
                        Console.Clear();

                        Ejercicio_3 ejercicio_3 = new Ejercicio_3();
                        ejercicio_3.menuEje3();


                        break;
                   
                    case 4:
                        Console.Clear();
                        Console.WriteLine("gracias por usar productos johnp ...");
                        Console.ReadKey();
                        break;

                }
              

            } while (op!= 4);
            
        }
    }
}
