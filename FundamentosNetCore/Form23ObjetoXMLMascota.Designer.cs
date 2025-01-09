namespace FundamentosNetCore
{
    partial class Form23ObjetoXMLMascota
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
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtRaza = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            btnLeerDato = new Button();
            btnGuardarDato = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(27, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 80);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(27, 98);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 140);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 4;
            label3.Text = "Años";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(27, 158);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 5;
            // 
            // btnLeerDato
            // 
            btnLeerDato.Location = new Point(180, 42);
            btnLeerDato.Name = "btnLeerDato";
            btnLeerDato.Size = new Size(90, 41);
            btnLeerDato.TabIndex = 6;
            btnLeerDato.Text = "Leer dato";
            btnLeerDato.UseVisualStyleBackColor = true;
            btnLeerDato.Click += btnLeerDato_Click;
            // 
            // btnGuardarDato
            // 
            btnGuardarDato.Location = new Point(180, 98);
            btnGuardarDato.Name = "btnGuardarDato";
            btnGuardarDato.Size = new Size(90, 40);
            btnGuardarDato.TabIndex = 7;
            btnGuardarDato.Text = "Guardar dato";
            btnGuardarDato.UseVisualStyleBackColor = true;
            btnGuardarDato.Click += btnGuardarDato_Click;
            // 
            // Form23ObjetoXMLMascota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 221);
            Controls.Add(btnGuardarDato);
            Controls.Add(btnLeerDato);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "Form23ObjetoXMLMascota";
            Text = "Form23ObjetoXMLMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private TextBox txtRaza;
        private Label label3;
        private TextBox txtEdad;
        private Button btnLeerDato;
        private Button btnGuardarDato;
    }
}