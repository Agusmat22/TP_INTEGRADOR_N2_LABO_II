//using Formularios;

using Entidades;
using Entidades.BaseDeDatos;

namespace CentroMedicoTP
{
    public delegate void RestablecerMenuPrincipal();

    //VOY A DIVIDIR LAS TAREA EN UNA PARTE QUE ACTUALICE LA LISTA DE LA CLASE Y OTRA QUE ACTUALICE LOS LISTBOX
    public delegate void ActualizarListboxGenerico();

    public partial class FormMenuPrincipal : Form
    {
        private CentroMedico centroMedico;
        private RestablecerMenuPrincipal restablecerMenu;
        private ActualizarListboxGenerico listBox;


        public FormMenuPrincipal()
        {
            InitializeComponent();
            //instancio el centro medico
            centroMedico = new CentroMedico(1000);
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            centroMedico.Pacientes = ADOPacientes.ObtenerLista();

            centroMedico.Medicos = ADOMedicos.ObtenerMedicosTotales(); //--> SOLO INICIO LOS MEDICOS YA QUE LOS PACIENTES SE ESTARAN ACTUALIZANDO
   
            this.restablecerMenu = this.AgregarTitulo;

            //AGREGO MANEJADOR AL DELEGADO
            //this.listBox = this.ActualizarListBox;

            this.centroMedico.OnActualizarLista += this.ActualizarPacientes;

            //Inicio el hilo para actualizar la lista cuando sucede una modificacion
            this.centroMedico.IniciarActualizacion();

        }

        /// <summary>
        /// Permite contener un formulario dentro del panel
        /// </summary>
        /// <param name="formulario"></param>
        private void MostrarFormulario(Form formulario)
        {
            //limpia el panel antes de agregar un form
            this.LimpiarPanel();

            // configuro el formulario que se va a mostrar
            formulario.TopLevel = false;

            //agrego el form al panel
            panelForm.Controls.Add(formulario);

            //le quito el borde al form de maximizar,cerrar y minimizar
            formulario.FormBorderStyle = FormBorderStyle.None;
            //indico que el form se expandira en todo el ancho y largo del panel
            formulario.Dock = DockStyle.Fill;
            //aca muestro el formulario
            formulario.Show();
        }

        /// <summary>
        /// Limpia todos los controles del panel, para luego podes ser utilizado por otro formulario
        /// </summary>
        private void LimpiarPanel()
        {
            // Limpia el panel antes de agregar un nuevo formulario
            panelForm.Controls.Clear();
        }

        /// <summary>
        /// agrega el titulo al formulario princiapl
        /// </summary>
        private void AgregarTitulo()
        {
            panelForm.Controls.Add(this.label1);
        }

        private void btnAdmision_Click(object sender, EventArgs e)
        {
            FormAdmision admision = new FormAdmision(this.centroMedico, this.restablecerMenu,this.listBox);
            this.MostrarFormulario(admision);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarPaciente registrarPaciente = new FormRegistrarPaciente("REGISTRAR PACIENTE", centroMedico, restablecerMenu);
            this.MostrarFormulario(registrarPaciente);

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            FormInformacion formInformacion = new FormInformacion(this.centroMedico);
            this.MostrarFormulario(formInformacion);
        }
  

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            FormAtencion formAtencionMedica = new FormAtencion(this.centroMedico);
            this.MostrarFormulario(formAtencionMedica);
        }

        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Encargado se consultar en el momento de estar cerrando la aplicacion para determinar si se cierra
        /// completamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Esta seguro que desea cerrar?", "Cerrando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                //cancelo el hilo
                this.centroMedico.CancelarActualizacion();
            }
        }

        /*
        private void ActualizarListBox(ListBox listBox,Func<Paciente,bool> condicion)
        {

            listBox.DataSource = null;
            //agrego la lista a un listBox dependiendo la condicion
            listBox.DataSource = this.centroMedico.Pacientes.Where(condicion).ToList();
        }*/

        //PROBADOOOO
        public void ActualizarPacientes(List<Paciente> pacientes, int intervaloTiempo)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(ActualizarPacientes, pacientes, intervaloTiempo);
            }
            else
            {
                if (this.listBox is not null && this.centroMedico.Pacientes.Count > 0)
                {/*
                    this.lstbPacientesEnEspera.DataSource = null;
                    this.lstbPacientesEnEspera.DataSource = pacientes.Where(pacientes => pacientes.EnEspera == true).ToList();
                    */
                    this.listBox();
                }
            }

        }


    }
}