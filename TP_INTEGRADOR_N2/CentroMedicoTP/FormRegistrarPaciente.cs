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
using System.Runtime.Serialization;
using Entidades.MetodosDeExtension;

namespace CentroMedicoTP
{
    public partial class FormRegistrarPaciente : Form
    {
        private RestablecerMenuPrincipal restablecerMenu;
        private RadioButton rdbSeleccionado;
        private CentroMedico centroMedico;

        public FormRegistrarPaciente()
        {
            InitializeComponent();
        }

        public FormRegistrarPaciente(CentroMedico centroMedico, RestablecerMenuPrincipal restablecerMenu) : this()
        {
            this.restablecerMenu = restablecerMenu;
            this.centroMedico = centroMedico;
        }

        private void FormRegistrarPaciente_Load(object sender, EventArgs e)
        {

            //agrego manejador al evento de rdb para guardarme que button fue seleccionado
            this.rdbMedico.CheckedChanged += this.CheckearCambioRadioButton;
            this.rdbPaciente.CheckedChanged += this.CheckearCambioRadioButton;

            //selecciono una obra social por defecto
            this.rdbPaciente.Checked = true; //lo selecciono por defecto

        }

        /// <summary>
        /// Registra pacientes y medicos segun el radioButton seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtNumero.PlaceholderText != string.Empty)
                {
                    this.txtNumero.PlaceholderText = string.Empty;
                    this.txtNumero.BackColor = Color.White;
                }


                //Obtengo todos los datos que contienen los elementos del formulario
                string nombre = this.txtNombre.Text;
                string apellido = this.txtApellido.Text;
                bool estadoDni = int.TryParse(this.txtDni.Text, out int dni);
                DateTime fechaNacimiento = DateTime.Parse(this.dtpFechaNacimiento.Text);
                bool estadoNumero = long.TryParse(this.txtNumero.Text, out long numero);
                string cmbTipo = this.cmbTipo.SelectedItem.ToString().ToUpper();



                //valido que los campos no esten vacios
                if (nombre != string.Empty && apellido != string.Empty && estadoDni)
                {
                    //Instancio la clase paciente y creo el objeto, le paso true como si fue atendido para que no se muestre en la admision
                    if (this.rdbSeleccionado == this.rdbPaciente && !this.centroMedico.ValidarNumeroAfiliado(numero))
                    {
                        //casteo el item seleccionado a la Obra Social
                        Enum.TryParse(cmbTipo, out EObrasSocial obraSocial);
                        Paciente paciente = new Paciente(nombre, apellido, dni, fechaNacimiento, obraSocial, numero, DateTime.Now);
                        ADOPacientes.Guardar(paciente);

                        MessageBox.Show($"Registrado correctamente\nPaciente: {paciente}");

                    }
                    else if (this.rdbSeleccionado == this.rdbMedico && !this.centroMedico.ValidarMatricula(numero))
                    {
                        Enum.TryParse(cmbTipo, out EEspecialidad especialidad);
                        Medico medico = new Medico(nombre, apellido, dni, numero, fechaNacimiento, especialidad, DateTime.Now);
                        ADOMedicos.Guardar(medico);

                        //al medico si lo agrego en tiempo de ejecucion ya que no lo actualizo por DB
                        this.centroMedico.Agregar(medico);

                        MessageBox.Show($"Registrado correctamente\nMedico: {medico}");

                    }
                    else
                    {
                        this.txtNumero.PlaceholderText = "Error, numero en uso";
                        this.txtNumero.BackColor = Color.Red;
                    }


                    this.LimpiarRegistro();


                }
                else
                {
                    throw new CampoVacioException("Error, complete todos los campos con los datos solicitados");
                }


            }
            catch (CampoVacioException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FalloGuardarRegistroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }



        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.restablecerMenu();
            this.Close();

        }

        /// <summary>
        /// Reestablece los controles
        /// </summary>
        private void LimpiarRegistro()
        {
            foreach (Control item in grpRegistrar.Controls)
            {
                //reseteo todos los controle
                if (item is TextBox txt)
                {
                    txt.Clear();
                }
                else if (item is ComboBox cmb)
                {
                    cmb.SelectedIndex = 0;
                }
                
            }
        }

        /// <summary>
        /// Indicara que radioButton esta seleccionado y actualizara los controles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="events"></param>
        private void CheckearCambioRadioButton(object sender, EventArgs events)
        {
            RadioButton rdb = (RadioButton)sender;

            if (rdb.Checked)
            {
                this.rdbSeleccionado = rdb; //guardo el radioButton seleccionado
                this.cmbTipo.Items.Clear(); //borro todos los items del COMBOBOX
                if (rdb == this.rdbPaciente)
                {
                    this.lblComboBox.Text = "Obra social: ";
                    this.lblNumero.Text = "Numero Afiliado: ";

                    //cargo las obra sociales al COMBO BOX
                    foreach (EObrasSocial item in Enum.GetValues(typeof(EObrasSocial)))
                    {
                        cmbTipo.Items.Add(item);
                    }

                    //pacientes recien nacidos pueden registrarse
                    this.dtpFechaNacimiento.MaxDate = DateTime.Now;


                }
                else
                {
                    //cargo las especialidad medicas en COMBO BOX
                    foreach (EEspecialidad item in Enum.GetValues(typeof(EEspecialidad)))
                    {
                        cmbTipo.Items.Add(item);
                    }

                    this.lblComboBox.Text = "Especialidad: ";
                    this.lblNumero.Text = "Numero Matricula: ";

                    //medicos con 21 en adelante pueden registrarse
                    this.dtpFechaNacimiento.MaxDate = DateTime.Now.AddYears(-21);


                }

                this.cmbTipo.SelectedIndex = 0;
                this.dtpFechaNacimiento.Value = this.dtpFechaNacimiento.MaxDate;

            }
        }
    }
}
