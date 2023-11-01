using Entidades;
namespace Formularios
{
    public partial class FormAdmision : Form
    {
        CentroMedico centroMedico;

        public FormAdmision()
        {
            InitializeComponent();
            centroMedico = new CentroMedico();
        }


        private void FormAdmision_Load(object sender, EventArgs e)
        {

        }

        private void RegistrarPacienteToolStrip_Click(object sender, EventArgs e)
        {
            FormRegistrarPaciente formRegistrarPaciente = new FormRegistrarPaciente();

            DialogResult resultado = formRegistrarPaciente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.centroMedico.Agregar(formRegistrarPaciente.PacienteRegistrado);
                this.ActualizarElementos();
            }

        }

        private void RegistrarMedicoToolStrip_Click(object sender, EventArgs e)
        {
            FormRegistrarMedico formRegistrarMedico = new FormRegistrarMedico();

            DialogResult resultado = formRegistrarMedico.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.centroMedico.Agregar(formRegistrarMedico.MedicoRegistrado);
            }

        }

        private void ActualizarElementos()
        {
            this.lstbPacientesEnEspera.DataSource = null;
            this.lstbPacientesEnEspera.DataSource = centroMedico.Pacientes;

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            FormIngresoPaciente formIngresoPaciente = new FormIngresoPaciente();

            DialogResult resultado = formIngresoPaciente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Paciente ingresado a Guardia");
            }
        }
    }
}