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
            comboBox1 = new ComboBox();
            label1 = new Label();
            lblAtencion = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            btnAtender = new Button();
            btnHistoriaClinica = new Button();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 25);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(66, 46);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Medico";
            // 
            // lblAtencion
            // 
            lblAtencion.AutoSize = true;
            lblAtencion.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAtencion.Location = new Point(304, 9);
            lblAtencion.Name = "lblAtencion";
            lblAtencion.Size = new Size(127, 37);
            lblAtencion.TabIndex = 2;
            lblAtencion.Text = "Atencion";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(524, 97);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(216, 364);
            listBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(592, 74);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "En espera";
            // 
            // btnAtender
            // 
            btnAtender.Location = new Point(421, 97);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(81, 32);
            btnAtender.TabIndex = 5;
            btnAtender.Text = "Atender";
            btnAtender.UseVisualStyleBackColor = true;
            // 
            // btnHistoriaClinica
            // 
            btnHistoriaClinica.Location = new Point(421, 150);
            btnHistoriaClinica.Name = "btnHistoriaClinica";
            btnHistoriaClinica.Size = new Size(81, 32);
            btnHistoriaClinica.TabIndex = 6;
            btnHistoriaClinica.Text = "Hc";
            btnHistoriaClinica.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 295);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(286, 134);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 272);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 8;
            label3.Text = "Diagnostico";
            // 
            // FormAtencion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(752, 473);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(btnHistoriaClinica);
            Controls.Add(btnAtender);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(lblAtencion);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "FormAtencion";
            Text = "Medico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label lblAtencion;
        private ListBox listBox1;
        private Label label2;
        private Button btnAtender;
        private Button btnHistoriaClinica;
        private RichTextBox richTextBox1;
        private Label label3;
    }
}