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
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidarISBN_Click(object sender, EventArgs e)
        {
            string cadena = this.txtISBN.Text;
            int longitud = cadena.Length;

            if (cadena.Length != 10)
            {
                this.lblISBN.Text = "El ISBN debe ser de 10 caracteres";
            }
            else
            {
                int suma = 0;

                for (int i = 0; i < longitud; i++)
                {
                    char caracter = cadena[i];
                    int numero = int.Parse(caracter.ToString());
                    int operacion = numero * (i + 1);
                    suma += operacion;

                    if (suma % 11 == 0)
                    {
                        this.lblISBN.Text = "ISBN correcto";
                    }
                    else
                    {
                        this.lblISBN.Text = "ISBN incorrecto";

                    }
                }
            
            }
        }
    }
}
