namespace Formularios
{
    partial class FormIngresoPaciente
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
            cmbTipoGuardia = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            rtbSintomas = new RichTextBox();
            txtDatosBusqueda = new TextBox();
            grbPaciente = new GroupBox();
            btnBuscar = new Button();
            label5 = new Label();
            label4 = new Label();
            rdbDni = new RadioButton();
            rdbAfiliado = new RadioButton();
            txtAfiliadoEncontrado = new TextBox();
            label1 = new Label();
            btnIngresar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            grbPaciente.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTipoGuardia
            // 
            cmbTipoGuardia.Cursor = Cursors.Hand;
            cmbTipoGuardia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoGuardia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoGuardia.FormattingEnabled = true;
            cmbTipoGuardia.Location = new Point(51, 273);
            cmbTipoGuardia.Name = "cmbTipoGuardia";
            cmbTipoGuardia.Size = new Size(257, 23);
            cmbTipoGuardia.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 251);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 13;
            label3.Text = "Tipo de guardia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(127, 310);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 12;
            label2.Text = "Sintomatologia:";
            // 
            // rtbSintomas
            // 
            rtbSintomas.Cursor = Cursors.IBeam;
            rtbSintomas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbSintomas.Location = new Point(51, 332);
            rtbSintomas.Name = "rtbSintomas";
            rtbSintomas.Size = new Size(257, 195);
            rtbSintomas.TabIndex = 11;
            rtbSintomas.Text = "";
            // 
            // txtDatosBusqueda
            // 
            txtDatosBusqueda.Location = new Point(18, 75);
            txtDatosBusqueda.Name = "txtDatosBusqueda";
            txtDatosBusqueda.PlaceholderText = "Completar";
            txtDatosBusqueda.Size = new Size(223, 23);
            txtDatosBusqueda.TabIndex = 15;
            // 
            // grbPaciente
            // 
            grbPaciente.Controls.Add(btnBuscar);
            grbPaciente.Controls.Add(label5);
            grbPaciente.Controls.Add(label4);
            grbPaciente.Controls.Add(rdbDni);
            grbPaciente.Controls.Add(rdbAfiliado);
            grbPaciente.Controls.Add(txtAfiliadoEncontrado);
            grbPaciente.Controls.Add(label1);
            grbPaciente.Controls.Add(txtDatosBusqueda);
            grbPaciente.Location = new Point(51, 70);
            grbPaciente.Name = "grbPaciente";
            grbPaciente.Size = new Size(257, 178);
            grbPaciente.TabIndex = 16;
            grbPaciente.TabStop = false;
            grbPaciente.Text = "Buscar Paciente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(89, 104);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 24);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(170, 25);
            label5.Name = "label5";
            label5.Size = new Size(26, 13);
            label5.TabIndex = 22;
            label5.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 25);
            label4.Name = "label4";
            label4.Size = new Size(71, 13);
            label4.TabIndex = 21;
            label4.Text = "Nº AFILIADO";
            // 
            // rdbDni
            // 
            rdbDni.AutoSize = true;
            rdbDni.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbDni.Location = new Point(179, 41);
            rdbDni.Name = "rdbDni";
            rdbDni.Size = new Size(14, 13);
            rdbDni.TabIndex = 20;
            rdbDni.TabStop = true;
            rdbDni.UseVisualStyleBackColor = true;
            // 
            // rdbAfiliado
            // 
            rdbAfiliado.AutoSize = true;
            rdbAfiliado.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbAfiliado.Location = new Point(59, 41);
            rdbAfiliado.Name = "rdbAfiliado";
            rdbAfiliado.Size = new Size(14, 13);
            rdbAfiliado.TabIndex = 19;
            rdbAfiliado.TabStop = true;
            rdbAfiliado.UseVisualStyleBackColor = true;
            // 
            // txtAfiliadoEncontrado
            // 
            txtAfiliadoEncontrado.Location = new Point(18, 142);
            txtAfiliadoEncontrado.Name = "txtAfiliadoEncontrado";
            txtAfiliadoEncontrado.PlaceholderText = "Mostrara el afiliado encontrado";
            txtAfiliadoEncontrado.Size = new Size(223, 23);
            txtAfiliadoEncontrado.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 17;
            label1.Text = "Datos:";
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ScrollBar;
            btnIngresar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(204, 547);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(104, 39);
            btnIngresar.TabIndex = 24;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.Control;
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(51, 547);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 39);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(97, 19);
            label6.Name = "label6";
            label6.Size = new Size(160, 23);
            label6.TabIndex = 26;
            label6.Text = "Cargar Paciente";
            // 
            // FormIngresoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(360, 606);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(grbPaciente);
            Controls.Add(cmbTipoGuardia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rtbSintomas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormIngresoPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de paciente";
            Load += FormIngresoPaciente_Load;
            grbPaciente.ResumeLayout(false);
            grbPaciente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoGuardia;
        private Label label3;
        private Label label2;
        private RichTextBox rtbSintomas;
        private TextBox txtDatosBusqueda;
        private GroupBox grbPaciente;
        private TextBox txtAfiliadoEncontrado;
        private Label label1;
        private Label label5;
        private Label label4;
        private RadioButton rdbDni;
        private RadioButton rdbAfiliado;
        private Button btnBuscar;
        private Button btnIngresar;
        private Button btnCancelar;
        private Label label6;
    }
}