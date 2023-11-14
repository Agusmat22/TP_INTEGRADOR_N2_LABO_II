namespace CentroMedicoTP
{
    partial class FormAtencion
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
            cmbMedicos = new ComboBox();
            label1 = new Label();
            lblAtencion = new Label();
            lstbpacientes = new ListBox();
            label2 = new Label();
            btnAtender = new Button();
            btnHistoriaClinica = new Button();
            rtbDiagnostico = new RichTextBox();
            label3 = new Label();
            btnVolver = new Button();
            btnDiagnosticar = new Button();
            SuspendLayout();
            // 
            // cmbMedicos
            // 
            cmbMedicos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMedicos.FormattingEnabled = true;
            cmbMedicos.Location = new Point(291, 99);
            cmbMedicos.Name = "cmbMedicos";
            cmbMedicos.Size = new Size(170, 25);
            cmbMedicos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(346, 76);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 1;
            label1.Text = "Medico";
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencion.Location = new Point(312, 9);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(127, 37);
            lblAtencion.TabIndex = 2;
            lblAtencion.Text = "Atencion";
            // 
            // lstbpacientes
            // 
            lstbpacientes.FormattingEnabled = true;
            lstbpacientes.ItemHeight = 15;
            lstbpacientes.Location = new Point(12, 184);
            lstbpacientes.Name = "lstbpacientes";
            lstbpacientes.Size = new Size(286, 199);
            lstbpacientes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 161);
            label2.Name = "label2";
            label2.Size = new Size(82, 17);
            label2.TabIndex = 4;
            label2.Text = "En espera";
            // 
            // btnAtender
            // 
            btnAtender.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtender.Location = new Point(335, 184);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(81, 32);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnHistoriaClinica
            // 
            btnHistoriaClinica.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistoriaClinica.Location = new Point(335, 237);
            btnHistoriaClinica.Name = "btnHistoriaClinica";
            btnHistoriaClinica.Size = new Size(81, 32);
            btnHistoriaClinica.TabIndex = 6;
            btnHistoriaClinica.Text = "Hc";
            btnHistoriaClinica.UseVisualStyleBackColor = true;
            // 
            // rtbDiagnostico
            // 
            rtbDiagnostico.Location = new Point(454, 184);
            rtbDiagnostico.Name = "rtbDiagnostico";
            rtbDiagnostico.Size = new Size(286, 199);
            rtbDiagnostico.TabIndex = 7;
            rtbDiagnostico.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(554, 161);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 8;
            label3.Text = "Diagnostico";
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(335, 295);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(81, 32);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnDiagnosticar
            // 
            btnDiagnosticar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiagnosticar.Location = new Point(454, 406);
            btnDiagnosticar.Name = "btnDiagnosticar";
            btnDiagnosticar.Size = new Size(286, 32);
            btnDiagnosticar.TabIndex = 10;
            btnDiagnosticar.Text = "Diagnosticar";
            btnDiagnosticar.UseVisualStyleBackColor = true;
            // 
            // FormAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(752, 473);
            Controls.Add(btnDiagnosticar);
            Controls.Add(btnVolver);
            Controls.Add(label3);
            Controls.Add(rtbDiagnostico);
            Controls.Add(btnHistoriaClinica);
            Controls.Add(btnAtender);
            Controls.Add(label2);
            Controls.Add(lstbpacientes);
            Controls.Add(lblAtencion);
            Controls.Add(label1);
            Controls.Add(cmbMedicos);
            Name = "FormAtencion";
            Text = "Medico";
            Load += FormAtencion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMedicos;
        private Label label1;
        private Label lblAtencion;
        private ListBox lstbpacientes;
        private Label label2;
        private Button btnAtender;
        private Button btnHistoriaClinica;
        private RichTextBox rtbDiagnostico;
        private Label label3;
        private Button btnVolver;
        private Button btnDiagnosticar;
    }
}