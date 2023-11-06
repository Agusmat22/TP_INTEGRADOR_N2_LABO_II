namespace Formularios
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
            lstbPacientesEnEspera = new ListBox();
            btnIngreso = new Button();
            label1 = new Label();
            label2 = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lstbPacientesEnEspera
            // 
            lstbPacientesEnEspera.FormattingEnabled = true;
            lstbPacientesEnEspera.ItemHeight = 15;
            lstbPacientesEnEspera.Location = new Point(152, 108);
            lstbPacientesEnEspera.Name = "lstbPacientesEnEspera";
            lstbPacientesEnEspera.Size = new Size(281, 364);
            lstbPacientesEnEspera.TabIndex = 10;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = SystemColors.ScrollBar;
            btnIngreso.Cursor = Cursors.Hand;
            btnIngreso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngreso.Location = new Point(10, 108);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(122, 39);
            btnIngreso.TabIndex = 9;
            btnIngreso.Text = "Ingreso";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(217, 86);
            label1.Name = "label1";
            label1.Size = new Size(153, 19);
            label1.TabIndex = 7;
            label1.Text = "PACIENTES EN ESPERA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(152, 19);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 11;
            label2.Text = "ADMISION";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = SystemColors.Control;
            btnVolver.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.Location = new Point(10, 170);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(122, 39);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // FormAdmision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(445, 489);
            Controls.Add(btnVolver);
            Controls.Add(label2);
            Controls.Add(lstbPacientesEnEspera);
            Controls.Add(btnIngreso);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdmision";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admision";
            Load += FormAdmision_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstbPacientesEnEspera;
        private Button btnIngreso;
        private Label label1;
        private Label label2;
        private Button btnVolver;
    }
}