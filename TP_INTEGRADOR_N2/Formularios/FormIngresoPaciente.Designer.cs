namespace Formularios
{
    partial class FormIngresoPaciente
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
            cmbTipoGuardia = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            btnBuscar = new Button();
            label5 = new Label();
            label4 = new Label();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTipoGuardia
            // 
            cmbTipoGuardia.Cursor = Cursors.Hand;
            cmbTipoGuardia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoGuardia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTipoGuardia.FormattingEnabled = true;
            cmbTipoGuardia.Location = new Point(51, 258);
            cmbTipoGuardia.Name = "cmbTipoGuardia";
            cmbTipoGuardia.Size = new Size(257, 23);
            cmbTipoGuardia.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(127, 236);
            label3.Name = "label3";
            label3.Size = new Size(107, 19);
            label3.TabIndex = 13;
            label3.Text = "Tipo de guardia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(127, 295);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 12;
            label2.Text = "Sintomatologia:";
            // 
            // richTextBox1
            // 
            richTextBox1.Cursor = Cursors.IBeam;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(51, 317);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(257, 195);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(18, 75);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Completar";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(51, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 178);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar Paciente";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(89, 104);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 24);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(170, 25);
            label5.Name = "label5";
            label5.Size = new Size(26, 13);
            label5.TabIndex = 22;
            label5.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 25);
            label4.Name = "label4";
            label4.Size = new Size(71, 13);
            label4.TabIndex = 21;
            label4.Text = "Nº AFILIADO";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton3.Location = new Point(179, 41);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 20;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(59, 41);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 142);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Mostrara el afiliado encontrado";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 17;
            label1.Text = "Datos:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(204, 532);
            button1.Name = "button1";
            button1.Size = new Size(104, 39);
            button1.TabIndex = 24;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancelar.Location = new Point(51, 532);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 39);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(101, 9);
            label6.Name = "label6";
            label6.Size = new Size(146, 25);
            label6.TabIndex = 26;
            label6.Text = "Cargar Paciente";
            // 
            // FormIngresoPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 588);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(cmbTipoGuardia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIngresoPaciente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso de paciente";
            Load += FormIngresoPaciente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoGuardia;
        private Label label3;
        private Label label2;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label5;
        private Label label4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button btnBuscar;
        private Button button1;
        private Button btnCancelar;
        private Label label6;
    }
}