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
                bool estadoDni = long.TryParse(this.txtDni.Text, out long dni);
                bool estadoNumeroAfiliado = long.TryParse(this.txtNumAfiliado.Text, out long numeroAfiliado);
                string obreSocialSeleccionada = this.cmbObraSocial.SelectedItem.ToString().ToUpper();
                bool estadoObraSocial = Enum.TryParse(obreSocialSeleccionada, out EObrasSocial obraSocial);
                DateTime fechaNacimiento = DateTime.Parse(this.dtpFechaNacimiento.Text);

                //valido que los campos no esten vacios
                if (nombre != string.Empty && apellido != string.Empty && estadoDni && estadoObraSocial)
                {
                    //Instancio la clase paciente y creo el objeto
                    paciente = new Paciente(nombre, apellido, dni, fechaNacimiento, obraSocial,numeroAfiliado);
                    MessageBox.Show($"Registro exitoso");
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    throw new CampoVacioExcepcion("Error, el formulario contiene campos vacios");
                }


            }
            catch(CampoVacioExcepcion ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar registrar al paciente");
            }




        }

        private void FormRegistrarPaciente_Load(object sender, EventArgs e)
        {
            foreach (EObrasSocial item in Enum.GetValues(typeof(EObrasSocial)))
            {
                cmbObraSocial.Items.Add(item); 
            }

            cmbObraSocial.SelectedIndex = 0;
        }
    }
}
