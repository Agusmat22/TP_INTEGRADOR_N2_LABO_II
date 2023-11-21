namespace CentroMedicoTP
{
    partial class FormSelectorExportacion
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
            cmbLista = new ComboBox();
            label1 = new Label();
            btnSeleccionar = new Button();
            btnExportar = new Button();
            btnCancelar = new Button();
            txtRuta = new TextBox();
            txtNombreArchivo = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // cmbLista
            // 
            cmbLista.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbLista.FormattingEnabled = true;
            cmbLista.Location = new Point(65, 63);
            cmbLista.Name = "cmbLista";
            cmbLista.Size = new Size(233, 29);
            cmbLista.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 27);
            label1.Name = "label1";
            label1.Size = new Size(143, 23);
            label1.TabIndex = 1;
            label1.Text = "Seleccione la lista";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeleccionar.Location = new Point(65, 126);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(233, 34);
            btnSeleccionar.TabIndex = 2;
            btnSeleccionar.Text = "Seleccionar ruta";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Enabled = false;
            btnExportar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.Location = new Point(189, 342);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(109, 34);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(65, 342);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtRuta
            // 
            txtRuta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRuta.Location = new Point(65, 179);
            txtRuta.Name = "txtRuta";
            txtRuta.ReadOnly = true;
            txtRuta.Size = new Size(233, 29);
            txtRuta.TabIndex = 5;
            // 
            // txtNombreArchivo
            // 
            txtNombreArchivo.Enabled = false;
            txtNombreArchivo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreArchivo.Location = new Point(65, 272);
            txtNombreArchivo.Name = "txtNombreArchivo";
            txtNombreArchivo.Size = new Size(233, 29);
            txtNombreArchivo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 237);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 7;
            label2.Text = "Nombre del archivo";
            // 
            // FormSelectorExportacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(365, 402);
            Controls.Add(label2);
            Controls.Add(txtNombreArchivo);
            Controls.Add(txtRuta);
            Controls.Add(btnCancelar);
            Controls.Add(btnExportar);
            Controls.Add(btnSeleccionar);
            Controls.Add(label1);
            Controls.Add(cmbLista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSelectorExportacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportacion de pacientes";
            Load += FormSelectorImportacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbLista;
        private Label label1;
        private Button btnSeleccionar;
        private Button btnExportar;
        private Button btnCancelar;
        private TextBox txtRuta;
        private TextBox txtNombreArchivo;
        private Label label2;
    }
}