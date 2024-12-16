namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            lblIndexSeleccionado = new Label();
            lblItemSeleccionado = new Label();
            btnDeleteAll = new Button();
            txtNuevoElemento = new TextBox();
            label2 = new Label();
            btnDelete = new Button();
            btnInsert = new Button();
            lstElementos = new ListBox();
            label1 = new Label();
            btnSeleccionado = new Button();
            SuspendLayout();
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(55, 291);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(119, 15);
            lblIndexSeleccionado.TabIndex = 17;
            lblIndexSeleccionado.Text = "lblIndexSeleccionado";
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(55, 257);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(114, 15);
            lblItemSeleccionado.TabIndex = 16;
            lblItemSeleccionado.Text = "lblItemSeleccionado";
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(260, 198);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(150, 38);
            btnDeleteAll.TabIndex = 15;
            btnDeleteAll.Text = "Borrar Todo";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(260, 37);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(150, 23);
            txtNuevoElemento.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 10);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 13;
            label2.Text = "Nuevo elemento";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(260, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 38);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(260, 77);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(150, 39);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(38, 37);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 199);
            lstElementos.TabIndex = 10;
            lstElementos.Tag = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 10);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnSeleccionado
            // 
            btnSeleccionado.Location = new Point(260, 257);
            btnSeleccionado.Name = "btnSeleccionado";
            btnSeleccionado.Size = new Size(150, 39);
            btnSeleccionado.TabIndex = 18;
            btnSeleccionado.Text = "Seleccionado";
            btnSeleccionado.UseVisualStyleBackColor = true;
            btnSeleccionado.Click += btnSeleccionado_Click;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 317);
            Controls.Add(btnSeleccionado);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(btnDeleteAll);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndexSeleccionado;
        private Label lblItemSeleccionado;
        private Button btnDeleteAll;
        private TextBox txtNuevoElemento;
        private Label label2;
        private Button btnDelete;
        private Button btnInsert;
        private ListBox lstElementos;
        private Label label1;
        private Button btnSeleccionado;
    }
}