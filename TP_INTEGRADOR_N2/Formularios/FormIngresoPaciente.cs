﻿using Entidades;
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


    }
}