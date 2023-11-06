namespace Formularios
{
    partial class FormRegistrarMedico
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
            label7 = new Label();
            cmbEspecialidad = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtMatricula = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            label1 = new Label();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbEspecialidad);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtMatricula);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(46, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 227);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Completar informacion";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(231, 94);
            label7.Name = "label7";
            label7.Size = new Size(74, 13);
            label7.TabIndex = 15;
            label7.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(231, 110);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(171, 23);
            cmbEspecialidad.TabIndex = 14;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(231, 167);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(171, 23);
            dtpFechaNacimiento.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(231, 151);
            label6.Name = "label6";
            label6.Size = new Size(116, 13);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(231, 38);
            label5.Name = "label5";
            label5.Size = new Size(73, 13);
            label5.TabIndex = 6;
            label5.Text = "Nº Matricula:";
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
            // txtMatricula
            // 
            txtMatricula.Location = new Point(231, 54);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(171, 23);
            txtMatricula.TabIndex = 3;
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
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(360, 331);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(116, 34);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(171, 32);
            label1.Name = "label1";
            label1.Size = new Size(180, 19);
            label1.TabIndex = 3;
            label1.Text = "REGISTRAR MEDICO";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(46, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormRegistrarMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(514, 377);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistrarMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected GroupBox groupBox1;
        protected Label label5;
        protected Label label4;
        protected Label label3;
        protected Label label2;
        protected TextBox txtMatricula;
        protected TextBox txtDni;
        protected TextBox txtApellido;
        protected TextBox txtNombre;
        protected Button btnRegistrar;
        protected Label label1;
        private DateTimePicker dtpFechaNacimiento;
        private Label label6;
        private Label label7;
        private ComboBox cmbEspecialidad;
        protected Button btnCancelar;
    }
}