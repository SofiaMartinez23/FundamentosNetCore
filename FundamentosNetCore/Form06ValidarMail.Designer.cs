namespace FundamentosNetCore
{
    partial class Form06ValidarMail
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
            txtMail = new TextBox();
            btnValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduzca un mail";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(44, 54);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(216, 23);
            txtMail.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(44, 97);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(216, 30);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar Email";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(44, 176);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 230);
            Controls.Add(lblResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtMail);
            Controls.Add(label1);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMail;
        private Button btnValidar;
        private Label lblResultado;
    }
}