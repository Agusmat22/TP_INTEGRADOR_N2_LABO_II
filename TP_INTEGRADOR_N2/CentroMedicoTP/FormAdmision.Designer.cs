namespace CentroMedicoTP
{
    partial class FormAdmision
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmision));
            lstbPacientesEnEspera = new ListBox();
            btnDesbloquear = new Button();
            imageList1 = new ImageList(components);
            label1 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            label6 = new Label();
            grbBuscarPaciente = new GroupBox();
            rdbNumAfiliado = new RadioButton();
            btnBuscar = new Button();
            label5 = new Label();
            label4 = new Label();
            rdbDni = new RadioButton();
            txtAfiliadoEncontrado = new TextBox();
            label3 = new Label();
            txtDatosBusqueda = new TextBox();
            grpCargarPaciente = new GroupBox();
            btnIngresar = new Button();
            grbBuscarPaciente.SuspendLayout();
            grpCargarPaciente.SuspendLayout();
            SuspendLayout();
            // 
            // lstbPacientesEnEspera
            // 
            lstbPacientesEnEspera.FormattingEnabled = true;
            lstbPacientesEnEspera.ItemHeight = 15;
            lstbPacientesEnEspera.Location = new Point(27, 51);
            lstbPacientesEnEspera.Name = "lstbPacientesEnEspera";
            lstbPacientesEnEspera.Size = new Size(251, 349);
            lstbPacientesEnEspera.TabIndex = 10;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.BackColor = SystemColors.Control;
            btnDesbloquear.Cursor = Cursors.Hand;
            btnDesbloquear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDesbloquear.ImageIndex = 0;
            btnDesbloquear.ImageList = imageList1;
            btnDesbloquear.Location = new Point(186, 418);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(92, 43);
            btnDesbloquear.TabIndex = 9;
            btnDesbloquear.UseVisualStyleBackColor = false;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "candadoCerrado.png");
            imageList1.Images.SetKeyName(1, "candadoAbierto.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(82, 30);
            label1.Name = "label1";
            label1.Size = new Size(129, 15);
            label1.TabIndex = 7;
            label1.Text = "PACIENTES EN ESPERA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(321, 9);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 11;
            label2.Text = "ADMISION";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Control;
            btnVolver.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(27, 418);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 43);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(524, 81);
            label6.Name = "label6";
            label6.Size = new Size(119, 16);
            label6.TabIndex = 30;
            label6.Text = "Ingresar Paciente";
            // 
            // grbBuscarPaciente
            // 
            grbBuscarPaciente.Controls.Add(rdbNumAfiliado);
            grbBuscarPaciente.Controls.Add(btnBuscar);
            grbBuscarPaciente.Controls.Add(label5);
            grbBuscarPaciente.Controls.Add(label4);
            grbBuscarPaciente.Controls.Add(rdbDni);
            grbBuscarPaciente.Controls.Add(txtAfiliadoEncontrado);
            grbBuscarPaciente.Controls.Add(label3);
            grbBuscarPaciente.Controls.Add(txtDatosBusqueda);
            grbBuscarPaciente.Location = new Point(19, 22);
            grbBuscarPaciente.Name = "grbBuscarPaciente";
            grbBuscarPaciente.Size = new Size(257, 178);
            grbBuscarPaciente.TabIndex = 29;
            grbBuscarPaciente.TabStop = false;
            grbBuscarPaciente.Text = "Buscar Paciente";
            // 
            // rdbNumAfiliado
            // 
            rdbNumAfiliado.AutoSize = true;
            rdbNumAfiliado.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            rdbNumAfiliado.Location = new Point(59, 41);
            rdbNumAfiliado.Name = "rdbNumAfiliado";
            rdbNumAfiliado.Size = new Size(14, 13);
            rdbNumAfiliado.TabIndex = 24;
            rdbNumAfiliado.TabStop = true;
            rdbNumAfiliado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(89, 104);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 24);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
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
            // txtAfiliadoEncontrado
            // 
            txtAfiliadoEncontrado.Location = new Point(18, 142);
            txtAfiliadoEncontrado.Name = "txtAfiliadoEncontrado";
            txtAfiliadoEncontrado.PlaceholderText = "Mostrara el afiliado encontrado";
            txtAfiliadoEncontrado.ReadOnly = true;
            txtAfiliadoEncontrado.Size = new Size(223, 23);
            txtAfiliadoEncontrado.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 57);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 17;
            label3.Text = "Datos:";
            // 
            // txtDatosBusqueda
            // 
            txtDatosBusqueda.Location = new Point(18, 75);
            txtDatosBusqueda.Name = "txtDatosBusqueda";
            txtDatosBusqueda.PlaceholderText = "Completar";
            txtDatosBusqueda.Size = new Size(223, 23);
            txtDatosBusqueda.TabIndex = 15;
            // 
            // grpCargarPaciente
            // 
            grpCargarPaciente.BackColor = SystemColors.GradientInactiveCaption;
            grpCargarPaciente.Controls.Add(btnIngresar);
            grpCargarPaciente.Controls.Add(grbBuscarPaciente);
            grpCargarPaciente.Location = new Point(430, 100);
            grpCargarPaciente.Name = "grpCargarPaciente";
            grpCargarPaciente.Size = new Size(308, 269);
            grpCargarPaciente.TabIndex = 31;
            grpCargarPaciente.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = SystemColors.ScrollBar;
            btnIngresar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(19, 215);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(260, 30);
            btnIngresar.TabIndex = 32;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // FormAdmision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(752, 473);
            Controls.Add(grpCargarPaciente);
            Controls.Add(label6);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(lstbPacientesEnEspera);
            Controls.Add(btnDesbloquear);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdmision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admision";
            Load += FormAdmision_Load;
            grbBuscarPaciente.ResumeLayout(false);
            grbBuscarPaciente.PerformLayout();
            grpCargarPaciente.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbPacientesEnEspera;
        private Button btnDesbloquear;
        private Label label1;
        private Label label2;
        private Button btnVolver;
        private Label label6;
        private GroupBox grbBuscarPaciente;
        private Button btnBuscar;
        private Label label5;
        private Label label4;
        private RadioButton rdbDni;
        private TextBox txtAfiliadoEncontrado;
        private Label label3;
        private TextBox txtDatosBusqueda;
        private GroupBox grpCargarPaciente;
        private Button btnIngresar;
        private ImageList imageList1;
        private RadioButton rdbNumAfiliado;
    }
}