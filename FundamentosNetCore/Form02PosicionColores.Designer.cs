namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            textX = new TextBox();
            textY = new TextBox();
            buttonChangePosition = new Button();
            buttonChangeColor = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textRed = new TextBox();
            textGreen = new TextBox();
            textBlue = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Posición X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 76);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Posición Y:";
            // 
            // textX
            // 
            textX.Location = new Point(119, 20);
            textX.Name = "textX";
            textX.Size = new Size(86, 23);
            textX.TabIndex = 2;
            // 
            // textY
            // 
            textY.Location = new Point(119, 73);
            textY.Name = "textY";
            textY.Size = new Size(86, 23);
            textY.TabIndex = 3;
            // 
            // buttonChangePosition
            // 
            buttonChangePosition.Location = new Point(48, 126);
            buttonChangePosition.Name = "buttonChangePosition";
            buttonChangePosition.Size = new Size(137, 35);
            buttonChangePosition.TabIndex = 4;
            buttonChangePosition.Text = "Cambiar Posición";
            buttonChangePosition.UseVisualStyleBackColor = true;
            buttonChangePosition.Click += buttonChangePosition_Click;
            // 
            // buttonChangeColor
            // 
            buttonChangeColor.Location = new Point(302, 173);
            buttonChangeColor.Name = "buttonChangeColor";
            buttonChangeColor.Size = new Size(152, 35);
            buttonChangeColor.TabIndex = 5;
            buttonChangeColor.Text = "Cambiar Color";
            buttonChangeColor.UseVisualStyleBackColor = true;
            buttonChangeColor.Click += buttonChangeColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 23);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 73);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 126);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Azul";
            // 
            // textRed
            // 
            textRed.Location = new Point(359, 20);
            textRed.Name = "textRed";
            textRed.Size = new Size(81, 23);
            textRed.TabIndex = 9;
            // 
            // textGreen
            // 
            textGreen.Location = new Point(364, 70);
            textGreen.Name = "textGreen";
            textGreen.Size = new Size(76, 23);
            textGreen.TabIndex = 10;
            // 
            // textBlue
            // 
            textBlue.Location = new Point(368, 122);
            textBlue.Name = "textBlue";
            textBlue.Size = new Size(72, 23);
            textBlue.TabIndex = 11;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 220);
            Controls.Add(textBlue);
            Controls.Add(textGreen);
            Controls.Add(textRed);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(buttonChangeColor);
            Controls.Add(buttonChangePosition);
            Controls.Add(textY);
            Controls.Add(textX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textX;
        private TextBox textY;
        private Button buttonChangePosition;
        private Button buttonChangeColor;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textRed;
        private TextBox textGreen;
        private TextBox textBlue;
    }
}