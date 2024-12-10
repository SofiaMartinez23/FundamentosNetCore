namespace FundamentosNetCore
{
    partial class Form01SumaNumeros
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
            label2 = new Label();
            txtNum1 = new TextBox();
            btnSuma = new Button();
            txtNum2 = new TextBox();
            result = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 129);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero 2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(56, 63);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(134, 34);
            txtNum1.TabIndex = 2;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(266, 129);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(93, 46);
            btnSuma.TabIndex = 3;
            btnSuma.Text = "Sumar";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(56, 159);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(134, 34);
            txtNum2.TabIndex = 4;
            // 
            // result
            // 
            result.AutoSize = true;
            result.ForeColor = Color.MidnightBlue;
            result.Location = new Point(56, 254);
            result.Name = "result";
            result.Size = new Size(72, 15);
            result.TabIndex = 5;
            result.Text = "lblResultado";
            // 
            // Form01SumaNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 331);
            Controls.Add(result);
            Controls.Add(txtNum2);
            Controls.Add(btnSuma);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form01SumaNumeros";
            Text = "Form01SumaNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private Button btnSuma;
        private TextBox txtNum2;
        private Label result;
    }
}