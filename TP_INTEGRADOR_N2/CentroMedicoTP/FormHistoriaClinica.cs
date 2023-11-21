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
    public partial class FormHistoriaClinica : Form
    {
        string historiaClinica;
        public FormHistoriaClinica(string historiaClinica)
        {
            InitializeComponent();
            this.historiaClinica = historiaClinica;
        }

        private void FormHistoriaClinica_Load(object sender, EventArgs e)
        {
            rtbHistoriaClinica.ReadOnly = true; // Habilitar desplazamiento
            rtbHistoriaClinica.Text = this.historiaClinica;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
