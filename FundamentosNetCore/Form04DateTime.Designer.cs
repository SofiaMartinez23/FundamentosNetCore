namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFecha = new CheckBox();
            groupBox1 = new GroupBox();
            btnIncremento = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            rdbAnyo = new RadioButton();
            rdbMes = new RadioButton();
            rdbDias = new RadioButton();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(31, 46);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(300, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFecha
            // 
            chkFecha.AutoSize = true;
            chkFecha.Location = new Point(31, 89);
            chkFecha.Name = "chkFecha";
            chkFecha.Size = new Size(149, 19);
            chkFecha.TabIndex = 2;
            chkFecha.Text = "Cambiar formato fecha";
            chkFecha.UseVisualStyleBackColor = true;
            chkFecha.CheckedChanged += chkFecha_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncremento);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rdbAnyo);
            groupBox1.Controls.Add(rdbMes);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(31, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 129);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Caja Incremento";
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(157, 82);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(100, 29);
            btnIncremento.TabIndex = 5;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(172, 52);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(68, 23);
            txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 34);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rdbAnyo
            // 
            rdbAnyo.AutoSize = true;
            rdbAnyo.Location = new Point(17, 82);
            rdbAnyo.Name = "rdbAnyo";
            rdbAnyo.Size = new Size(52, 19);
            rdbAnyo.TabIndex = 2;
            rdbAnyo.TabStop = true;
            rdbAnyo.Text = "Años";
            rdbAnyo.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            rdbMes.AutoSize = true;
            rdbMes.Location = new Point(17, 57);
            rdbMes.Name = "rdbMes";
            rdbMes.Size = new Size(58, 19);
            rdbMes.TabIndex = 1;
            rdbMes.TabStop = true;
            rdbMes.Text = "Meses";
            rdbMes.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(17, 32);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 264);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(31, 293);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(300, 23);
            txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 346);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(chkFecha);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFecha;
        private GroupBox groupBox1;
        private Button btnIncremento;
        private TextBox txtIncremento;
        private Label label2;
        private RadioButton rdbAnyo;
        private RadioButton rdbMes;
        private RadioButton rdbDias;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}