using SlnIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Datos
{
    public class abmMedico
    {


        private static DBClinicaIntegradorContext context = new DBClinicaIntegradorContext();

        public static int Insert(Medico medico)
        {
            context.Medicos.Add(medico);
            return context.SaveChanges();
        }

        public static List<Medico> SelectAll()
        {
            return context.Medicos.ToList();
        }

        public static int Delete(Medico medico)
        {


            Medico medicoOrigen = context.Medicos.Find(medico.MedicoId);
            if (medicoOrigen != null)
            {
                context.Medicos.Remove(medicoOrigen);

                return context.SaveChanges();
            }

            return 0;
        }

        public static int Update(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.MedicoId);
            medicoOrigen.Nombre = medico.Nombre;
            medicoOrigen.Apellido = medico.Apellido;
            medicoOrigen.Telefono = medico.Telefono;
            medicoOrigen.Email = medico.Email;
            medicoOrigen.Domicilio = medico.Domicilio;
            medicoOrigen.Especialidad = medico.Especialidad;
            medicoOrigen.Matricula = medico.Matricula;
            return context.SaveChanges();

        }

        public static Medico SelectWhereById(int MedicoId)
        {
            return context.Medicos.Find(MedicoId);

        }
    }
}
