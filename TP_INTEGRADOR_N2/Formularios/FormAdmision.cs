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
            foreach (EEspecialidad item in Enum.GetValues(typeof(EEspecialidad)))
            {
                this.cmbTipoGuardia.Items.Add(item);
            }

            this.cmbTipoGuardia.SelectedIndex = 0;


        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRegistrarPaciente formRegistrarPaciente = new FormRegistrarPaciente();

            formRegistrarPaciente.ShowDialog();

            if (formRegistrarPaciente.PacienteRegistrado is not null)
            {
                this.centroMedico.AgregarPaciente(formRegistrarPaciente.PacienteRegistrado);
            }

        }

        private void medicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRegistrarMedico formRegistrarMedico = new FormRegistrarMedico();

            formRegistrarMedico.ShowDialog();

            if (formRegistrarMedico.MedicoRegistrado is not null)
            {
                this.centroMedico.AgregarMedico(formRegistrarMedico.MedicoRegistrado);
            }

        }

        private void ActualizarElementos()
        {
            this.lstbPacientesEnEspera.DataSource = centroMedico.Pacientes;

            if (this.richTextBox1.Text != string.Empty)
            {
                this.richTextBox1.Text = string.Empty;
            }

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