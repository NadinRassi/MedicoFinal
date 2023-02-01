using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Entidades
{
    public class Medico:Persona
    {
        public int MedicoId { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
    }
}
