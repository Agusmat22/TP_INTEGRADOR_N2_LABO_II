namespace CentroMedicoTP
{
    partial class FormHistoriaClinica
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
            rtbHistoriaClinica = new RichTextBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // rtbHistoriaClinica
            // 
            rtbHistoriaClinica.Location = new Point(4, 3);
            rtbHistoriaClinica.Name = "rtbHistoriaClinica";
            rtbHistoriaClinica.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            rtbHistoriaClinica.Size = new Size(634, 474);
            rtbHistoriaClinica.TabIndex = 0;
            rtbHistoriaClinica.Text = "";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(267, 508);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(107, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormHistoriaClinica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 554);
            Controls.Add(btnCerrar);
            Controls.Add(rtbHistoriaClinica);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "FormHistoriaClinica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormHistoriaClinica";
            Load += FormHistoriaClinica_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbHistoriaClinica;
        private Button btnCerrar;
    }
}