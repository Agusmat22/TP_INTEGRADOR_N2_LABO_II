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
        private EventHandler seleccionador;
        private RestablecerMenuPrincipal restablecerMenu;

        public FormInformacion(CentroMedico centroMedico, RestablecerMenuPrincipal restablecerMenu)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.restablecerMenu = restablecerMenu;
        }



        private void FormInformacion_Load(object sender, EventArgs e)
        {
            this.Actualizar(); //ejecuto para que se muestre la lista pacientes,medicos

            //iniciio el form sin items seleccionados
            this.lstbMedicos.SelectedItem = null;
            this.lstbPacientes.SelectedItem = null;

            //agrego un delegado que me permite seleccionar una sola lista y no dos en simultaneo
            this.seleccionador += this.SeleccionarItem;
            //AGREGO EL MANEJADOR AMBOS LISTBOX
            this.lstbMedicos.SelectedIndexChanged += this.seleccionador;
            this.lstbPacientes.SelectedIndexChanged += this.seleccionador;


            this.centroMedico.OnActualizarLista += this.ActualizarListBox;

            //manual de ayudas al apoyar el mouse
            this.toolTip.SetToolTip(this.btnImportar, "Importa todos los pacientes registrados");
            this.toolTip.SetToolTip(this.btnExportar, "Exporta todos los pacientes registrados");
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
                this.Actualizar();
            }
            else if (this.lstbMedicos.SelectedItem is not null)
            {
                this.centroMedico.EliminarMedico((Medico)this.lstbMedicos.SelectedItem);
                this.Actualizar();
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
                this.Actualizar();

            }

        }

        /// <summary>
        /// Actualiza los listBox
        /// </summary>
        public void Actualizar()
        {
            this.lstbPacientes.DataSource = null;
            this.lstbPacientes.DataSource = centroMedico.Pacientes;
            this.lstbMedicos.DataSource = null;
            this.lstbMedicos.DataSource = centroMedico.Medicos;
        }


        private void btnExportar_Click(object sender, EventArgs e)
        {
            FormSelectorExportacion formSelectorExportacion = new FormSelectorExportacion(this.centroMedico);

            DialogResult resultado = formSelectorExportacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Archivo Exportado correctamente");
            }
            else
            {
                MessageBox.Show("Exportacion cancelada");
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            FormSelectorImportacion formSelectorImportacion = new FormSelectorImportacion(this.centroMedico);

            DialogResult resultado = formSelectorImportacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.Actualizar();
                MessageBox.Show($"Archivo importado correctamente\nAgregados: {formSelectorImportacion.Agregados}\nRepetidos: {formSelectorImportacion.Repetidos}");
            }
            else
            {
                MessageBox.Show("Importacion cancelada");
            }
        }

        /// <summary>
        /// Selecciona un item de ambos listBox, solo permitiendo elegir un listBox
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="even"></param>
        private void SeleccionarItem(object obj, EventArgs even)
        {
            ListBox listBox = (ListBox)obj;

            if (listBox == this.lstbPacientes)
            {
                if (this.lstbPacientes.SelectedItem is not null && this.lstbMedicos.SelectedItem is not null)
                {
                    this.lstbMedicos.SelectedItem = null;
                }
            }
            else if (listBox == this.lstbMedicos)
            {
                if (this.lstbMedicos.SelectedItem is not null && this.lstbMedicos.SelectedItem is not null)
                {
                    this.lstbPacientes.SelectedItem = null;
                }
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            this.restablecerMenu();
        }
    }
}
