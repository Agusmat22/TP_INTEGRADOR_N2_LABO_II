//using Formularios;

using Entidades;
using Entidades.BaseDeDatos;

namespace CentroMedicoTP
{
    public delegate void RestablecerMenuPrincipal();


    public partial class FormMenuPrincipal : Form
    {
        private CentroMedico centroMedico;
        private RestablecerMenuPrincipal restablecerMenu;


        public FormMenuPrincipal()
        {
            InitializeComponent();
            //instancio el centro medico
            centroMedico = new CentroMedico(1000);
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                centroMedico.Pacientes = ADOPacientes.ObtenerLista();

                centroMedico.Medicos = ADOMedicos.ObtenerMedicosTotales(); //--> SOLO INICIO LOS MEDICOS YA QUE LOS PACIENTES SE ESTARAN ACTUALIZANDO
                                                                           //Inicio el hilo para actualizar la lista cuando sucede una modificacion
                this.centroMedico.IniciarActualizacion();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            this.restablecerMenu = this.AgregarTitulo;

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
            FormAdmision admision = new FormAdmision(this.centroMedico, this.restablecerMenu);
            this.MostrarFormulario(admision);

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarPaciente registrarPaciente = new FormRegistrarPaciente(this.centroMedico, this.restablecerMenu);
            this.MostrarFormulario(registrarPaciente);

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            FormInformacion formInformacion = new FormInformacion(this.centroMedico, this.restablecerMenu);
            this.MostrarFormulario(formInformacion);
        }


        private void btnAtencion_Click(object sender, EventArgs e)
        {
            FormAtencion formAtencionMedica = new FormAtencion(this.centroMedico, this.restablecerMenu);
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
                try
                {
                    //cancelo el hilo
                    this.centroMedico.CancelarActualizacion();
                }
                catch (Exception ex)//LE PONGO UN CACHT PARA EN CASO QUE NO PUEDA CARGARLO EN LA BASE DE DATOS SE LOGRE CERRAR SIN PROBLEMAS
                {
                    MessageBox.Show($"Cerrando app, la aplicacion no logro conectarse a la BASE DE DATOS\n{ex.Message}");
                }

            }
        }
    }
}