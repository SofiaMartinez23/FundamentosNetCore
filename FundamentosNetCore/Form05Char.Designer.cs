namespace FundamentosNetCore
{
    partial class Form05Char
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
            txtNum = new TextBox();
            label2 = new Label();
            txtLetra = new TextBox();
            txtSimbol = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPuntuacion = new TextBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(36, 41);
            txtNum.Multiline = true;
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(182, 100);
            txtNum.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 23);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "Letras";
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(295, 41);
            txtLetra.Multiline = true;
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(182, 100);
            txtLetra.TabIndex = 3;
            // 
            // txtSimbol
            // 
            txtSimbol.Location = new Point(36, 182);
            txtSimbol.Multiline = true;
            txtSimbol.Name = "txtSimbol";
            txtSimbol.Size = new Size(182, 92);
            txtSimbol.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 164);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Simbolos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(295, 164);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 6;
            label4.Text = "Puntuación";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(295, 182);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(182, 92);
            txtPuntuacion.TabIndex = 7;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(211, 293);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(85, 48);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 353);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSimbol);
            Controls.Add(txtLetra);
            Controls.Add(label2);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Label label2;
        private TextBox txtLetra;
        private TextBox txtSimbol;
        private Label label3;
        private Label label4;
        private TextBox txtPuntuacion;
        private Button btnRun;
    }
}