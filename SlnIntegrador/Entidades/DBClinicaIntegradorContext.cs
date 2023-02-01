using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Entidades
{
    public class DBClinicaIntegradorContext:DbContext
    {
        public DBClinicaIntegradorContext() : base("KeyDB") { }

        public DbSet<Medico> Medicos { get; set; }
    }
}
