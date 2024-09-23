using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteI
{
    internal class Persona
    {
    
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Ciudad { get; set; }

        
        public Persona(string nombres, string apellidos, DateTime fechaNacimiento, string ciudad)
        {
            Nombres = nombres;
            Apellidos = apellidos;
            FechaNacimiento = fechaNacimiento;
            Ciudad = ciudad;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre completo: {Nombres} {Apellidos}");
            Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }
    }
}

