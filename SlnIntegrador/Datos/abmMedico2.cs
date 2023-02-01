using SlnIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Datos
{
    public class abmMedico2
    {
        public static List<Medico> listaMedico = new List<Medico>();

        public static List<Medico> ListarTodo()
        {
            listaMedico.Add(new Medico() { MedicoId = 1, Nombre = "Rocio", Apellido = "Ianniello", Domicilio = "Av.Siempreviva 123", Telefono = "42433354", Email = "nickorn96@gmail.com", Especialidad = "Medico Clinico", Matricula = "C208734" });
            listaMedico.Add(new Medico() { MedicoId = 2, Nombre = "Nicolas", Apellido = "Ramos", Domicilio = "Calle falsa 123", Telefono = "42123354", Email = "pepa@gmail.com", Especialidad = "Pediatra", Matricula = "C203344" });
            listaMedico.Add(new Medico() { MedicoId = 3, Nombre = "Agustina", Apellido = "Canale", Domicilio = "Corrientes 2000", Telefono = "42343354", Email = "pepito@gmail.com", Especialidad = "Medico Clinico", Matricula = "C204534" });
            listaMedico.Add(new Medico() { MedicoId = 4, Nombre = "Martin", Apellido = "Quiroga", Domicilio = "Cordoba 2323", Telefono = "4246354", Email = "pipon@gmail.com", Especialidad = "Traumatologo", Matricula = "C2057634" });
            listaMedico.Add(new Medico() { MedicoId = 5, Nombre = "Samuel", Apellido = "Rivera", Domicilio = "Melo 935", Telefono = "42433454", Email = "pepon@gmail.com", Especialidad = "TODAS", Matricula = "C2067834" });
            //TODO…
            return listaMedico;
        }

        public static List<Medico> Listar(string especialidad)
        {

            //TODO…
            return null;

        }
        public static int Insertar(Medico medico)
        {
            //TODO…
            return 0;
        }
        public static int Eliminar(int id)
        {
            //TODO…
            return 0;
        }

        public static Medico TraerUno(int id)
        {
            //TODO…
            return null;
        }
    }
}

