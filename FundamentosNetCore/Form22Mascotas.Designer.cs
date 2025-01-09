namespace FundamentosNetCore
{
    partial class Form22Mascotas
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
            label1 = new Label();
            butnNuevaMascota = new Button();
            label2 = new Label();
            label3 = new Label();
            textNombre = new TextBox();
            textRaza = new TextBox();
            butnLeerMascota = new Button();
            butnGuardarMascota = new Button();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 22);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Mascotas";
            // 
            // butnNuevaMascota
            // 
            butnNuevaMascota.Location = new Point(224, 125);
            butnNuevaMascota.Name = "butnNuevaMascota";
            butnNuevaMascota.Size = new Size(99, 33);
            butnNuevaMascota.TabIndex = 2;
            butnNuevaMascota.Text = "Nueva Mascota";
            butnNuevaMascota.UseVisualStyleBackColor = true;
            butnNuevaMascota.Click += butnNuevaMascota_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 22);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 78);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 5;
            label3.Text = "Raza";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(224, 40);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 6;
            // 
            // textRaza
            // 
            textRaza.Location = new Point(224, 96);
            textRaza.Name = "textRaza";
            textRaza.Size = new Size(100, 23);
            textRaza.TabIndex = 7;
            // 
            // butnLeerMascota
            // 
            butnLeerMascota.Location = new Point(223, 164);
            butnLeerMascota.Name = "butnLeerMascota";
            butnLeerMascota.Size = new Size(99, 33);
            butnLeerMascota.TabIndex = 8;
            butnLeerMascota.Text = "Leer Mascota";
            butnLeerMascota.UseVisualStyleBackColor = true;
            butnLeerMascota.Click += butnLeerMascota_Click;
            // 
            // butnGuardarMascota
            // 
            butnGuardarMascota.Location = new Point(224, 207);
            butnGuardarMascota.Name = "butnGuardarMascota";
            butnGuardarMascota.Size = new Size(98, 44);
            butnGuardarMascota.TabIndex = 9;
            butnGuardarMascota.Text = "Guardar Mascota";
            butnGuardarMascota.UseVisualStyleBackColor = true;
            butnGuardarMascota.Click += butnGuardarMascota_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(32, 52);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(155, 199);
            lstMascotas.TabIndex = 10;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 349);
            Controls.Add(lstMascotas);
            Controls.Add(butnGuardarMascota);
            Controls.Add(butnLeerMascota);
            Controls.Add(textRaza);
            Controls.Add(textNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(butnNuevaMascota);
            Controls.Add(label1);
            Name = "Form22Mascotas";
            Text = "Form22Mascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button butnNuevaMascota;
        private Label label2;
        private Label label3;
        private TextBox textNombre;
        private TextBox textRaza;
        private Button butnLeerMascota;
        private Button butnGuardarMascota;
        private ListBox lstMascotas;
    }
}