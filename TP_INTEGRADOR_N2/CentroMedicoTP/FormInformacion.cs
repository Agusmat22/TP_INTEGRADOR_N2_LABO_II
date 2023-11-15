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
        private ActualizarListboxGenerico actualizarListBox;
        public FormInformacion(CentroMedico centroMedico, ActualizarListboxGenerico actualizarListBox)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.actualizarListBox = actualizarListBox;
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
            //ejecuto en un subproceso la actualizacion de la lista
            Task tarea = Task.Run(() => this.actualizarListBox(this.lstbPacientes, paciente => paciente is not null));

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
    }
}
