namespace Formularios
{
    partial class FormInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacion));
            label6 = new Label();
            lstbPacientes = new ListBox();
            label3 = new Label();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            lstbMedicos = new ListBox();
            btnImportar = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(334, 33);
            label6.Name = "label6";
            label6.Size = new Size(115, 27);
            label6.TabIndex = 27;
            label6.Text = "Registros";
            // 
            // lstbPacientes
            // 
            lstbPacientes.FormattingEnabled = true;
            lstbPacientes.ItemHeight = 15;
            lstbPacientes.Location = new Point(41, 138);
            lstbPacientes.Name = "lstbPacientes";
            lstbPacientes.Size = new Size(272, 289);
            lstbPacientes.TabIndex = 28;
            lstbPacientes.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 115);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 29;
            label3.Text = "Pacientes Totales";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.DarkSeaGreen;
            btnModificar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.Location = new Point(357, 138);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 42);
            btnModificar.TabIndex = 30;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(357, 186);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 42);
            btnEliminar.TabIndex = 31;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(548, 115);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 33;
            label1.Text = "Medicos Totales";
            // 
            // lstbMedicos
            // 
            lstbMedicos.FormattingEnabled = true;
            lstbMedicos.ItemHeight = 15;
            lstbMedicos.Location = new Point(477, 138);
            lstbMedicos.Name = "lstbMedicos";
            lstbMedicos.Size = new Size(272, 289);
            lstbMedicos.TabIndex = 32;
            // 
            // btnImportar
            // 
            btnImportar.BackColor = Color.White;
            btnImportar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportar.ImageKey = "import.png";
            btnImportar.ImageList = imageList1;
            btnImportar.Location = new Point(370, 250);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(50, 49);
            btnImportar.TabIndex = 34;
            btnImportar.UseVisualStyleBackColor = false;
            btnImportar.Click += btnImportar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "pngwing.com.png");
            imageList1.Images.SetKeyName(1, "import.png");
            // 
            // FormInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(784, 450);
            Controls.Add(btnImportar);
            Controls.Add(label1);
            Controls.Add(lstbMedicos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(label3);
            Controls.Add(lstbPacientes);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInformacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registros de pacientes";
            Load += FormInformacionPacientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private ListBox lstbPacientes;
        private Label label3;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private ListBox lstbMedicos;
        private Button btnImportar;
        private ImageList imageList1;
    }
}