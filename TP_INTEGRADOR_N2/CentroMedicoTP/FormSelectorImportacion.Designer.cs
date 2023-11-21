namespace CentroMedicoTP
{
    partial class FormSelectorImportacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSeleccionarArchivo = new Button();
            lstbPacientes = new ListBox();
            btnImportar = new Button();
            label1 = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnSeleccionarArchivo
            // 
            btnSeleccionarArchivo.Location = new Point(44, 56);
            btnSeleccionarArchivo.Name = "btnSeleccionarArchivo";
            btnSeleccionarArchivo.Size = new Size(283, 35);
            btnSeleccionarArchivo.TabIndex = 0;
            btnSeleccionarArchivo.Text = "Seleccionar Archivo";
            btnSeleccionarArchivo.UseVisualStyleBackColor = true;
            btnSeleccionarArchivo.Click += btnSeleccionarArchivo_Click;
            // 
            // lstbPacientes
            // 
            lstbPacientes.Enabled = false;
            lstbPacientes.FormattingEnabled = true;
            lstbPacientes.ItemHeight = 15;
            lstbPacientes.Location = new Point(44, 118);
            lstbPacientes.Name = "lstbPacientes";
            lstbPacientes.Size = new Size(283, 244);
            lstbPacientes.TabIndex = 1;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(190, 387);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(137, 35);
            btnImportar.TabIndex = 2;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 23);
            label1.TabIndex = 4;
            label1.Text = "Importar pacientes";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(44, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 35);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormSelectorImportacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(375, 443);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(btnImportar);
            Controls.Add(lstbPacientes);
            Controls.Add(btnSeleccionarArchivo);
            Name = "FormSelectorImportacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Importacion";
            Load += FormSelectorImportacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSeleccionarArchivo;
        private ListBox lstbPacientes;
        private Button btnImportar;
        private Label label1;
        private Button btnCancelar;
    }
}