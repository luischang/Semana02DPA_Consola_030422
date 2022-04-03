using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02DPA_Consola
{
    public class Persona
    {
        public string dni { get; set; }
        public string nombreCompleto { get; set; }
        public int edad { get; set; }

        public Persona()
        {         
        }

        public Persona(string dni, string nombreCompleto, int edad)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.edad = edad;
        }
    }
}
