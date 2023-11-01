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
            menuStrip1 = new MenuStrip();
            informacionToolStripMenu = new ToolStripMenuItem();
            pacientesToolStripMenu = new ToolStripMenuItem();
            atendidosToolStrip = new ToolStripMenuItem();
            listadoPacienteToolStrip = new ToolStripMenuItem();
            historiaClinicaToolStrip = new ToolStripMenuItem();
            medicosToolStrip = new ToolStripMenuItem();
            listadoMedicoToolStrip = new ToolStripMenuItem();
            registrarToolStripMenu = new ToolStripMenuItem();
            registrarPacienteToolStrip = new ToolStripMenuItem();
            registrarMedicoToolStrip = new ToolStripMenuItem();
            informacionToolStrip = new ToolStripMenuItem();
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
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { informacionToolStripMenu, informacionToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // informacionToolStripMenu
            // 
            informacionToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { pacientesToolStripMenu, medicosToolStrip, registrarToolStripMenu });
            informacionToolStripMenu.Name = "informacionToolStripMenu";
            informacionToolStripMenu.Size = new Size(67, 20);
            informacionToolStripMenu.Text = "Registros";
            // 
            // pacientesToolStripMenu
            // 
            pacientesToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { atendidosToolStrip, listadoPacienteToolStrip, historiaClinicaToolStrip });
            pacientesToolStripMenu.Name = "pacientesToolStripMenu";
            pacientesToolStripMenu.Size = new Size(124, 22);
            pacientesToolStripMenu.Text = "Pacientes";
            // 
            // atendidosToolStrip
            // 
            atendidosToolStrip.Name = "atendidosToolStrip";
            atendidosToolStrip.Size = new Size(154, 22);
            atendidosToolStrip.Text = "Atendidos";
            // 
            // listadoPacienteToolStrip
            // 
            listadoPacienteToolStrip.Name = "listadoPacienteToolStrip";
            listadoPacienteToolStrip.Size = new Size(154, 22);
            listadoPacienteToolStrip.Text = "Listado";
            // 
            // historiaClinicaToolStrip
            // 
            historiaClinicaToolStrip.Name = "historiaClinicaToolStrip";
            historiaClinicaToolStrip.Size = new Size(154, 22);
            historiaClinicaToolStrip.Text = "Historia Clinica";
            // 
            // medicosToolStrip
            // 
            medicosToolStrip.DropDownItems.AddRange(new ToolStripItem[] { listadoMedicoToolStrip });
            medicosToolStrip.Name = "medicosToolStrip";
            medicosToolStrip.Size = new Size(124, 22);
            medicosToolStrip.Text = "Medicos";
            // 
            // listadoMedicoToolStrip
            // 
            listadoMedicoToolStrip.Name = "listadoMedicoToolStrip";
            listadoMedicoToolStrip.Size = new Size(112, 22);
            listadoMedicoToolStrip.Text = "Listado";
            // 
            // registrarToolStripMenu
            // 
            registrarToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { registrarPacienteToolStrip, registrarMedicoToolStrip });
            registrarToolStripMenu.Name = "registrarToolStripMenu";
            registrarToolStripMenu.Size = new Size(124, 22);
            registrarToolStripMenu.Text = "Registrar";
            // 
            // registrarPacienteToolStrip
            // 
            registrarPacienteToolStrip.Name = "registrarPacienteToolStrip";
            registrarPacienteToolStrip.Size = new Size(119, 22);
            registrarPacienteToolStrip.Text = "Paciente";
            registrarPacienteToolStrip.Click += RegistrarPacienteToolStrip_Click;
            // 
            // registrarMedicoToolStrip
            // 
            registrarMedicoToolStrip.Name = "registrarMedicoToolStrip";
            registrarMedicoToolStrip.Size = new Size(119, 22);
            registrarMedicoToolStrip.Text = "Medico";
            registrarMedicoToolStrip.Click += RegistrarMedicoToolStrip_Click;
            // 
            // informacionToolStrip
            // 
            informacionToolStrip.Name = "informacionToolStrip";
            informacionToolStrip.Size = new Size(84, 20);
            informacionToolStrip.Text = "Informacion";
            // 
            // FormAdmision
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 440);
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem informacionToolStripMenu;
        private ToolStripMenuItem pacientesToolStripMenu;
        private ToolStripMenuItem medicosToolStrip;
        private ToolStripMenuItem registrarToolStripMenu;
        private ToolStripMenuItem registrarPacienteToolStrip;
        private ToolStripMenuItem registrarMedicoToolStrip;
        private ToolStripMenuItem informacionToolStrip;
        private ToolStripMenuItem atendidosToolStrip;
        private ToolStripMenuItem listadoPacienteToolStrip;
        private ToolStripMenuItem listadoMedicoToolStrip;
        private ToolStripMenuItem historiaClinicaToolStrip;
    }
}