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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNum.Text;
            int suma = 0;

            for (int i = 0; i < textoNumeros.Length; i++)
            {
                //RECOGEMOS CADA UNO DE LOS CARACTERES
                char caracter = textoNumeros[i];
                //CONVERTIMOS EL CARACTER A NUMERO
                //int num = int.Parse(caracter.ToString());
                int num = Convert.ToInt32(caracter.ToString());
                suma += num;
            }

            this.lblResultado.Text = "La suma es " + suma;
        }
    }
}
