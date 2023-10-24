using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormRegistrarPaciente : Form
    {
        private Paciente paciente;

        public Paciente PacienteRegistrado
        { get { return this.paciente; } }

        public FormRegistrarPaciente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtengo todos los datos que contienen los elementos del formulario
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                long.TryParse(this.txtDni.Text, out long dni);
                string obreSocialSeleccionada = this.cmbObraSocial.SelectedItem.ToString().ToUpper();
                Enum.TryParse(obreSocialSeleccionada, out EObrasSociales obraSocial);
                DateTime fechaNacimiento = DateTime.Parse(this.dtpFechaNacimiento.Text);

                //Instancio la clase paciente y creo el objeto
                paciente = new Paciente(nombre, apellido, dni, fechaNacimiento, obraSocial);
                MessageBox.Show($"Registro exitoso");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar registrar al paciente");
            }




        }

        private void FormRegistrarPaciente_Load(object sender, EventArgs e)
        {
            foreach (EEspecialidad item in Enum.GetValues(typeof(EEspecialidad)))
            {
                cmbObraSocial.Items.Add(item); 
            }

            cmbObraSocial.SelectedIndex = 0;
        }
    }
}
