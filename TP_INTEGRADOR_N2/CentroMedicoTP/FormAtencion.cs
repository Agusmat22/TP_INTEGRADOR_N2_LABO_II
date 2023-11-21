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
using Entidades.MetodosDeExtension;

namespace CentroMedicoTP
{
    public partial class FormAtencion : Form
    {
        private CentroMedico centroMedico;
        private Paciente pacienteAtendido;
        private Medico medico;
        private RestablecerMenuPrincipal restablecer;
        public FormAtencion(CentroMedico centroMedico, RestablecerMenuPrincipal restablecer)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.restablecer = restablecer;
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {
            //ACA FALTA CARGAR LOS NOMBRES DE LOS MEDICOS
            foreach (Medico item in this.centroMedico.Medicos)
            {
                cmbMedicos.Items.Add(item);
            }


            //bloqueo el acceso al richTextBox
            this.ActualizarAccesoControles();

            this.ActualizarListBox(); //muestro la lista en el listBox

            this.btnAtender.Enabled = false; //solo al principio para que un medico se loguee

            this.cmbMedicos.SelectedIndexChanged += this.SeleccionarMedico;

            this.centroMedico.OnActualizarLista += this.ActualizarListBox; //agrego el manejador para que se actualice cuando ocurra una modificacion



        }

        /// <summary>
        /// Actualiza el acceso a los controlores del para realizar el diagnostico
        /// </summary>
        private void ActualizarAccesoControles()
        {
            bool acceso;

            if (this.rtbDiagnostico.Enabled == true)
            {
                acceso = false;
                this.btnAtender.Enabled = true;
                this.rtbDiagnostico.Text = string.Empty;
            }
            else
            {
                acceso = true;
                this.btnAtender.Enabled = false;

            }

            this.rtbDiagnostico.Enabled = acceso;
            this.btnDiagnosticar.Enabled = acceso;
            this.btnHistoriaClinica.Enabled = acceso;
        }

        /// <summary>
        /// Atiende el medico al paciente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAtender_Click(object sender, EventArgs e)
        {

            //guardo al paciente atendido en mi atributo
            this.pacienteAtendido = (Paciente)lstbpacientes.SelectedItem;

            if (this.pacienteAtendido is not null)
            {
                this.ActualizarAccesoControles();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente");
            }


        }

        public void ActualizarListBox()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(ActualizarListBox);
            }
            else
            {
                this.lstbpacientes.DataSource = null;
                this.lstbpacientes.DataSource = centroMedico.Pacientes.Where(pacientes => pacientes.EnEspera == true).ToList();
            }

        }

        /// <summary>
        /// Es un manejador para el comboBox, cuando se cambie de item se instanciara el medico
        /// </summary>
        /// <param name="cmb"></param>
        /// <param name="ev"></param>
        public void SeleccionarMedico(object cmb, EventArgs ev)
        {
            string nombreMedico = this.cmbMedicos.SelectedItem.ToString();

            if (nombreMedico is not null)
            {
                this.medico = this.centroMedico.ObtenerMedico(medico => medico == nombreMedico);
                this.lblMatricula.Text = $"Matricula: {this.medico.NumeroMatricula}";
            }

            this.btnAtender.Enabled = true; //cuando selecciona un medico, se activa el boton

        }

        private void btnDiagnosticar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbDiagnostico.Text != string.Empty)
                {
                    //genero la historia clinica
                    string historiaClinica = this.centroMedico.GenerarHistoriaClinica(this.rtbDiagnostico.Text, this.pacienteAtendido, this.medico);

                    //GUARDO LA HISTORIA CLINICA EN EL PACIENTE
                    this.pacienteAtendido.HistoriaClinica = historiaClinica;

                    //ATIENDO AL PACIENTE GUARDANDO EL VALOR DE enEspera
                    this.medico.AtenderPaciente(this.pacienteAtendido);


                    //GUARDO DICHOS CAMBIOS EN LA BASE DE DATOS
                    ADOPacientes.Modificar(this.pacienteAtendido);

                    this.ActualizarAccesoControles();
                }
            }
            catch (FalloModificarRegistroException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }


        private void btnHistoriaClinica_Click(object sender, EventArgs e)
        {
            FormHistoriaClinica formHC = new FormHistoriaClinica(this.pacienteAtendido.HistoriaClinica);
            formHC.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.restablecer();
            this.Close();
        }
    }
}
