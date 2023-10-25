using Entidades;
using Entidades.Excepciones;
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
    public partial class FormRegistrarMedico : Form
    {
        private Medico medico;

        public Medico MedicoRegistrado
        { get { return this.medico; } }

        public FormRegistrarMedico()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtengo todos los datos que contienen los elementos del formulario
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                bool estadoValor = long.TryParse(this.txtDni.Text, out long dni);
                bool estadoNumeroMatriculo = long.TryParse(this.txtMatricula.Text, out long numeroMatricula);
                DateTime fechaNacimiento = DateTime.Parse(this.dtpFechaNacimiento.Text);
                Enum.TryParse(this.cmbEspecialidad.SelectedItem.ToString().ToUpper(), out EEspecialidad especialidad);

                if (nombre != string.Empty && apellido != string.Empty && estadoValor && estadoNumeroMatriculo)
                {
                    //Instancio la clase paciente y creo el objeto
                    medico = new Medico(nombre, apellido, dni, numeroMatricula, fechaNacimiento, especialidad);
                    MessageBox.Show($"Registro exitoso");
                }
                else
                {
                    throw new CampoVacioExcepcion("Error, el formulario contiene campos vacios");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar registrar al medico");
            }
        }
    }
}
