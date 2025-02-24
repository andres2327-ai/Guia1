using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1
{
    class Ejercicio_2
    {
        public const string femenino = "F";
        public const string masculino = "M";

        public int edad;
        public string nombre;
        public string sexo;
        

        public void CapturarDatos()
        {
            Console.WriteLine("Captura de Datos");
            Console.WriteLine("Digite su nombre : "); nombre = Console.ReadLine();
            Console.WriteLine("Digite su edad"); edad = int.Parse(Console.ReadLine());
            Console.WriteLine("digite su sexo m/f : "); sexo = Console.ReadLine().Trim().ToUpper();

            /*
            while(sexo != 'F' && != 'M')
            {
                Console.Clear();
                Console.WriteLine("Error tiene que ser entre f->femenino o m-> masculino");
                sexo = Console.ReadLine().Trim().ToUpper();
            }
            */
        }

        private float CalcularPulsaciones()
        {
             float pulsacionesF;
             float pulsacionesM;
            if(sexo == masculino)
            {
                pulsacionesM = (220 - edad) / 10;
                    return pulsacionesM;
            }
            else
            {
               
                 pulsacionesF = (210 - edad) / 10;
                 return pulsacionesF;
                
            }
        }

        public void Resultados()
        {
            Console.Clear();
            Console.WriteLine($"{nombre} sus pulsaciones por cada 10 segundos son :");
            Console.WriteLine(CalcularPulsaciones());
            Console.ReadKey();
        }
    }
}
