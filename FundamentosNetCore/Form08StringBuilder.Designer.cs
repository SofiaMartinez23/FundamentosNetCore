namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            label1 = new Label();
            btnInvertString = new Button();
            lblTiempo = new Label();
            btnInvertStringBuilder = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(26, 55);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(355, 194);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 1;
            label1.Text = "Copia el texto para trabajar";
            // 
            // btnInvertString
            // 
            btnInvertString.Location = new Point(26, 312);
            btnInvertString.Name = "btnInvertString";
            btnInvertString.Size = new Size(126, 37);
            btnInvertString.TabIndex = 2;
            btnInvertString.Text = "Invertir String";
            btnInvertString.UseVisualStyleBackColor = true;
            btnInvertString.Click += btnInvertString_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(39, 272);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(60, 15);
            lblTiempo.TabIndex = 3;
            lblTiempo.Text = "lblTiempo";
            // 
            // btnInvertStringBuilder
            // 
            btnInvertStringBuilder.Location = new Point(245, 312);
            btnInvertStringBuilder.Name = "btnInvertStringBuilder";
            btnInvertStringBuilder.Size = new Size(136, 37);
            btnInvertStringBuilder.TabIndex = 4;
            btnInvertStringBuilder.Text = "Invertir StringBuilder";
            btnInvertStringBuilder.UseVisualStyleBackColor = true;
            btnInvertStringBuilder.Click += btnInvertStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 361);
            Controls.Add(btnInvertStringBuilder);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvertString);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Label label1;
        private Button btnInvertString;
        private Label lblTiempo;
        private Button btnInvertStringBuilder;
    }
}