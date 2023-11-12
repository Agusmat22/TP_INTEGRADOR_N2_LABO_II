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
            label7 = new Label();
            label6 = new Label();
            cmbObraSocial = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNumAfiliado = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            lblTitulo = new Label();
            btnVolver = new Button();
            grpTipoRegistro = new GroupBox();
            rdbMedico = new RadioButton();
            radioButton1 = new RadioButton();
            grpRegistrar.SuspendLayout();
            grpTipoRegistro.SuspendLayout();
            SuspendLayout();
            // 
            // grpRegistrar
            // 
            grpRegistrar.Controls.Add(dtpFechaNacimiento);
            grpRegistrar.Controls.Add(label7);
            grpRegistrar.Controls.Add(label6);
            grpRegistrar.Controls.Add(cmbObraSocial);
            grpRegistrar.Controls.Add(label5);
            grpRegistrar.Controls.Add(label4);
            grpRegistrar.Controls.Add(label3);
            grpRegistrar.Controls.Add(label2);
            grpRegistrar.Controls.Add(txtNumAfiliado);
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
            dtpFechaNacimiento.Location = new Point(298, 183);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(171, 27);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(298, 167);
            label7.Name = "label7";
            label7.Size = new Size(116, 13);
            label7.TabIndex = 10;
            label7.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(298, 30);
            label6.Name = "label6";
            label6.Size = new Size(68, 13);
            label6.TabIndex = 8;
            label6.Text = "Obra Social:";
            // 
            // cmbObraSocial
            // 
            cmbObraSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObraSocial.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbObraSocial.FormattingEnabled = true;
            cmbObraSocial.Location = new Point(298, 46);
            cmbObraSocial.Name = "cmbObraSocial";
            cmbObraSocial.Size = new Size(171, 28);
            cmbObraSocial.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(298, 101);
            label5.Name = "label5";
            label5.Size = new Size(66, 13);
            label5.TabIndex = 6;
            label5.Text = "Nº Afiliado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 168);
            label4.Name = "label4";
            label4.Size = new Size(27, 13);
            label4.TabIndex = 5;
            label4.Text = "Dni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(42, 101);
            label3.Name = "label3";
            label3.Size = new Size(53, 13);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 13);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtNumAfiliado
            // 
            txtNumAfiliado.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumAfiliado.Location = new Point(298, 117);
            txtNumAfiliado.Name = "txtNumAfiliado";
            txtNumAfiliado.Size = new Size(171, 27);
            txtNumAfiliado.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtDni.Location = new Point(42, 183);
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
            lblTitulo.Location = new Point(257, 19);
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
            grpTipoRegistro.Controls.Add(radioButton1);
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(70, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Paciente";
            radioButton1.UseVisualStyleBackColor = true;
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
        private Label label7;
        private Label label6;
        private ComboBox cmbObraSocial;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNumAfiliado;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private Label lblTitulo;
        private Button btnVolver;
        private GroupBox grpTipoRegistro;
        private RadioButton radioButton1;
        private RadioButton rdbMedico;
    }
}