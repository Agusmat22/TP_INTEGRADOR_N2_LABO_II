namespace CentroMedicoTP
{
    partial class FormRegistrarPaciente
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
            grpRegistrar = new GroupBox();
            dtpFechaNacimiento = new DateTimePicker();
            lblFechaNacimiento = new Label();
            lblComboBox = new Label();
            cmbTipo = new ComboBox();
            lblNumero = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtNumero = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            lblTitulo = new Label();
            btnVolver = new Button();
            grpTipoRegistro = new GroupBox();
            rdbMedico = new RadioButton();
            rdbPaciente = new RadioButton();
            grpRegistrar.SuspendLayout();
            grpTipoRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // grpRegistrar
            // 
            grpRegistrar.Controls.Add(dtpFechaNacimiento);
            grpRegistrar.Controls.Add(lblFechaNacimiento);
            grpRegistrar.Controls.Add(lblComboBox);
            grpRegistrar.Controls.Add(cmbTipo);
            grpRegistrar.Controls.Add(lblNumero);
            grpRegistrar.Controls.Add(lblDni);
            grpRegistrar.Controls.Add(lblApellido);
            grpRegistrar.Controls.Add(lblNombre);
            grpRegistrar.Controls.Add(txtNumero);
            grpRegistrar.Controls.Add(txtDni);
            grpRegistrar.Controls.Add(txtApellido);
            grpRegistrar.Controls.Add(txtNombre);
            grpRegistrar.Location = new Point(111, 154);
            grpRegistrar.Name = "grpRegistrar";
            grpRegistrar.Size = new Size(515, 251);
            grpRegistrar.TabIndex = 5;
            grpRegistrar.TabStop = false;
            grpRegistrar.Text = "Campos a rellenar";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            dtpFechaNacimiento.Location = new Point(298, 117);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(171, 27);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechaNacimiento.Location = new Point(298, 101);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(116, 13);
            lblFechaNacimiento.TabIndex = 10;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblComboBox
            // 
            lblComboBox.AutoSize = true;
            lblComboBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblComboBox.Location = new Point(42, 169);
            lblComboBox.Name = "lblComboBox";
            lblComboBox.Size = new Size(0, 13);
            lblComboBox.TabIndex = 8;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(42, 185);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(171, 28);
            cmbTipo.TabIndex = 7;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumero.Location = new Point(298, 170);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(0, 13);
            lblNumero.TabIndex = 6;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(303, 31);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 13);
            lblDni.TabIndex = 5;
            lblDni.Text = "Dni:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(42, 101);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(53, 13);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(42, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(52, 13);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre:";
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(298, 186);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(171, 27);
            txtNumero.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(298, 47);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(171, 27);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtApellido.Location = new Point(42, 117);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(171, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(42, 47);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 27);
            txtNombre.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ScrollBar;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(510, 411);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 36);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(304, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(127, 24);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "REGISTRAR";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Control;
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(111, 411);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(116, 36);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // grpTipoRegistro
            // 
            grpTipoRegistro.Controls.Add(rdbMedico);
            grpTipoRegistro.Controls.Add(rdbPaciente);
            grpTipoRegistro.Location = new Point(257, 72);
            grpTipoRegistro.Name = "grpTipoRegistro";
            grpTipoRegistro.Size = new Size(220, 65);
            grpTipoRegistro.TabIndex = 14;
            grpTipoRegistro.TabStop = false;
            grpTipoRegistro.Text = "Tipo de registro";
            // 
            // rdbMedico
            // 
            rdbMedico.AutoSize = true;
            rdbMedico.Location = new Point(137, 31);
            rdbMedico.Name = "rdbMedico";
            rdbMedico.Size = new Size(65, 19);
            rdbMedico.TabIndex = 1;
            rdbMedico.TabStop = true;
            rdbMedico.Text = "Medico";
            rdbMedico.UseVisualStyleBackColor = true;
            // 
            // rdbPaciente
            // 
            rdbPaciente.AutoSize = true;
            rdbPaciente.Location = new Point(16, 31);
            rdbPaciente.Name = "rdbPaciente";
            rdbPaciente.Size = new Size(70, 19);
            rdbPaciente.TabIndex = 0;
            rdbPaciente.TabStop = true;
            rdbPaciente.Text = "Paciente";
            rdbPaciente.UseVisualStyleBackColor = true;
            // 
            // FormRegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(752, 473);
            Controls.Add(grpTipoRegistro);
            Controls.Add(btnVolver);
            Controls.Add(lblTitulo);
            Controls.Add(grpRegistrar);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistrarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += FormRegistrarPaciente_Load;
            grpRegistrar.ResumeLayout(false);
            grpRegistrar.PerformLayout();
            grpTipoRegistro.ResumeLayout(false);
            grpTipoRegistro.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpRegistrar;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblFechaNacimiento;
        private Label lblComboBox;
        private ComboBox cmbTipo;
        private Label lblNumero;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtNumero;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private Label lblTitulo;
        private Button btnVolver;
        private GroupBox grpTipoRegistro;
        private RadioButton rdbPaciente;
        private RadioButton rdbMedico;
    }
}