namespace Formularios
{
    partial class FormAdmision
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
            menuStrip1 = new MenuStrip();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            medicoToolStripMenuItem = new ToolStripMenuItem();
            pacienteToolStripMenuItem = new ToolStripMenuItem();
            lstbPacientesEspera = new ListBox();
            label1 = new Label();
            btnCargarPaciente = new Button();
            button1 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            informacionToolStripMenuItem = new ToolStripMenuItem();
            historialToolStripMenuItem = new ToolStripMenuItem();
            pacientesAtendidosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, informacionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(835, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { medicoToolStripMenuItem, pacienteToolStripMenuItem });
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(65, 20);
            registrarToolStripMenuItem.Text = "Registrar";
            // 
            // medicoToolStripMenuItem
            // 
            medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            medicoToolStripMenuItem.Size = new Size(180, 22);
            medicoToolStripMenuItem.Text = "Medico";
            medicoToolStripMenuItem.Click += medicoToolStripMenuItem_Click;
            // 
            // pacienteToolStripMenuItem
            // 
            pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            pacienteToolStripMenuItem.Size = new Size(180, 22);
            pacienteToolStripMenuItem.Text = "Paciente";
            pacienteToolStripMenuItem.Click += pacienteToolStripMenuItem_Click;
            // 
            // lstbPacientesEspera
            // 
            lstbPacientesEspera.FormattingEnabled = true;
            lstbPacientesEspera.ItemHeight = 15;
            lstbPacientesEspera.Location = new Point(31, 120);
            lstbPacientesEspera.Name = "lstbPacientesEspera";
            lstbPacientesEspera.Size = new Size(293, 334);
            lstbPacientesEspera.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(100, 86);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 3;
            label1.Text = "PACIENTES EN ESPERA";
            // 
            // btnCargarPaciente
            // 
            btnCargarPaciente.BackColor = Color.ForestGreen;
            btnCargarPaciente.FlatStyle = FlatStyle.Flat;
            btnCargarPaciente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarPaciente.Location = new Point(430, 43);
            btnCargarPaciente.Name = "btnCargarPaciente";
            btnCargarPaciente.Size = new Size(122, 36);
            btnCargarPaciente.TabIndex = 4;
            btnCargarPaciente.Text = "Egreso";
            btnCargarPaciente.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(285, 43);
            button1.Name = "button1";
            button1.Size = new Size(122, 36);
            button1.TabIndex = 5;
            button1.Text = "Ingreso";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.ForestGreen;
            label2.Location = new Point(587, 86);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 7;
            label2.Text = "PACIENTES ATENDIDOS";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(515, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(293, 334);
            listBox1.TabIndex = 6;
            // 
            // informacionToolStripMenuItem
            // 
            informacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialToolStripMenuItem });
            informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            informacionToolStripMenuItem.Size = new Size(84, 20);
            informacionToolStripMenuItem.Text = "Informacion";
            // 
            // historialToolStripMenuItem
            // 
            historialToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesAtendidosToolStripMenuItem });
            historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            historialToolStripMenuItem.Size = new Size(180, 22);
            historialToolStripMenuItem.Text = "Historial";
            // 
            // pacientesAtendidosToolStripMenuItem
            // 
            pacientesAtendidosToolStripMenuItem.Name = "pacientesAtendidosToolStripMenuItem";
            pacientesAtendidosToolStripMenuItem.Size = new Size(181, 22);
            pacientesAtendidosToolStripMenuItem.Text = "Pacientes Atendidos";
            // 
            // FormAdmision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 475);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(btnCargarPaciente);
            Controls.Add(label1);
            Controls.Add(lstbPacientesEspera);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdmision";
            Text = "Admision";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private ToolStripMenuItem medicoToolStripMenuItem;
        private ToolStripMenuItem pacienteToolStripMenuItem;
        private ListBox lstbPacientesEspera;
        private Label label1;
        private Button btnCargarPaciente;
        private Button button1;
        private Label label2;
        private ListBox listBox1;
        private ToolStripMenuItem informacionToolStripMenuItem;
        private ToolStripMenuItem historialToolStripMenuItem;
        private ToolStripMenuItem pacientesAtendidosToolStripMenuItem;
    }
}