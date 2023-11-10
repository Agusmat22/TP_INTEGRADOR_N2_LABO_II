using Entidades;
using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormIngresoPaciente : Form
    {
        Paciente paciente;

        public FormIngresoPaciente()
        {
            InitializeComponent();
        }

        private void FormIngresoPaciente_Load(object sender, EventArgs e)
        {
            foreach (EEspecialidad item in Enum.GetValues(typeof(EEspecialidad)))
            {
                this.cmbTipoGuardia.Items.Add(item);
            }

            this.cmbTipoGuardia.SelectedIndex = 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //REVISAR ESTA BUSQUEDA
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string tipoBusqueda="";

            foreach (Control item in grbPaciente.Controls)
            {
                if (item is RadioButton rdbTipo && rdbTipo.Checked)
                {
                    if (rdbTipo == this.rdbAfiliado)
                    {
                        tipoBusqueda = "numero";
                    }
                    else
                    {
                        tipoBusqueda = "dni";
                    }
                }
                else if(item is TextBox txt )
                {
                    if(txt.Text != string.Empty)
                    {
                        if (Regex.IsMatch(txt.Text, @"^[0-9]+$"))
                        {
                            try
                            {
                                int numero = int.Parse(txt.Text);

                                //guardo el paciente

                                this.paciente = ADOPacientes.ObtenerPaciente(tipoBusqueda, numero);
                            }
                            catch (FalloBusquedaPacienteException ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            this.txtAfiliadoEncontrado.PlaceholderText = "Error, debe ingresar un numero";

                        }

                    }
                    else
                    {
                        this.txtAfiliadoEncontrado.PlaceholderText = "Error, complete el campo";
                        this.txtAfiliadoEncontrado.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
