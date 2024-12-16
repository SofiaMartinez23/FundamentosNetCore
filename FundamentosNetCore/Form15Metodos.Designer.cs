namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            lblResultado = new Label();
            txtOnlyNum = new TextBox();
            txtOnlyLetter = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblRaton = new Label();
            SuspendLayout();
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(42, 119);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(90, 33);
            btnDobleValor.TabIndex = 0;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(42, 158);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(90, 50);
            btnDobleReferencia.TabIndex = 1;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(42, 214);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(90, 50);
            btnObjetoReferencia.TabIndex = 2;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(42, 42);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Número";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(42, 88);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "lblResultado";
            // 
            // txtOnlyNum
            // 
            txtOnlyNum.Location = new Point(264, 42);
            txtOnlyNum.Name = "txtOnlyNum";
            txtOnlyNum.Size = new Size(167, 23);
            txtOnlyNum.TabIndex = 6;
            txtOnlyNum.KeyPress += txtOnlyNum_KeyPress;
            // 
            // txtOnlyLetter
            // 
            txtOnlyLetter.Location = new Point(264, 119);
            txtOnlyLetter.Name = "txtOnlyLetter";
            txtOnlyLetter.Size = new Size(167, 23);
            txtOnlyLetter.TabIndex = 7;
            txtOnlyLetter.KeyPress += txtOnlyLetter_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 15);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 8;
            label2.Text = "Solo numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 88);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Solo letras";
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.InactiveCaption;
            lblRaton.Location = new Point(264, 157);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(176, 107);
            lblRaton.TabIndex = 10;
            lblRaton.Text = "lblRaton";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 310);
            Controls.Add(lblRaton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtOnlyLetter);
            Controls.Add(txtOnlyNum);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private TextBox txtNumero;
        private Label label1;
        private Label lblResultado;
        private TextBox txtOnlyNum;
        private TextBox txtOnlyLetter;
        private Label label2;
        private Label label3;
        private Label lblRaton;
    }
}