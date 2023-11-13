//using Formularios;

using Entidades;
using Entidades.BaseDeDatos;

namespace CentroMedicoTP
{
    public delegate void RestablecerMenuPrincipal();

    public delegate void ActualizarListboxGenerico(ListBox listBox,Func<Paciente,bool> condicion);

    public partial class FormMenuPrincipal : Form
    {
        private CentroMedico centroMedico;
        private RestablecerMenuPrincipal restablecerMenu;
        private ActualizarListboxGenerico actualizarListBox;
        


        public FormMenuPrincipal()
        {
            InitializeComponent();
            //instancio el centro medico
            centroMedico = new CentroMedico();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            centroMedico.Pacientes = ADOPacientes.ObtenerPacientesTotales();
            centroMedico.Medicos = ADOMedicos.ObtenerMedicosTotales();

            //agrego metodo al delegado
            this.restablecerMenu = this.AgregarTitulo;

            //agrego el metodo al delegado que actualizara todos los listBox de todos los formularios
            this.actualizarListBox = this.RefrescarListBox;

            //HILO, SUBPROCESO VOY A PROBAR
            //Task tarea = Task.Run(() => this.actualizarListBox);

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
            this.MostrarFormulario(new FormAdmision(centroMedico, restablecerMenu,this.actualizarListBox));
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormRegistrarPaciente registrarPaciente = new FormRegistrarPaciente("REGISTRAR PACIENTE", centroMedico, restablecerMenu);
            this.MostrarFormulario(registrarPaciente);

        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            FormInformacion formInformacion = new FormInformacion(this.centroMedico,this.actualizarListBox);
            this.MostrarFormulario(formInformacion);
        }

        /*
        private void ActualizarListBoxPacientes(ListBox listBox)
        {
            listBox.DataSource = null;
            listBox.DataSource = this.centroMedico.Pacientes;
        }*/

        private void ActualizarListBoxPacientes(ListBox listBox,Func<Paciente,bool> condicion)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(ActualizarListBoxPacientes,listBox,condicion);
            }
            else
            {
                listBox.DataSource = null;
                //filtra dentro de la lista los pacientes con el delegado Func pasado por parametro
                listBox.DataSource = this.centroMedico.Pacientes.Where(condicion).ToList();
            }
            
        }

        /// <summary>
        /// Refresca cualquier ListBox pasada por parametro cada 1 minuto
        /// 
        /// </summary>
        /// <param name="listBox"></param>
        /// <param name="condicion"></param>
        private void RefrescarListBox(ListBox listBox,Func<Paciente,bool> condicion)
        {

            while (true)
            {
                this.ActualizarListBoxPacientes(listBox, condicion);
                //Cada 1 minuto actualiza
                Thread.Sleep(1000 * 60);
            }
        }
    }
}