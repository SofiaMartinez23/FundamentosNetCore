namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            lstElementos = new ListBox();
            btnInsert = new Button();
            btnDelete = new Button();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            btnDeleteAll = new Button();
            lblItemSeleccionado = new Label();
            lblIndexSeleccionado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 29);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(29, 56);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 199);
            lstElementos.TabIndex = 1;
            lstElementos.Tag = "";
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(251, 96);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(150, 39);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(251, 158);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 38);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 29);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 4;
            label2.Text = "Nuevo elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(251, 56);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(150, 23);
            txtNuevoElemento.TabIndex = 5;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(251, 217);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(150, 38);
            btnDeleteAll.TabIndex = 6;
            btnDeleteAll.Text = "Borrar Todo";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(46, 276);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(114, 15);
            lblItemSeleccionado.TabIndex = 7;
            lblItemSeleccionado.Text = "lblItemSeleccionado";
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(46, 310);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(119, 15);
            lblIndexSeleccionado.TabIndex = 8;
            lblIndexSeleccionado.Text = "lblIndexSeleccionado";
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 334);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnDeleteAll);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionGrafica";
            Text = "IstElementos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Button btnInsert;
        private Button btnDelete;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Button btnDeleteAll;
        private Label lblItemSeleccionado;
        private Label lblIndexSeleccionado;
    }
}