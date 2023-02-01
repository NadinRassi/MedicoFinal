using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Entidades
{
    public class Enfermero:Persona
    {
        public int EnfermeroId { get; set; }
        public int Cuil { get; set; }
    }
}
