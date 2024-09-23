using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorteI
{
    internal class Registro
    {

        private Persona[] personas;
        private int contador;


        public Registro()
        {
            personas = new Persona[30];
            contador = 0;
        }


        public void AgregarPersona(Persona persona)
        {
            if (contador < 30)
            {
                personas[contador] = persona;
                contador++;
                Console.WriteLine("Persona agregada con éxito.");
            }
            else
            {
                Console.WriteLine("No se pueden agregar más personas. El registro está lleno.");
            }
        }


        public void MostrarPersonas()
        {
            if (contador == 0)
            {
                Console.WriteLine("No hay personas en el registro.");
            }
            else
            {
                for (int i = 0; i < contador; i++)
                {
                    personas[i].MostrarInformacion();
                    Console.WriteLine("----------------------------");
                }
            }
        }
    }
}
        
    