namespace Formularios
{
    public partial class FormAdmision : Form
    {
        public FormAdmision()
        {
            InitializeComponent();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarMedico formRegistrarMedico = new FormRegistrarMedico();

            formRegistrarMedico.ShowDialog();


        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarPaciente formRegistrarPaciente = new FormRegistrarPaciente();

            formRegistrarPaciente.ShowDialog();
        }
    }
}