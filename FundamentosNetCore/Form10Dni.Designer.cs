namespace FundamentosNetCore
{
    partial class Form10Dni
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
            btnDNI = new Button();
            label1 = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            SuspendLayout();
            // 
            // btnDNI
            // 
            btnDNI.Location = new Point(104, 118);
            btnDNI.Name = "btnDNI";
            btnDNI.Size = new Size(119, 34);
            btnDNI.TabIndex = 0;
            btnDNI.Text = "Validar DNI";
            btnDNI.UseVisualStyleBackColor = true;
            btnDNI.Click += btnDNI_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 40);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzca DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(53, 69);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(230, 23);
            txtDNI.TabIndex = 2;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(53, 175);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 15);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "lblDNI";
            // 
            // Form10Dni
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 244);
            Controls.Add(lblDNI);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Controls.Add(btnDNI);
            Name = "Form10Dni";
            Text = "Form10Dni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDNI;
        private Label label1;
        private TextBox txtDNI;
        private Label lblDNI;
    }
}