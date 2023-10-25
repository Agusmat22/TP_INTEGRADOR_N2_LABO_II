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
            label1 = new Label();
            btnCargarPaciente = new Button();
            btnIngreso = new Button();
            lstbPacientesEnEspera = new ListBox();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            cmbTipoGuardia = new ComboBox();
            menuStrip1 = new MenuStrip();
            informacionToolStripMenuItem = new ToolStripMenuItem();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            atendidosToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem = new ToolStripMenuItem();
            historiaClinicaToolStripMenuItem = new ToolStripMenuItem();
            medicosToolStripMenuItem = new ToolStripMenuItem();
            listadoToolStripMenuItem1 = new ToolStripMenuItem();
            registrarToolStripMenuItem1 = new ToolStripMenuItem();
            pacienteToolStripMenuItem1 = new ToolStripMenuItem();
            medicoToolStripMenuItem1 = new ToolStripMenuItem();
            informacionToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(570, 22);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 3;
            label1.Text = "PACIENTES EN ESPERA";
            // 
            // btnCargarPaciente
            // 
            btnCargarPaciente.BackColor = Color.ForestGreen;
            btnCargarPaciente.Cursor = Cursors.Hand;
            btnCargarPaciente.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarPaciente.Location = new Point(370, 102);
            btnCargarPaciente.Name = "btnCargarPaciente";
            btnCargarPaciente.Size = new Size(122, 39);
            btnCargarPaciente.TabIndex = 4;
            btnCargarPaciente.Text = "Egreso";
            btnCargarPaciente.UseVisualStyleBackColor = false;
            // 
            // btnIngreso
            // 
            btnIngreso.BackColor = SystemColors.ScrollBar;
            btnIngreso.Cursor = Cursors.Hand;
            btnIngreso.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngreso.Location = new Point(370, 57);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(122, 39);
            btnIngreso.TabIndex = 5;
            btnIngreso.Text = "Ingreso";
            btnIngreso.UseVisualStyleBackColor = false;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // lstbPacientesEnEspera
            // 
            lstbPacientesEnEspera.FormattingEnabled = true;
            lstbPacientesEnEspera.ItemHeight = 15;
            lstbPacientesEnEspera.Location = new Point(512, 57);
            lstbPacientesEnEspera.Name = "lstbPacientesEnEspera";
            lstbPacientesEnEspera.Size = new Size(281, 364);
            lstbPacientesEnEspera.TabIndex = 6;
            // 
            // richTextBox1
            // 
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(24, 171);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(281, 250);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(103, 139);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 8;
            label2.Text = "Sintomatologia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 42);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 9;
            label3.Text = "Tipo de guardia:";
            // 
            // cmbTipoGuardia
            // 
            cmbTipoGuardia.Cursor = Cursors.Hand;
            cmbTipoGuardia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoGuardia.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoGuardia.FormattingEnabled = true;
            cmbTipoGuardia.Location = new Point(24, 77);
            cmbTipoGuardia.Name = "cmbTipoGuardia";
            cmbTipoGuardia.Size = new Size(281, 28);
            cmbTipoGuardia.TabIndex = 10;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { informacionToolStripMenuItem, informacionToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // informacionToolStripMenuItem
            // 
            informacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, medicosToolStripMenuItem, registrarToolStripMenuItem1 });
            informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            informacionToolStripMenuItem.Size = new Size(67, 20);
            informacionToolStripMenuItem.Text = "Registros";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { atendidosToolStripMenuItem, listadoToolStripMenuItem, historiaClinicaToolStripMenuItem });
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(124, 22);
            pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // atendidosToolStripMenuItem
            // 
            atendidosToolStripMenuItem.Name = "atendidosToolStripMenuItem";
            atendidosToolStripMenuItem.Size = new Size(154, 22);
            atendidosToolStripMenuItem.Text = "Atendidos";
            // 
            // listadoToolStripMenuItem
            // 
            listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            listadoToolStripMenuItem.Size = new Size(154, 22);
            listadoToolStripMenuItem.Text = "Listado";
            // 
            // historiaClinicaToolStripMenuItem
            // 
            historiaClinicaToolStripMenuItem.Name = "historiaClinicaToolStripMenuItem";
            historiaClinicaToolStripMenuItem.Size = new Size(154, 22);
            historiaClinicaToolStripMenuItem.Text = "Historia Clinica";
            // 
            // medicosToolStripMenuItem
            // 
            medicosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listadoToolStripMenuItem1 });
            medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            medicosToolStripMenuItem.Size = new Size(124, 22);
            medicosToolStripMenuItem.Text = "Medicos";
            // 
            // listadoToolStripMenuItem1
            // 
            listadoToolStripMenuItem1.Name = "listadoToolStripMenuItem1";
            listadoToolStripMenuItem1.Size = new Size(112, 22);
            listadoToolStripMenuItem1.Text = "Listado";
            // 
            // registrarToolStripMenuItem1
            // 
            registrarToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { pacienteToolStripMenuItem1, medicoToolStripMenuItem1 });
            registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            registrarToolStripMenuItem1.Size = new Size(124, 22);
            registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // pacienteToolStripMenuItem1
            // 
            pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            pacienteToolStripMenuItem1.Size = new Size(119, 22);
            pacienteToolStripMenuItem1.Text = "Paciente";
            pacienteToolStripMenuItem1.Click += pacienteToolStripMenuItem1_Click;
            // 
            // medicoToolStripMenuItem1
            // 
            medicoToolStripMenuItem1.Name = "medicoToolStripMenuItem1";
            medicoToolStripMenuItem1.Size = new Size(119, 22);
            medicoToolStripMenuItem1.Text = "Medico";
            medicoToolStripMenuItem1.Click += medicoToolStripMenuItem1_Click;
            // 
            // informacionToolStripMenuItem1
            // 
            informacionToolStripMenuItem1.Name = "informacionToolStripMenuItem1";
            informacionToolStripMenuItem1.Size = new Size(84, 20);
            informacionToolStripMenuItem1.Text = "Informacion";
            // 
            // FormAdmision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 440);
            Controls.Add(cmbTipoGuardia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(lstbPacientesEnEspera);
            Controls.Add(btnIngreso);
            Controls.Add(btnCargarPaciente);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdmision";
            Text = "Admision";
            Load += FormAdmision_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnCargarPaciente;
        private Button btnIngreso;
        private ListBox lstbPacientesEnEspera;
        private RichTextBox richTextBox1;
        private Label label2;
        private Label label3;
        private ComboBox cmbTipoGuardia;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem informacionToolStripMenuItem;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem medicosToolStripMenuItem;
        private ToolStripMenuItem registrarToolStripMenuItem1;
        private ToolStripMenuItem pacienteToolStripMenuItem1;
        private ToolStripMenuItem medicoToolStripMenuItem1;
        private ToolStripMenuItem informacionToolStripMenuItem1;
        private ToolStripMenuItem atendidosToolStripMenuItem;
        private ToolStripMenuItem listadoToolStripMenuItem;
        private ToolStripMenuItem listadoToolStripMenuItem1;
        private ToolStripMenuItem historiaClinicaToolStripMenuItem;
    }
}