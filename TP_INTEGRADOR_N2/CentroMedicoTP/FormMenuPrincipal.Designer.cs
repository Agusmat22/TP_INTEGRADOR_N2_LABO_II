namespace CentroMedicoTP
{
    partial class FormMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tlpBotones = new TableLayoutPanel();
            btnSalir = new Button();
            btnInformacion = new Button();
            btnAdmision = new Button();
            btnRegistrar = new Button();
            btnAtencion = new Button();
            panelForm = new Panel();
            label1 = new Label();
            tlpBotones.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // tlpBotones
            // 
            tlpBotones.BackColor = SystemColors.ActiveCaption;
            tlpBotones.ColumnCount = 1;
            tlpBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBotones.Controls.Add(btnSalir, 0, 4);
            tlpBotones.Controls.Add(btnInformacion, 0, 3);
            tlpBotones.Controls.Add(btnAdmision, 0, 0);
            tlpBotones.Controls.Add(btnRegistrar, 0, 2);
            tlpBotones.Controls.Add(btnAtencion, 0, 1);
            tlpBotones.Cursor = Cursors.Hand;
            tlpBotones.Location = new Point(3, 3);
            tlpBotones.Name = "tlpBotones";
            tlpBotones.RowCount = 5;
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 253F));
            tlpBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tlpBotones.Size = new Size(209, 512);
            tlpBotones.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Location = new Point(3, 448);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(203, 61);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnInformacion
            // 
            btnInformacion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInformacion.Location = new Point(3, 195);
            btnInformacion.Name = "btnInformacion";
            btnInformacion.Size = new Size(203, 60);
            btnInformacion.TabIndex = 5;
            btnInformacion.Text = "Informacion";
            btnInformacion.UseVisualStyleBackColor = true;
            btnInformacion.Click += btnInformacion_Click;
            // 
            // btnAdmision
            // 
            btnAdmision.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmision.Location = new Point(3, 3);
            btnAdmision.Name = "btnAdmision";
            btnAdmision.Size = new Size(203, 58);
            btnAdmision.TabIndex = 2;
            btnAdmision.Text = "Admision";
            btnAdmision.UseVisualStyleBackColor = true;
            btnAdmision.Click += btnAdmision_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.Location = new Point(3, 131);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(203, 58);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnAtencion
            // 
            btnAtencion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtencion.Location = new Point(3, 67);
            btnAtencion.Name = "btnAtencion";
            btnAtencion.Size = new Size(203, 58);
            btnAtencion.TabIndex = 3;
            btnAtencion.Text = "Atencion";
            btnAtencion.UseVisualStyleBackColor = true;
            btnAtencion.Click += btnAtencion_Click;
            // 
            // panelForm
            // 
            panelForm.Controls.Add(label1);
            panelForm.Location = new Point(215, 3);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(768, 512);
            panelForm.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(218, 65);
            label1.Name = "label1";
            label1.Size = new Size(341, 49);
            label1.TabIndex = 0;
            label1.Text = "Centro de Urgencias";
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 518);
            Controls.Add(panelForm);
            Controls.Add(tlpBotones);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Centro Medico";
            FormClosing += FormMenuPrincipal_FormClosing;
            Load += FormMenuPrincipal_Load;
            tlpBotones.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpBotones;
        private Button btnInformacion;
        private Button btnAdmision;
        private Button btnAtencion;
        private Button btnRegistrar;
        private Panel panelForm;
        private Label label1;
        private Button btnSalir;
    }
}