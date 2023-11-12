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
            centroMedico = new CentroMedico();
        }

        /// <summary>
        /// Permite contener un formulario dentro del panel
        /// </summary>
        /// <param name="formulario"></param>
        private void MostrarFormulario(Form formulario)
        {
            //limpia el panel antes de agregar un form
            this.LimpiarPanel();

            // Configura el formulario que se va a mostrar
            formulario.TopLevel = false;
            //formulario.AutoScroll = true;
            panelForm.Controls.Add(formulario);
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            //aca muestro el formulario
            formulario.Show();
        }

        private void btnAdmision_Click(object sender, EventArgs e)
        {
            this.MostrarFormulario(new FormAdmision(centroMedico, restablecerMenu));
        }


        private void LimpiarPanel()
        {
            // Limpia el panel antes de agregar un nuevo formulario
            panelForm.Controls.Clear();
        }

        private void AgregarTitulo()
        {
            panelForm.Controls.Add(this.label1);
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            centroMedico.Pacientes = ADOPacientes.ObtenerPacientesTotales();
            centroMedico.Medicos = ADOMedicos.ObtenerMedicosTotales();

            this.restablecerMenu = this.AgregarTitulo;

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarPaciente registrarPaciente = new FormRegistrarPaciente("REGISTRAR PACIENTE",centroMedico, restablecerMenu);
            this.MostrarFormulario(registrarPaciente);

        }
    }
}