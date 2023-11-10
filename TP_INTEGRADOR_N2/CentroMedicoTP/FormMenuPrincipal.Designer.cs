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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            btnInformacion = new Button();
            btnAdmision = new Button();
            btnRegistrar = new Button();
            btnAtender = new Button();
            panelForm = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 4);
            tableLayoutPanel1.Controls.Add(btnInformacion, 0, 3);
            tableLayoutPanel1.Controls.Add(btnAdmision, 0, 0);
            tableLayoutPanel1.Controls.Add(btnRegistrar, 0, 2);
            tableLayoutPanel1.Controls.Add(btnAtender, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 253F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel1.Size = new Size(209, 512);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 448);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 6;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = true;
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
            // 
            // btnAtender
            // 
            btnAtender.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtender.Location = new Point(3, 67);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(203, 58);
            btnAtender.TabIndex = 3;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
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
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Centro Medico";
            Load += FormMenuPrincipal_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnInformacion;
        private Button btnAdmision;
        private Button btnAtender;
        private Button btnRegistrar;
        private Panel panelForm;
        private Label label1;
        private Button button1;
    }
}