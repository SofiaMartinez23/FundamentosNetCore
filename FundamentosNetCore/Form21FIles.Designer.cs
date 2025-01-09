namespace FundamentosNetCore
{
    partial class Form21FIles
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
            textContenido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            butNuevoNombre = new Button();
            butReadFiel = new Button();
            butWriteFile = new Button();
            textNombre = new TextBox();
            lstNombres = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textContenido
            // 
            textContenido.Location = new Point(15, 38);
            textContenido.Multiline = true;
            textContenido.Name = "textContenido";
            textContenido.Size = new Size(200, 164);
            textContenido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 20);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // butNuevoNombre
            // 
            butNuevoNombre.Location = new Point(254, 67);
            butNuevoNombre.Name = "butNuevoNombre";
            butNuevoNombre.Size = new Size(100, 36);
            butNuevoNombre.TabIndex = 3;
            butNuevoNombre.Text = "Nuevo Nombre";
            butNuevoNombre.UseVisualStyleBackColor = true;
            butNuevoNombre.Click += butNuevoNombre_Click;
            // 
            // butReadFiel
            // 
            butReadFiel.Location = new Point(254, 118);
            butReadFiel.Name = "butReadFiel";
            butReadFiel.Size = new Size(100, 34);
            butReadFiel.TabIndex = 4;
            butReadFiel.Text = "Read Fiel";
            butReadFiel.UseVisualStyleBackColor = true;
            butReadFiel.Click += butReadFiel_Click;
            // 
            // butWriteFile
            // 
            butWriteFile.Location = new Point(254, 168);
            butWriteFile.Name = "butWriteFile";
            butWriteFile.Size = new Size(100, 34);
            butWriteFile.TabIndex = 5;
            butWriteFile.Text = "Write File";
            butWriteFile.UseVisualStyleBackColor = true;
            butWriteFile.Click += butWriteFile_Click;
            // 
            // textNombre
            // 
            textNombre.Location = new Point(254, 38);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 6;
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(396, 38);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(142, 169);
            lstNombres.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(396, 20);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "Nombres";
            // 
            // Form21FIles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 245);
            Controls.Add(label3);
            Controls.Add(lstNombres);
            Controls.Add(textNombre);
            Controls.Add(butWriteFile);
            Controls.Add(butReadFiel);
            Controls.Add(butNuevoNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textContenido);
            Name = "Form21FIles";
            Text = "Form21FIles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textContenido;
        private Label label1;
        private Label label2;
        private Button butNuevoNombre;
        private Button butReadFiel;
        private Button butWriteFile;
        private TextBox textNombre;
        private ListBox lstNombres;
        private Label label3;
    }
}