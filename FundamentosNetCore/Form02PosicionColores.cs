using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();

        }

        private void buttonChangePosition_Click(object sender, EventArgs e)
        {
            int posicionX = int.Parse(this.textX.Text);
            int posicionY = int.Parse(this.textY.Text);

            this.Left = posicionX;
            this.Top = posicionY;
        }

        private void buttonChangeColor_Click(object sender, EventArgs e)
        {
            int red = int.Parse(this.textRed.Text);
            int green = int.Parse(this.textGreen.Text);
            int blue = int.Parse(this.textBlue.Text);

            if (red < 0 || red > 255)
            {
                MessageBox.Show("El valor rojo debe estar entre 0 y 255", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
            else if( green < 0 || green > 255)
            {
                MessageBox.Show("El valor rojo debe estar entre 0 y 255", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

            }else if (blue < 0 || blue > 255)
            {
                MessageBox.Show("El valor rojo debe estar entre 0 y 255", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
            }
            else
            {
                this.BackColor = Color.FromArgb(red, green, blue);

            }

        }
    }
}
