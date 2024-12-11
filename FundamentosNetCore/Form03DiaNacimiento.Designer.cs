namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            texDia = new TextBox();
            textMes = new TextBox();
            textAnyo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // texDia
            // 
            texDia.Location = new Point(55, 54);
            texDia.Name = "texDia";
            texDia.Size = new Size(100, 23);
            texDia.TabIndex = 0;
            // 
            // textMes
            // 
            textMes.Location = new Point(55, 130);
            textMes.Name = "textMes";
            textMes.Size = new Size(100, 23);
            textMes.TabIndex = 1;
            // 
            // textAnyo
            // 
            textAnyo.Location = new Point(55, 212);
            textAnyo.Name = "textAnyo";
            textAnyo.Size = new Size(100, 23);
            textAnyo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 24);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 3;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 102);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 4;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 183);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Año";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(221, 51);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(130, 66);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular dia nacimiento";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(252, 183);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(79, 15);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "lblDiaSemana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 273);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textAnyo);
            Controls.Add(textMes);
            Controls.Add(texDia);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texDia;
        private TextBox textMes;
        private TextBox textAnyo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label lblDiaSemana;
    }
}