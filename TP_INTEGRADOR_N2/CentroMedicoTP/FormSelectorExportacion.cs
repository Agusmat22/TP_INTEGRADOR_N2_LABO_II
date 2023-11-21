using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentroMedicoTP
{
    public partial class FormSelectorExportacion : Form
    {
        private string rutaAlmacenamiento;
        private CentroMedico centroMedico;
        public FormSelectorExportacion(CentroMedico centroMedico)
        {
            InitializeComponent();
            this.centroMedico = centroMedico;
        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Esta clase me permite selecciona un DIRECTORIO
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                //descripcion del dialogo
                folderBrowser.Description = "Seleccionar carpeta";

                //Le indico al dialogo que empiece en Mi pc
                folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    //guardo la ruta seleccionada
                    this.rutaAlmacenamiento = folderBrowser.SelectedPath;
                    //this.rutaAlmacenamiento = Path.Combine(folderBrowser.SelectedPath, this.txtNombreArchivo.Text + ".json");
                    this.txtRuta.Text = this.rutaAlmacenamiento;
                    this.txtRuta.BackColor = Color.Green;

                    //habilito para que coloque el nombre
                    this.txtNombreArchivo.Enabled = true;
                    this.btnExportar.Enabled = true;
                }
                else
                {
                    this.txtRuta.PlaceholderText = "Error al seleccionar el directorio";
                    this.txtRuta.BackColor = Color.Red;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //TESTEAR QUE FUNCIONE PORQUE NO LA PROBE TODAVIA
        private void btnExportar_Click(object sender, EventArgs e)
        {

            if (this.rutaAlmacenamiento is not null)
            {

                try
                {
                    this.rutaAlmacenamiento = Path.Combine(this.rutaAlmacenamiento, this.txtNombreArchivo.Text + ".json");

                    GestorArchivos<Paciente> gestorArchivos = new GestorArchivos<Paciente>(this.rutaAlmacenamiento, this.centroMedico.Pacientes);

                    //serializo el objeto sino no puedo exporatar la lista de pacientes
                    gestorArchivos.Serializar();

                    //guarda el archivo
                    gestorArchivos.Exportar();

                    this.DialogResult = DialogResult.OK;
                }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                this.txtRuta.PlaceholderText = "ERROR, seleccione un directorio";
            }
        }

        private void FormSelectorImportacion_Load(object sender, EventArgs e)
        {
            //agrego los items para seleccionar el tipo de lista
            this.cmbLista.Items.Add("Pacientes");
            //asigno un tipo predeterminado
            this.cmbLista.SelectedIndex = 0;

        }


    }
}
