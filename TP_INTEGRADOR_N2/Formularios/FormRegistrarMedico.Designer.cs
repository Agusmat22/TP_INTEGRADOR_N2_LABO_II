namespace Formularios
{
    partial class FormRegistrarMedico
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(46, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 227);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Completar informacion";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(231, 38);
            label5.Name = "label5";
            label5.Size = new Size(73, 13);
            label5.TabIndex = 6;
            label5.Text = "Nº Matricula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(22, 151);
            label4.Name = "label4";
            label4.Size = new Size(27, 13);
            label4.TabIndex = 5;
            label4.Text = "Dni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 94);
            label3.Name = "label3";
            label3.Size = new Size(53, 13);
            label3.TabIndex = 4;
            label3.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 38);
            label2.Name = "label2";
            label2.Size = new Size(52, 13);
            label2.TabIndex = 3;
            label2.Text = "Nombre:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 54);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 166);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(196, 324);
            button1.Name = "button1";
            button1.Size = new Size(116, 31);
            button1.TabIndex = 4;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 25);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 3;
            label1.Text = "REGISTRAR MEDICO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(231, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(231, 151);
            label6.Name = "label6";
            label6.Size = new Size(116, 13);
            label6.TabIndex = 12;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(231, 94);
            label7.Name = "label7";
            label7.Size = new Size(74, 13);
            label7.TabIndex = 15;
            label7.Text = "Especialidad:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(231, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 23);
            comboBox1.TabIndex = 14;
            // 
            // FormRegistrarMedico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 377);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistrarMedico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected GroupBox groupBox1;
        protected Label label5;
        protected Label label4;
        protected Label label3;
        protected Label label2;
        protected TextBox textBox4;
        protected TextBox textBox3;
        protected TextBox textBox2;
        protected TextBox textBox1;
        protected Button button1;
        protected Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
    }
}