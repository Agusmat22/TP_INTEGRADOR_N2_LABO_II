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

namespace CentroMedicoTP
{
    public partial class FormAtencion : Form
    {
        private CentroMedico centroMedico;
        private ActualizarListboxGenerico actualizarListbox;
        private Paciente atendido;
        public FormAtencion(CentroMedico centroMedico, ActualizarListboxGenerico actualizarListbox)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
            this.actualizarListbox = actualizarListbox;
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {
            this.ActualizarAccesoControlesDiagnostico();
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
    }
}
