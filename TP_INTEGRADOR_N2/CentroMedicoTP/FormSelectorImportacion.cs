using Entidades;
using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using Entidades.MetodosDeExtension;
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
    public partial class FormSelectorImportacion : Form
    {
        private List<Paciente> pacientesImportados;
        private CentroMedico centroMedico;
        private int agregados;
        private int repetidos;

        public int Agregados { get => agregados; set => agregados = value; }
        public int Repetidos { get => repetidos; set => repetidos = value; }

        public FormSelectorImportacion(CentroMedico centroMedico)
        {
            InitializeComponent();
            this.pacientesImportados = new List<Paciente>();
            this.centroMedico = centroMedico;
        }

        private void FormSelectorImportacion_Load(object sender, EventArgs e)
        {
            //los inicializo
            this.agregados = 0;
            this.repetidos = 0;
        }

        private void btnSeleccionarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                string rutaArchivo = openFileDialog.FileName;

                try
                {
                    GestorArchivos<Paciente> gestorArchivos = new GestorArchivos<Paciente>(rutaArchivo);
                    gestorArchivos.Deserializar();

                    this.pacientesImportados = gestorArchivos.Registros;

                    this.lstbPacientes.DataSource = null;
                    this.lstbPacientes.DataSource = this.pacientesImportados;
                    this.lstbPacientes.ClearSelected();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }

        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (this.pacientesImportados.Count > 0)
            {
                
                //agrego los pacientes a la lista que no existan
                centroMedico.ExtenderListaPacientes(this.pacientesImportados);

                //los guardo en la DB  REVISAR
                foreach (Paciente item in this.pacientesImportados)
                {
                    try
                    {
                        ADOPacientes.Guardar(item);
                        agregados++;
                    }
                    catch(FalloGuardarRegistroException)
                    {
                        repetidos++;    
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                this.DialogResult = DialogResult.OK;              
            }
            else
            {
                MessageBox.Show("Error, no se encontro pacientes para importar","Error");

            }

        }
    }
}
