namespace FundamentosNetCore
{
    partial class Form14Tiendaproductos
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
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEliminarTodo = new Button();
            txtProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lstTienda = new ListBox();
            btnSeleccion = new Button();
            btnEnviarTodo = new Button();
            btnSubir = new Button();
            btnBajar = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(26, 100);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 35);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(26, 141);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 33);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(26, 180);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(100, 33);
            btnEliminarTodo.TabIndex = 2;
            btnEliminarTodo.Text = "Borar todo";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(26, 54);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 25);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 4;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 25);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Tienda";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(177, 54);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(124, 154);
            lstTienda.TabIndex = 6;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(333, 94);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(82, 35);
            btnSeleccion.TabIndex = 7;
            btnSeleccion.Text = "Seleccion";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnEnviarTodo
            // 
            btnEnviarTodo.Location = new Point(333, 153);
            btnEnviarTodo.Name = "btnEnviarTodo";
            btnEnviarTodo.Size = new Size(82, 34);
            btnEnviarTodo.TabIndex = 8;
            btnEnviarTodo.Text = "Todos";
            btnEnviarTodo.UseVisualStyleBackColor = true;
            btnEnviarTodo.Click += btnEnviarTodo_Click;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(612, 94);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(82, 35);
            btnSubir.TabIndex = 9;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(612, 153);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(82, 34);
            btnBajar.TabIndex = 10;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(447, 54);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(123, 154);
            lstAlmacen.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(447, 25);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 12;
            label3.Text = "Almacen";
            // 
            // Form14Tiendaproductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 326);
            Controls.Add(label3);
            Controls.Add(lstAlmacen);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnEnviarTodo);
            Controls.Add(btnSeleccion);
            Controls.Add(lstTienda);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtProducto);
            Controls.Add(btnEliminarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Name = "Form14Tiendaproductos";
            Text = "Form14Tiendaproductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEliminarTodo;
        private TextBox txtProducto;
        private Label label1;
        private Label label2;
        private ListBox lstTienda;
        private Button btnSeleccion;
        private Button btnEnviarTodo;
        private Button btnSubir;
        private Button btnBajar;
        private ListBox lstAlmacen;
        private Label label3;
    }
}