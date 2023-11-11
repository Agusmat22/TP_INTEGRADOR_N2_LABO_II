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


namespace CentroMedicoTP
{
    public partial class FormRegistrarPaciente : Form
    {
        private CentroMedico centroMedico;
        private RestablecerMenuPrincipal restablecerMenu;

        public FormRegistrarPaciente()
        {
            InitializeComponent();
        }

        public FormRegistrarPaciente(string nombreTitulo, CentroMedico centroMedico, RestablecerMenuPrincipal restablecerMenu) : this()
        {
            this.lblTitulo.Text = nombreTitulo;
            this.centroMedico = centroMedico;
            this.restablecerMenu = restablecerMenu;
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
                    Paciente paciente = new Paciente(nombre, apellido, dni, fechaNacimiento, obraSocial, numeroAfiliado);

                    //PREGUNTAR AL PROFE SI ES UNA BUENA PRACTICA
                    paciente.FechaAlta = DateTime.Now;


                    //guardo el paciente en la DB
                    ADOPacientes.Guardar(paciente);

                    //guardo en la lista del centro medico

                    centroMedico.Agregar(paciente);

                    //MUESTRO UN MENSAJE SI SALIO BIEN LA OPERACION
                    this.LimpiarRegistro();
                    MessageBox.Show($"Registro con exito de {paciente.Nombre} {paciente.Apellido}");


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
                MessageBox.Show($"Error al intentar registrar al paciente.\n {ex.Message}");
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.restablecerMenu();
            this.Close();
            
        }

        private void LimpiarRegistro()
        {
            foreach (Control item in grpRegistrar.Controls)
            {
                //reseteo todos los controle
                if(item is TextBox txt)
                {
                    txt.Clear();
                }
                else if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = 0;
                }
                else if(item is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }
            }
        }
    }
}
