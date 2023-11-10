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

        public FormAdmision(CentroMedico centroMedico,RestablecerMenuPrincipal restablecer)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.restablecer = restablecer;
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
                this.LimpiarGrp();
                this.btnDesbloquear.ImageIndex = 0;
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
            this.lstbPacientesEnEspera.DataSource = (centroMedico.Pacientes).Where(paciente => paciente.Atendido == false).ToList();

            this.LimpiarGrp();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.restablecer();
            this.Close();
        }

        private void FormAdmision_Load(object sender, EventArgs e)
        {
            foreach (EEspecialidad item in Enum.GetValues(typeof(EEspecialidad)))
            {
                this.cmbTipoGuardia.Items.Add(item);
            }



            this.ActualizarElementos();
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
                    if (rdb == this.rdbAfiliado && rdb.Checked)
                    {
                        tipoBusqueda = "numero";
                    }
                    else if (rdb == this.rdbDni && rdb.Checked)
                    {
                        tipoBusqueda = "dni";

                    }
                    else
                    {
                        this.txtAfiliadoEncontrado.Text = "Error, debe seleccionar el tipo de busqueda";
                        this.txtAfiliadoEncontrado.BackColor = Color.Red;
                        break;
                    }
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

            if (tipoBusqueda != string.Empty && numero != -1)
            {

                if (tipoBusqueda == "dni")
                {
                    //Le paso una funcion lambda
                    pacienteEncotrado = centroMedico.ObtenerPaciente(paciente => paciente.Dni == numero);                   
                }
                else
                {
                    pacienteEncotrado = centroMedico.ObtenerPaciente(paciente => paciente.NumeroAfiliado == numero);

                }

                this.txtAfiliadoEncontrado.Text = pacienteEncotrado.ToString();
                this.txtAfiliadoEncontrado.BackColor = Color.Green;

                this.btnIngresar.Enabled = true;

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
                this.pacienteEncotrado.Atendido = false;
                //modifico en la DB para que el medico pueda visualizar los pacientes en guardia
                ADOPacientes.Modificar(this.pacienteEncotrado);
                centroMedico.Agregar(this.pacienteEncotrado);
                
               
            }
            catch (FalloModificarPacienteException ex)
            {
                this.txtAfiliadoEncontrado.Text = ex.Message;
                this.txtAfiliadoEncontrado.BackColor = Color.Red;
            }


            //actualizo la listBox Y REVISAR ESTA PARTE PORQUE DEBO AGREGARLA A LA DB
            this.ActualizarElementos();
        }

        /// <summary>
        /// Limpia todos los controles del groupBox
        /// </summary>
        private void LimpiarGrp()
        {
            this.txtDatosBusqueda.Clear();
            this.txtAfiliadoEncontrado.Clear();
            this.txtAfiliadoEncontrado.BackColor = Color.White;
            this.cmbTipoGuardia.SelectedIndex = 0;
            this.rdbAfiliado.Checked = true;
            this.btnIngresar.Enabled = false;
            this.grpCargarPaciente.Enabled = false;

        }
    }
}
