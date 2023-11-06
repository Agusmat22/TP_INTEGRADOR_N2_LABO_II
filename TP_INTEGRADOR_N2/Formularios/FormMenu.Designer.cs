namespace Formularios
{
    partial class FormMenu
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
            admisionToolStrip = new ToolStripMenuItem();
            informacionToolStripMenu = new ToolStripMenuItem();
            registrarToolStripMenu = new ToolStripMenuItem();
            registrarPacienteToolStrip = new ToolStripMenuItem();
            registrarMedicoToolStrip = new ToolStripMenuItem();
            informacionToolStrip = new ToolStripMenuItem();
            label1 = new Label();
            informacionToolStripMen = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { admisionToolStrip, informacionToolStripMenu, informacionToolStrip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(814, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // admisionToolStrip
            // 
            admisionToolStrip.Name = "admisionToolStrip";
            admisionToolStrip.Size = new Size(70, 20);
            admisionToolStrip.Text = "Admision";
            admisionToolStrip.Click += admisionToolStrip_Click;
            // 
            // informacionToolStripMenu
            // 
            informacionToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { informacionToolStripMen, registrarToolStripMenu });
            informacionToolStripMenu.Name = "informacionToolStripMenu";
            informacionToolStripMenu.Size = new Size(67, 20);
            informacionToolStripMenu.Text = "Registros";
            // 
            // registrarToolStripMenu
            // 
            registrarToolStripMenu.DropDownItems.AddRange(new ToolStripItem[] { registrarPacienteToolStrip, registrarMedicoToolStrip });
            registrarToolStripMenu.Name = "registrarToolStripMenu";
            registrarToolStripMenu.Size = new Size(180, 22);
            registrarToolStripMenu.Text = "Registrar";
            // 
            // registrarPacienteToolStrip
            // 
            registrarPacienteToolStrip.Name = "registrarPacienteToolStrip";
            registrarPacienteToolStrip.Size = new Size(180, 22);
            registrarPacienteToolStrip.Text = "Paciente";
            registrarPacienteToolStrip.Click += RegistrarPacienteToolStrip_Click;
            // 
            // registrarMedicoToolStrip
            // 
            registrarMedicoToolStrip.Name = "registrarMedicoToolStrip";
            registrarMedicoToolStrip.Size = new Size(180, 22);
            registrarMedicoToolStrip.Text = "Medico";
            registrarMedicoToolStrip.Click += RegistrarMedicoToolStrip_Click;
            // 
            // informacionToolStrip
            // 
            informacionToolStrip.Name = "informacionToolStrip";
            informacionToolStrip.Size = new Size(84, 20);
            informacionToolStrip.Text = "Informacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientActiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Arial", 33F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Ivory;
            label1.Location = new Point(196, 72);
            label1.Name = "label1";
            label1.Size = new Size(416, 52);
            label1.TabIndex = 12;
            label1.Text = "Urgencias Medicas";
            // 
            // informacionToolStripMen
            // 
            informacionToolStripMen.Name = "informacionToolStripMen";
            informacionToolStripMen.Size = new Size(180, 22);
            informacionToolStripMen.Text = "Informacion";
            informacionToolStripMen.Click += informacionToolStripMen_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(814, 440);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += FormAdmision_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem informacionToolStripMenu;
        private ToolStripMenuItem registrarToolStripMenu;
        private ToolStripMenuItem registrarPacienteToolStrip;
        private ToolStripMenuItem registrarMedicoToolStrip;
        private ToolStripMenuItem informacionToolStrip;
        private Label label1;
        private ToolStripMenuItem admisionToolStrip;
        private ToolStripMenuItem informacionToolStripMen;
    }
}