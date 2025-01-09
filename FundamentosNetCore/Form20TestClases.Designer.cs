namespace FundamentosNetCore
{
    partial class Form20TextClases
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
            button1 = new Button();
            lstClases = new ListBox();
            btnEmpleado = new Button();
            btnDirector = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Clases";
            // 
            // button1
            // 
            button1.Location = new Point(27, 184);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Persona";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(27, 53);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(192, 109);
            lstClases.TabIndex = 2;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(144, 184);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(75, 23);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnDirector
            // 
            btnDirector.Location = new Point(260, 184);
            btnDirector.Name = "btnDirector";
            btnDirector.Size = new Size(75, 23);
            btnDirector.TabIndex = 4;
            btnDirector.Text = "Director";
            btnDirector.UseVisualStyleBackColor = true;
            btnDirector.Click += btnDirector_Click;
            // 
            // Form20TextClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 259);
            Controls.Add(btnDirector);
            Controls.Add(btnEmpleado);
            Controls.Add(lstClases);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form20TextClases";
            Text = "Form20TextClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListBox lstClases;
        private Button btnEmpleado;
        private Button btnDirector;
    }
}