namespace FundamentosNetCore
{
    partial class Form07SumarNumeros
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
            btnSuma = new Button();
            txtNum = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce número";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(37, 99);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(128, 28);
            btnSuma.TabIndex = 1;
            btnSuma.Text = "Sumar números";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(37, 61);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(154, 23);
            txtNum.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(37, 160);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form07SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 236);
            Controls.Add(lblResultado);
            Controls.Add(txtNum);
            Controls.Add(btnSuma);
            Controls.Add(label1);
            Name = "Form07SumarNumeros";
            Text = "Form07SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSuma;
        private TextBox txtNum;
        private Label lblResultado;
    }
}