using Entidades;
using Entidades.BaseDeDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormInformacion : Form
    {
        private CentroMedico centroMedico;
        public FormInformacion()
        {
            InitializeComponent();
            centroMedico = new CentroMedico();  
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormInformacionPacientes_Load(object sender, EventArgs e)
        {
            centroMedico.Pacientes = ADOPacientes.ObtenerPacientesTotales();
            centroMedico.Medicos = ADOMedicos.ObtenerMedicosTotales();


            this.ActualizarElementos();
        }

        /// <summary>
        /// Actualiza los elementos de la lista
        /// </summary>
        private void ActualizarElementos()
        {

            this.lstbPacientes.DataSource = null;
            this.lstbPacientes.DataSource = centroMedico.Pacientes;
            this.lstbPacientes.SelectedItem = null;

            this.lstbMedicos.DataSource = null;
            this.lstbMedicos.DataSource = centroMedico.Medicos;
            this.lstbMedicos.SelectedItem = null;


        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FormSelectorImportacion selectorImportacion = new FormSelectorImportacion(centroMedico);

            DialogResult resultado = selectorImportacion.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Importacion con exito");
            }
            else if(resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Importacion cancelada");
            }
        }
    }
}
