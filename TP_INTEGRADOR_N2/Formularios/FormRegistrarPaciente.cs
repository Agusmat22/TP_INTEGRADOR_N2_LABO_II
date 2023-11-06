using Entidades;
using Entidades.Excepciones;
using Entidades.BaseDeDatos;
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

        public FormRegistrarPaciente(string nombreTitulo,string nombreBoton) : this()
        {
            this.lblTitulo.Text = nombreTitulo;
            this.btnRegistrar.Text = nombreBoton;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtengo todos los datos que contienen los elementos del formulario
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                bool estadoDni = int.TryParse(this.txtDni.Text, out int dni);
                bool estadoNumeroAfiliado = long.TryParse(this.txtNumAfiliado.Text, out long numeroAfiliado);
                string obreSocialSeleccionada = this.cmbObraSocial.SelectedItem.ToString().ToUpper();
                bool estadoObraSocial = Enum.TryParse(obreSocialSeleccionada, out EObrasSocial obraSocial);
                DateTime fechaNacimiento = DateTime.Parse(this.dtpFechaNacimiento.Text);

                //valido que los campos no esten vacios
                if (nombre != string.Empty && apellido != string.Empty && estadoDni && estadoObraSocial)
                {
                    //Instancio la clase paciente y creo el objeto, le paso true como si fue atendido para que no se muestre en la admision
                    paciente = new Paciente(nombre, apellido, dni, fechaNacimiento, obraSocial, numeroAfiliado, true);
                    ADOPacientes.Guardar(paciente);
                    MessageBox.Show($"Registro exitoso");
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    throw new CampoVacioExcepcion("Error, el formulario contiene campos vacios");
                }


            }
            catch (CampoVacioExcepcion ex)
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
