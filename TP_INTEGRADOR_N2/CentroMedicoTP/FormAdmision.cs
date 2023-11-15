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

namespace CentroMedicoTP
{

    public partial class FormAdmision : Form
    {
        private CentroMedico centroMedico;
        private RestablecerMenuPrincipal restablecer;
        private Paciente pacienteEncotrado;
        private ActualizarListboxGenerico actualizarListBox;

        public FormAdmision(CentroMedico centroMedico, RestablecerMenuPrincipal restablecer, ActualizarListboxGenerico actualizarListBox)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.restablecer = restablecer;
            this.actualizarListBox = actualizarListBox;
        }

        private void FormAdmision_Load(object sender, EventArgs e)
        {
            foreach (EEspecialidad item in Enum.GetValues(typeof(EEspecialidad)))
            {
                this.cmbTipoGuardia.Items.Add(item);
            }

            this.RestablecerGroupBox();

            //ejecuto en un subproceso la actualizacion de la lista
            Task tarea = Task.Run(() => this.actualizarListBox(this.lstbPacientesEnEspera, paciente => paciente.EnEspera == true));
        }

        private void btnDesbloquear_Click(object sender, EventArgs e)
        {

            if (this.grpCargarPaciente.Enabled == false)
            {
                //habilito el grp para que puedan ingresar el paciente
                this.grpCargarPaciente.Enabled = true;
                this.btnDesbloquear.ImageIndex = 1;
            }
            else
            {
                //deshabilito el grp
                this.RestablecerGroupBox();
            }


        }

        /// <summary>
        /// Actualiza la listBox y limpia el groupBox
        /// </summary>
        private void ActualizarElementos()
        {
            //this.grpCargarPaciente.Enabled = false;
            this.lstbPacientesEnEspera.DataSource = null;
            //le paso una funcion lambda para que me traiga solo los pacientes que no estan atendidos
            this.lstbPacientesEnEspera.DataSource = (centroMedico.Pacientes).Where(paciente => paciente.EnEspera == true).ToList();

            this.RestablecerGroupBox();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.restablecer();
            this.Close();
        }




        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string tipoBusqueda = string.Empty;
            int numero = 0;

            foreach (Control item in grbBuscarPaciente.Controls)
            {
                //valido que este vacio ya que si lo encontro no quiero que ingrese de nuevo
                if (item is RadioButton rdb && tipoBusqueda == string.Empty)
                {
                    if (rdb == this.rdbNumAfiliado && rdb.Checked)
                    {
                        tipoBusqueda = "numero";
                    }
                    else if (rdb == this.rdbDni && rdb.Checked)
                    {
                        tipoBusqueda = "dni";

                    }
                    /*else
                    {
                        this.txtAfiliadoEncontrado.Text = "Error, debe seleccionar el tipo de busqueda";
                        this.txtAfiliadoEncontrado.BackColor = Color.Red;
                        break;
                    }*/
                }
                else if (item is TextBox txt && txt == this.txtDatosBusqueda)
                {
                    //
                    if (!int.TryParse(txt.Text, out numero))
                    {
                        this.txtAfiliadoEncontrado.Text = "Error, debe ingresar un numero";
                        this.txtAfiliadoEncontrado.BackColor = Color.Red;
                        numero = -1;
                        break;
                    }

                }

            }

            if (numero != -1)
            {
                //lo hago aca para ahorrarme un else
                string mensajeDeBusqueda = "El paciente no se encontro";
                Color colorFondoText = Color.Red;


                if (tipoBusqueda == "dni")
                {
                    //Le paso una funcion lambda
                    pacienteEncotrado = centroMedico.ObtenerPaciente(paciente => paciente.Dni == numero);
                }
                else
                {
                    pacienteEncotrado = centroMedico.ObtenerPaciente(paciente => paciente.NumeroAfiliado == numero);

                }

                //si se encontro un paciente cambio los valores
                if (pacienteEncotrado is not null)
                {
                    mensajeDeBusqueda = pacienteEncotrado.ToString();
                    colorFondoText = Color.Green;
                    this.btnIngresar.Enabled = true;
                }


                this.txtAfiliadoEncontrado.Text = mensajeDeBusqueda;
                this.txtAfiliadoEncontrado.BackColor = colorFondoText;



            }

        }


        /// <summary>
        /// Agrega el paciente a la guardia, para ser atendido por un medico. Solo se va poder presionar cuando se haya enconcontrado al paciente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //cambio la propiedad, para que figure que no esta atendido
                this.pacienteEncotrado.EnEspera = true;
                //modifico en la DB para que el medico pueda visualizar los pacientes en guardia
                ADOPacientes.Modificar(this.pacienteEncotrado);
                centroMedico.Agregar(this.pacienteEncotrado);

                this.ActualizarElementos(); //ACTUALIZA LA LISTA DE FORMA MANUAL Y BLOQUEA EL GROUPBOX
            }
            catch (FalloModificarPacienteException ex)
            {
                this.txtAfiliadoEncontrado.Text = ex.Message;
                this.txtAfiliadoEncontrado.BackColor = Color.Red;
            }


            //actualizo la listBox Y REVISAR ESTA PARTE PORQUE DEBO AGREGARLA A LA DB
            //this.ActualizarElementos();
        }

        /// <summary>
        /// Limpia todos los controles del groupBox
        /// </summary>
        private void RestablecerGroupBox()
        {
            this.txtDatosBusqueda.Clear();
            this.txtAfiliadoEncontrado.Clear();
            this.txtAfiliadoEncontrado.BackColor = Color.White;
            this.cmbTipoGuardia.SelectedIndex = 0;
            this.rdbNumAfiliado.Checked = true;
            this.btnIngresar.Enabled = false;
            this.grpCargarPaciente.Enabled = false;
            this.btnDesbloquear.ImageIndex = 0;

        }
    }
}
