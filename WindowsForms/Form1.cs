using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlnIntegrador.Entidades;
using SlnIntegrador.Datos;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Matricula = txtMatricula.Text,
                Especialidad = txtEspecialidad.Text


            };

            int filasAfectadas = abmMedico.Insert(medico);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("medico insertado");
                MostrarMedico();
            }








        }
        //
        private void MostrarMedico()
        {
            GridMedico.DataSource = abmMedico.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarMedico();
            int countMedicoClinico = 0;

            foreach (Medico medico in abmMedico2.ListarTodo())
            {
                if (medico.Especialidad.Equals("Medico Clinico"))
                {
                    medicoClinico.Items.Add(medico.Nombre);
                    countMedicoClinico++;

                }

            }
            medicoClinico.Items.Add($"Cantidad medicos clinicos: {countMedicoClinico}");

            foreach (Habitacion habitacion in abmHabitacion.Listar())
            {
                string ocupado = "";

                if (habitacion.Estado)
                {
                    ocupado = "Ocupado";
                }
                else
                {
                    ocupado = "Libre";
                }

                listNumeroHabitacion.Items.Add($"Habitacion: {habitacion.Numero},  {ocupado}");



            }
        } ///

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                MedicoId = Convert.ToInt32(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Domicilio = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Matricula = txtMatricula.Text,
                Especialidad = txtEspecialidad.Text





            };

            int filasAfectadas = abmMedico.Update(medico);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Modificacion ok");
                MostrarMedico();

            }
        }




        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico()
            {
                MedicoId = Convert.ToInt32(txtId.Text),


            };
            int filasAfectadas = abmMedico.Delete(medico);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarMedico();

            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            int MedicoId = Convert.ToInt32(txtId.Text);

            Medico medico = abmMedico.SelectWhereById(MedicoId);
            MessageBox.Show($"Nombre Paciente:  {medico.Nombre} " +
                $"\n Apellido Paciente: {medico.Apellido}");

        }
    }
}
