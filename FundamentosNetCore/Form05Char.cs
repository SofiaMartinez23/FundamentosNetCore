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
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                //CONVERTIMOS EL VALOR DE i A CHAR
                char caracter = (char) i;
                if (char.IsLetter(caracter) == true)
                {                   
                    this.txtLetra.Text += caracter;
                }
                else if (char.IsNumber(caracter) == true)
                {
                    this.txtNum.Text += caracter;
                }
                else if (char.IsPunctuation(caracter) == true)
                {
                    this.txtPuntuacion.Text += caracter;
                }
                else if (char.IsSymbol(caracter) == true)
                {
                    this.txtSimbol.Text += caracter;
                }
            }
        }
    }
}
