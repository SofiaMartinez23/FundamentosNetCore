namespace FundamentosNetCore
{
    partial class Form09Isbn
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
            btnValidarISBN = new Button();
            label1 = new Label();
            txtISBN = new TextBox();
            lblISBN = new Label();
            SuspendLayout();
            // 
            // btnValidarISBN
            // 
            btnValidarISBN.Location = new Point(97, 115);
            btnValidarISBN.Name = "btnValidarISBN";
            btnValidarISBN.Size = new Size(123, 30);
            btnValidarISBN.TabIndex = 0;
            btnValidarISBN.Text = "Validar ISBN";
            btnValidarISBN.UseVisualStyleBackColor = true;
            btnValidarISBN.Click += btnValidarISBN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzca ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(43, 67);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(224, 23);
            txtISBN.TabIndex = 2;
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(43, 185);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(45, 15);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "lblISBN";
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 243);
            Controls.Add(lblISBN);
            Controls.Add(txtISBN);
            Controls.Add(label1);
            Controls.Add(btnValidarISBN);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidarISBN;
        private Label label1;
        private TextBox txtISBN;
        private Label lblISBN;
    }
}