using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteI
{
    internal class Operacion
    {
       
        public int CalcularEdad(Persona persona)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - persona.FechaNacimiento.Year;

           
            if (persona.FechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        
        public bool EsMayorDeEdad(Persona persona)
        {
            int edad = CalcularEdad(persona);
            return edad >= 18;
        }

        
        public void MostrarMayorOMenor(Persona persona)
        {
            int edad = CalcularEdad(persona);
            if (EsMayorDeEdad(persona))
            {
                Console.WriteLine($"{persona.Nombres} {persona.Apellidos} tiene {edad} años y es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"{persona.Nombres} {persona.Apellidos} tiene {edad} años y es menor de edad.");
            }
        }
    }
}

