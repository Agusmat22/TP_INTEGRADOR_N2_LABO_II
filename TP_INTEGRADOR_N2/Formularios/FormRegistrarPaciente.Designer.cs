namespace Formularios
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
            groupBox1 = new GroupBox();
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
            label8 = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cmbObraSocial);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumAfiliado);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(39, 85);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 227);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Campos a rellenar";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(231, 166);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(171, 23);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(231, 150);
            label7.Name = "label7";
            label7.Size = new Size(116, 13);
            label7.TabIndex = 10;
            label7.Text = "Fecha de Nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(231, 38);
            label6.Name = "label6";
            label6.Size = new Size(68, 13);
            label6.TabIndex = 8;
            label6.Text = "Obra Social:";
            // 
            // cmbObraSocial
            // 
            cmbObraSocial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbObraSocial.FormattingEnabled = true;
            cmbObraSocial.Location = new Point(231, 54);
            cmbObraSocial.Name = "cmbObraSocial";
            cmbObraSocial.Size = new Size(171, 23);
            cmbObraSocial.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(231, 94);
            label5.Name = "label5";
            label5.Size = new Size(66, 13);
            label5.TabIndex = 6;
            label5.Text = "Nº Afiliado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 151);
            label4.Name = "label4";
            label4.Size = new Size(27, 13);
            label4.TabIndex = 5;
            label4.Text = "Dni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 94);
            label3.Name = "label3";
            label3.Size = new Size(53, 13);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 38);
            label2.Name = "label2";
            label2.Size = new Size(52, 13);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // txtNumAfiliado
            // 
            txtNumAfiliado.Location = new Point(231, 110);
            txtNumAfiliado.Name = "txtNumAfiliado";
            txtNumAfiliado.Size = new Size(171, 23);
            txtNumAfiliado.TabIndex = 3;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(22, 166);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(171, 23);
            txtDni.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(22, 110);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(171, 23);
            txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 23);
            txtNombre.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = SystemColors.ScrollBar;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(353, 337);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 36);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(142, 28);
            label8.Name = "label8";
            label8.Size = new Size(232, 24);
            label8.TabIndex = 12;
            label8.Text = "REGISTRAR PACIENTE";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(39, 337);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 36);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(508, 385);
            Controls.Add(btnCancelar);
            Controls.Add(label8);
            Controls.Add(groupBox1);
            Controls.Add(btnRegistrar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistrarPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += FormRegistrarPaciente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
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
        private Label label8;
        private Button btnCancelar;
    }
}