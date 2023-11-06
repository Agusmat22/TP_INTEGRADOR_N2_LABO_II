using Entidades;
using Entidades.BaseDeDatos;
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



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtengo todos los datos que contienen los elementos del formulario
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                bool estadoValor = int.TryParse(this.txtDni.Text, out int dni);
                bool estadoNumeroMatriculo = long.TryParse(this.txtMatricula.Text, out long numeroMatricula);
                DateTime fechaNacimiento = DateTime.Parse(this.dtpFechaNacimiento.Text);
                Enum.TryParse(this.cmbEspecialidad.SelectedItem.ToString().ToUpper(), out EEspecialidad especialidad);

                if (nombre != string.Empty && apellido != string.Empty && estadoValor && estadoNumeroMatriculo)
                {
                    //Instancio la clase paciente y creo el objeto
                    medico = new Medico(nombre, apellido, dni, numeroMatricula, fechaNacimiento, especialidad);
                    ADOMedicos.Guardar(medico);
                    MessageBox.Show($"Registro exitoso");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new CampoVacioExcepcion("Error, el formulario contiene campos vacios");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FormRegistrarMedico_Load(object sender, EventArgs e)
        {
            foreach (EEspecialidad item in Enum.GetValues(typeof(EEspecialidad)))
            {
                this.cmbEspecialidad.Items.Add(item);
            }

            this.cmbEspecialidad.SelectedIndex = 0;
        }
    }
}
