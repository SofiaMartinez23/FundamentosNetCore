namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            btnGenerar = new Button();
            label1 = new Label();
            btnMostrarDatos = new Button();
            lstNumeros = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSumaTotal = new TextBox();
            txtSumaPares = new TextBox();
            txtSumaImpares = new TextBox();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(201, 24);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(106, 30);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "Numeros";
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(201, 60);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(106, 29);
            btnMostrarDatos.TabIndex = 2;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(24, 45);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(102, 169);
            lstNumeros.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 116);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 155);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 5;
            label3.Text = "Pares";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 196);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Impares";
            // 
            // txtSumaTotal
            // 
            txtSumaTotal.Location = new Point(229, 108);
            txtSumaTotal.Name = "txtSumaTotal";
            txtSumaTotal.Size = new Size(100, 23);
            txtSumaTotal.TabIndex = 7;
            // 
            // txtSumaPares
            // 
            txtSumaPares.Location = new Point(229, 147);
            txtSumaPares.Name = "txtSumaPares";
            txtSumaPares.Size = new Size(100, 23);
            txtSumaPares.TabIndex = 8;
            // 
            // txtSumaImpares
            // 
            txtSumaImpares.Location = new Point(229, 188);
            txtSumaImpares.Name = "txtSumaImpares";
            txtSumaImpares.Size = new Size(100, 23);
            txtSumaImpares.TabIndex = 9;
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 250);
            Controls.Add(txtSumaImpares);
            Controls.Add(txtSumaPares);
            Controls.Add(txtSumaTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstNumeros);
            Controls.Add(btnMostrarDatos);
            Controls.Add(label1);
            Controls.Add(btnGenerar);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private Label label1;
        private Button btnMostrarDatos;
        private ListBox lstNumeros;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSumaTotal;
        private TextBox txtSumaPares;
        private TextBox txtSumaImpares;
    }
}