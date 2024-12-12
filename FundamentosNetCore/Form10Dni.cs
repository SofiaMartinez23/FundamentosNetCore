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
    public partial class Form10Dni : Form
    {
        public Form10Dni()
        {
            InitializeComponent();
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            string cadena = this.txtDNI.Text;
            int longitud = cadena.Length;

            if (longitud != 9 || !char.IsLetter(cadena[8]))
            {
                this.lblDNI.Text = "El DNI debe tener 8 números y una letra";
            }
            else
            {
                string numeroStr = cadena.Substring(0, 8);
                
                if (int.TryParse(numeroStr, out int numeroDNI))
                {
                    int resto = numeroDNI % 23;
                    string letras = "TRWAGMYFPDXBNJZSQVHLCKE";
                    char letraCalculada = letras[resto];
                    char letraDNI = cadena[8];

                    if (letraCalculada == letraDNI)
                    {
                        this.lblDNI.Text = $"DNI Correcto: {cadena}";
                    }
                    else
                    {
                        this.lblDNI.Text = $"Incorrecto, su letra es {letraCalculada}";
                    }
                }
                else
                {
                    this.lblDNI.Text = "El número de DNI es inválido.";
                }
            }
        }
    }
}

