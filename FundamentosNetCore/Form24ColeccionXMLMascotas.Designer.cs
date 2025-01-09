namespace FundamentosNetCore
{
    partial class Form24ColeccionXMLMascotas
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
            lstMascotas = new ListBox();
            butnGuardarMascota = new Button();
            butnLeerMascota = new Button();
            textRaza = new TextBox();
            textNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            butnNuevaMascota = new Button();
            label1 = new Label();
            textYear = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(178, 73);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(155, 199);
            lstMascotas.TabIndex = 19;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // butnGuardarMascota
            // 
            butnGuardarMascota.Location = new Point(378, 158);
            butnGuardarMascota.Name = "butnGuardarMascota";
            butnGuardarMascota.Size = new Size(98, 44);
            butnGuardarMascota.TabIndex = 18;
            butnGuardarMascota.Text = "Guardar Mascota";
            butnGuardarMascota.UseVisualStyleBackColor = true;
            butnGuardarMascota.Click += butnGuardarMascota_Click;
            // 
            // butnLeerMascota
            // 
            butnLeerMascota.Location = new Point(377, 115);
            butnLeerMascota.Name = "butnLeerMascota";
            butnLeerMascota.Size = new Size(99, 33);
            butnLeerMascota.TabIndex = 17;
            butnLeerMascota.Text = "Leer Mascota";
            butnLeerMascota.UseVisualStyleBackColor = true;
            butnLeerMascota.Click += butnLeerMascota_Click;
            // 
            // textRaza
            // 
            textRaza.Location = new Point(29, 115);
            textRaza.Name = "textRaza";
            textRaza.Size = new Size(100, 23);
            textRaza.TabIndex = 16;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(29, 59);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 97);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 14;
            label3.Text = "Raza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 41);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 13;
            label2.Text = "Nombre";
            // 
            // butnNuevaMascota
            // 
            butnNuevaMascota.Location = new Point(30, 229);
            butnNuevaMascota.Name = "butnNuevaMascota";
            butnNuevaMascota.Size = new Size(99, 33);
            butnNuevaMascota.TabIndex = 12;
            butnNuevaMascota.Text = "Nueva Mascota";
            butnNuevaMascota.UseVisualStyleBackColor = true;
            butnNuevaMascota.Click += butnNuevaMascota_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 43);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 11;
            label1.Text = "Mascotas";
            // 
            // textYear
            // 
            textYear.Location = new Point(29, 175);
            textYear.Name = "textYear";
            textYear.Size = new Size(100, 23);
            textYear.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 157);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 20;
            label4.Text = "Años";
            // 
            // Form24ColeccionXMLMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 305);
            Controls.Add(textYear);
            Controls.Add(label4);
            Controls.Add(lstMascotas);
            Controls.Add(butnGuardarMascota);
            Controls.Add(butnLeerMascota);
            Controls.Add(textRaza);
            Controls.Add(textNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(butnNuevaMascota);
            Controls.Add(label1);
            Name = "Form24ColeccionXMLMascotas";
            Text = "Form24ColeccionXMLMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMascotas;
        private Button butnGuardarMascota;
        private Button butnLeerMascota;
        private TextBox textRaza;
        private TextBox textNombre;
        private Label label3;
        private Label label2;
        private Button butnNuevaMascota;
        private Label label1;
        private TextBox textYear;
        private Label label4;
    }
}