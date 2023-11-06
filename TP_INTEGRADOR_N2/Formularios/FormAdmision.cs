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
    public partial class FormAdmision : Form
    {
        private CentroMedico centroMedico;

        public FormAdmision()
        {
            InitializeComponent();
            centroMedico = new CentroMedico();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            FormIngresoPaciente formIngresoPaciente = new FormIngresoPaciente();
            DialogResult resultado = formIngresoPaciente.ShowDialog();
            if (resultado == DialogResult.OK)
            {

            }
            this.ActualizarElementos();
        }

        private void ActualizarElementos()
        {
            this.lstbPacientesEnEspera.DataSource = null;
            this.lstbPacientesEnEspera.DataSource = ADOPacientes.ObtenerPacientesTotales(0);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAdmision_Load(object sender, EventArgs e)
        {
            this.ActualizarElementos();
        }

    }
}
