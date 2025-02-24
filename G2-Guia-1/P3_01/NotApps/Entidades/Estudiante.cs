using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotApps.Entidades
{
    public class Estudiante : Persona
    {
        //constantes
        const float PORC_NOTA1 = 0.3F;
        const float PORC_NOTA2 = 0.3F;
        const float PORC_NOTA3 = 0.4F;

        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
     

        public float CalcularDefinitiva()
        {
           return Nota1 * PORC_NOTA1 + Nota2 * PORC_NOTA2 + Nota3 * PORC_NOTA3;
        }
        private string EstadoEstudiante()
        {
            if (CalcularDefinitiva() >= 3)
            {
                return ("eress una persona feliz ...");
            }

            return ("siga intentando ...");

        }


    }
}
