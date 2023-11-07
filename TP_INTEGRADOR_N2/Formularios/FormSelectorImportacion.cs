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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormSelectorImportacion : Form
    {
        private string rutaAlmacenamiento;
        private CentroMedico centroMedico;
        public FormSelectorImportacion()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //Esta clase me permite selecciona un DIRECTORIO
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                //descripcion del dialogo
                folderBrowser.Description = "Seleccion una carpeta";

                //Le indico al dialogo que empiece en Mi pc
                folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    //guardo la ruta seleccionada
                    this.rutaAlmacenamiento = folderBrowser.SelectedPath;
                    this.txtRuta.Text = this.rutaAlmacenamiento;
                    this.txtRuta.BackColor = Color.Green;
                }
                else
                {
                    this.txtRuta.PlaceholderText = "Error al seleccionar el directorio";
                    this.BackColor = Color.Red;
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //TESTEAR QUE FUNCIONE PORQUE NO LA PROBE TODAVIA
        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (this.rutaAlmacenamiento != string.Empty)
            {

                try
                {
                    this.rutaAlmacenamiento = Path.Combine(this.rutaAlmacenamiento, this.txtNombreArchivo.Text);

                    //OPCIONES DE IDENTADO
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    //escritura identada
                    options.WriteIndented = true;


                    using (StreamWriter streamWriter = new StreamWriter(this.rutaAlmacenamiento))
                    {

                        string listaSerializada;

                        if (this.cmbLista.SelectedText == "Pacientes")
                        {
                            listaSerializada = JsonSerializer.Serialize<List<Paciente>>(centroMedico.Pacientes, options);


                        }
                        else
                        {
                            listaSerializada = JsonSerializer.Serialize<List<Medico>>(centroMedico.Medicos, options);

                        }

                        //escribo el archivo
                        streamWriter.Write(listaSerializada);

                    }

                }
                catch (Exception ex) 
                {

                    MessageBox.Show(ex.Message);
                }

                
            }
        }

        private void FormSelectorImportacion_Load(object sender, EventArgs e)
        {
            this.cmbLista.Items.Add("Pacientes");
            this.cmbLista.Items.Add("Medicos");
        }
    }
}
