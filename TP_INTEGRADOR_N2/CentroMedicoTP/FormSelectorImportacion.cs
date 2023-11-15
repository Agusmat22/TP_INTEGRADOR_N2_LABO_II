﻿using Entidades;
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
    public partial class FormSelectorImportacion : Form
    {
        private string rutaAlmacenamiento;
        private CentroMedico centroMedico;
        public FormSelectorImportacion(CentroMedico centroMedico)
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
        private void btnImportar_Click(object sender, EventArgs e)
        {

            if (this.rutaAlmacenamiento is not null)
            {

                try
                {/*
                    //combino la ruta con el nombre del archivo ingresado por el textBox
                    this.rutaAlmacenamiento = Path.Combine(this.rutaAlmacenamiento, this.txtNombreArchivo.Text +".json");

                    //OPCIONES DE IDENTADO
                    JsonSerializerOptions options = new JsonSerializerOptions();
                    //escritura identada al guardar el JSON
                    options.WriteIndented = true;


                    using (StreamWriter streamWriter = new StreamWriter(this.rutaAlmacenamiento))
                    {

                        string listaSerializada;

                        //selecciono la lista que va ser serializada
                        if (this.cmbLista.SelectedItem.ToString() == "Pacientes")
                        {
                            listaSerializada = JsonSerializer.Serialize<List<Paciente>>(centroMedico.Pacientes, options);


                        }
                        else
                        {
                            listaSerializada = JsonSerializer.Serialize<List<Medico>>(centroMedico.Medicos, options);

                        }

                        //escribo el archivo
                        streamWriter.Write(listaSerializada);

                        this.DialogResult |= DialogResult.OK;

                    }*/

                    this.rutaAlmacenamiento = Path.Combine(this.rutaAlmacenamiento, this.txtNombreArchivo.Text + ".json");


                    GestorArchivos<Paciente> gestorArchivos = new GestorArchivos<Paciente>(this.rutaAlmacenamiento, this.centroMedico.Pacientes);

                    //serializo el objeto sino no puedo exporatar la lista de pacientes
                    gestorArchivos.SerializarObjeto();

                    //guarda el archivo
                    gestorArchivos.GuardarArchivo();

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
            this.cmbLista.Items.Add("Medicos");
            //asigno un tipo predeterminado
            this.cmbLista.SelectedIndex = 0;

        }


    }
}
