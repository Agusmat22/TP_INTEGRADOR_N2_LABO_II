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
        public FormInformacion()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormInformacionPacientes_Load(object sender, EventArgs e)
        {
            this.ActualizarElementos(); 
        }

        /// <summary>
        /// Actualiza los elementos de la lista
        /// </summary>
        private void ActualizarElementos()
        {

            this.lstbPacientes.DataSource = null;
            this.lstbPacientes.DataSource = ADOPacientes.ObtenerPacientesTotales();
            this.lstbPacientes.SelectedItem = null; 

            this.lstbMedicos.DataSource = null;
            this.lstbMedicos.DataSource = ADOMedicos.ObtenerMedicosTotales();
            this.lstbMedicos.SelectedItem = null;


        }
    }
}
