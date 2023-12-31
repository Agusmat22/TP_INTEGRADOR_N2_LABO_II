﻿namespace CentroMedicoTP
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
            btnExportar = new Button();
            imageList1 = new ImageList(components);
            label1 = new Label();
            lstbMedicos = new ListBox();
            btnEliminar = new Button();
            label3 = new Label();
            lstbPacientes = new ListBox();
            label6 = new Label();
            btnImportar = new Button();
            toolTip = new ToolTip(components);
            btnVolver = new Button();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.White;
            btnExportar.Cursor = Cursors.Hand;
            btnExportar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExportar.ImageIndex = 0;
            btnExportar.ImageList = imageList1;
            btnExportar.Location = new Point(346, 240);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(50, 49);
            btnExportar.TabIndex = 42;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "import.png");
            imageList1.Images.SetKeyName(1, "importar.png");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(529, 121);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 41;
            label1.Text = "Medicos Totales";
            // 
            // lstbMedicos
            // 
            lstbMedicos.FormattingEnabled = true;
            lstbMedicos.ItemHeight = 15;
            lstbMedicos.Location = new Point(458, 144);
            lstbMedicos.Name = "lstbMedicos";
            lstbMedicos.Size = new Size(272, 289);
            lstbMedicos.TabIndex = 40;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.Location = new Point(335, 192);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 42);
            btnEliminar.TabIndex = 39;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 121);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 37;
            label3.Text = "Pacientes Totales";
            // 
            // lstbPacientes
            // 
            lstbPacientes.FormattingEnabled = true;
            lstbPacientes.ItemHeight = 15;
            lstbPacientes.Location = new Point(22, 144);
            lstbPacientes.Name = "lstbPacientes";
            lstbPacientes.Size = new Size(272, 289);
            lstbPacientes.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.Fixed3D;
            label6.Font = new Font("Arial", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(315, 39);
            label6.Name = "label6";
            label6.Size = new Size(115, 27);
            label6.TabIndex = 35;
            label6.Text = "Registros";
            // 
            // btnImportar
            // 
            btnImportar.BackColor = Color.White;
            btnImportar.Cursor = Cursors.Hand;
            btnImportar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnImportar.ImageIndex = 1;
            btnImportar.ImageList = imageList1;
            btnImportar.Location = new Point(346, 295);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(50, 49);
            btnImportar.TabIndex = 43;
            btnImportar.UseVisualStyleBackColor = false;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Gainsboro;
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(335, 144);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 42);
            btnVolver.TabIndex = 44;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormInformacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(752, 473);
            Controls.Add(btnVolver);
            Controls.Add(btnImportar);
            Controls.Add(btnExportar);
            Controls.Add(label1);
            Controls.Add(lstbMedicos);
            Controls.Add(btnEliminar);
            Controls.Add(label3);
            Controls.Add(lstbPacientes);
            Controls.Add(label6);
            Name = "FormInformacion";
            Text = "Informacion";
            Load += FormInformacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportar;
        private Label label1;
        private ListBox lstbMedicos;
        private Button btnEliminar;
        private Label label3;
        private ListBox lstbPacientes;
        private Label label6;
        private ImageList imageList1;
        private Button btnImportar;
        private ToolTip toolTip;
        private Button btnVolver;
    }
}