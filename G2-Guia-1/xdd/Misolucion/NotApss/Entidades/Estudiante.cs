using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApss.Entidades
{
    public class Estudiante : Persona
    {
        const float PORCENTAJE_NOTA1 = 0.3F;
        const float PORCENTAJE_NOTA2 = 0.3F;
        const float PORCENTAJE_NOTA3 = 0.4F;
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }

        public float CalcularDefinitiva()
        {
            return Nota1 * PORCENTAJE_NOTA1 + Nota2 * PORCENTAJE_NOTA2 + Nota3 * PORCENTAJE_NOTA3;
        }

        public string EstadoEstudiante()
        {
            if (CalcularDefinitiva() >=3)
            {
                return "ganaste, felicidades";
            }

            return "perdiste, repite";
        }
    }
}
