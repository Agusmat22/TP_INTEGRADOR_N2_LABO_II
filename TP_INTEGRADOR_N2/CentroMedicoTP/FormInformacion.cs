using Entidades;
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
    public partial class FormInformacion : Form
    {
        private CentroMedico centroMedico;
        public FormInformacion(CentroMedico centroMedico)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FormSelectorImportacion formSelectorImportacion = new FormSelectorImportacion(this.centroMedico);

            DialogResult resultado = formSelectorImportacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Archivo importado correctamente");
            }
            else
            {
                MessageBox.Show("Importacion cancelada");
            }
        }

        private void FormInformacion_Load(object sender, EventArgs e)
        {
            this.centroMedico.OnActualizarLista += this.ActualizarListBox;

        }

        /// <summary>
        /// Elimina el paciente de la DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstbPacientes.SelectedItem is not null)
            {
                //lo elimino del centro medico
                this.centroMedico.EliminarPacientes((Paciente)this.lstbPacientes.SelectedItem);
            }
        }

        public void ActualizarListBox(List<Paciente> pacientes, int intervaloTiempo)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(ActualizarListBox, pacientes, intervaloTiempo);
            }
            else
            {
                if (this.centroMedico.Pacientes.Count > 0)
                {
                    this.lstbPacientes.DataSource = null;
                    this.lstbPacientes.DataSource = pacientes.Where(pacientes => pacientes.EnEspera == true).ToList();
                }
            }

        }
    }
}
