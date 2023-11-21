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

        public FormAdmision(CentroMedico centroMedico, RestablecerMenuPrincipal restablecer)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.restablecer = restablecer;
        }

        private void FormAdmision_Load(object sender, EventArgs e)
        {
        
            this.RestablecerGroupBox(); //bloqueo el groupBox

            this.AgregarPacientesListBox(); //muestro los pacientes

            //le agrego un manejador al evento para que al momento que haya una modificacion, lo actualice
            this.centroMedico.OnActualizarLista += this.Actualizar;


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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.restablecer();
            this.Close();
        }



        /// <summary>
        /// Obtendra el paciente buscado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                //valido que el paciente NO  este en espera
                if (!this.pacienteEncotrado.EnEspera)
                {

                    this.pacienteEncotrado.FechaModificacion = DateTime.Now;
                    this.pacienteEncotrado.EnEspera = true;
                    //ADOPacientes.Modificar(this.pacienteEncotrado, true);
                    ADOPacientes.Modificar(this.pacienteEncotrado);

                    this.RestablecerGroupBox();
                }
                else
                {
                    throw new Exception("ERROR El paciente ya se encuentra en sala de espera.");
                }


            }
            catch (FalloModificarRegistroException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }


        }

        /// <summary>
        /// Limpia todos los controles del groupBox
        /// </summary>
        private void RestablecerGroupBox()
        {
            this.txtDatosBusqueda.Clear();
            this.txtAfiliadoEncontrado.Clear();
            this.txtAfiliadoEncontrado.BackColor = Color.White;
            this.rdbNumAfiliado.Checked = true;
            this.btnIngresar.Enabled = false;
            this.grpCargarPaciente.Enabled = false;
            this.btnDesbloquear.ImageIndex = 0;

        }

        /// <summary>
        /// Actualizara el listBox mediante un subProceso (hilo)
        /// </summary>
        public void Actualizar()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(Actualizar);
            }
            else
            {
                this.AgregarPacientesListBox();
            }

        }

        /// <summary>
        /// Actualiza el listBox al invocarse por unica vez
        /// </summary>
        public void AgregarPacientesListBox()
        {
            this.lstbPacientesEnEspera.DataSource = null;
            this.lstbPacientesEnEspera.DataSource = this.centroMedico.Pacientes.Where(paciente => paciente.EnEspera == true).ToList();
        }
    }
}
