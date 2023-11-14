using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.BaseDeDatos;
using Entidades.Excepciones;

namespace CentroMedicoTP
{
    public partial class FormAtencion : Form
    {
        private CentroMedico centroMedico;
        private ActualizarListboxGenerico actualizarListbox;
        private Paciente pacienteAtendido;
        private Medico medico;
        public FormAtencion(CentroMedico centroMedico, ActualizarListboxGenerico actualizarListbox)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.actualizarListbox = actualizarListbox;
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {
            //ACA FALTA CARGAR LOS NOMBRES DE LOS MEDICOS
            foreach (Medico item in this.centroMedico.Medicos)
            {
                cmbMedicos.Items.Add(item);
            }

            //SELECCIONO EL PRIMER ITEM DEL CMB
            this.cmbMedicos.SelectedIndex = 0;

            this.ActualizarAccesoControlesDiagnostico();
            //ejecuto la ejecucion en un subproceso para la lista
            Task actualizacionListPacientes = Task.Run(() => this.actualizarListbox(this.lstbpacientes, pacientes => pacientes.EnEspera == true));
        }

        /// <summary>
        /// Actualiza el acceso a los controlores del para realizar el diagnostico
        /// </summary>
        private void ActualizarAccesoControlesDiagnostico()
        {
            bool acceso;

            if (this.rtbDiagnostico.Enabled == true && this.btnDiagnosticar.Enabled == true)
            {
                acceso = false;
            }
            else
            {
                acceso = true;
            }

            this.rtbDiagnostico.Enabled = acceso;
            this.btnDiagnosticar.Enabled = acceso;
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            this.pacienteAtendido = (Paciente)lstbpacientes.SelectedItem;

            try
            {
                //le cambio el valor de "enEspera"
                medico.AtenderPaciente(this.pacienteAtendido);

                //realizo el cambio en la DB
                //ADOPacientes.Modificar(this.pacienteAtendido);
            }
            catch (FalloModificarPacienteException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
