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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.texDia.Text);
            int mes = int.Parse(this.textMes.Text);
            int anyo = int.Parse(this.textAnyo.Text);

            if(mes == 1)
            {
                mes = 13;
                anyo -= 1;
            }else if(mes == 2)
            {
                mes = 14;
                anyo--;
            }

            int multiMes = ((mes + 1) * 3) / 5;
            int divAnyo1 = anyo / 4;
            int divAnyo2 = anyo / 100;
            int divAnyo3 = anyo / 400;

            int suma = dia + (mes * 2) + anyo + multiMes + divAnyo1 - divAnyo2 + divAnyo3 + 2;
            int divSum = suma / 7;
            int rest = suma - (divSum * 7);

            if (rest == 0)
            {
                this.lblDiaSemana.Text = "Sabado";
            }
            else if(rest == 1)
            {
                this.lblDiaSemana.Text = "Domingo";
            }
            else if (rest == 2)
            {
                this.lblDiaSemana.Text = "Lunes";
            }
            else if (rest == 3)
            {
                this.lblDiaSemana.Text = "Martes";
            }
            else if (rest == 4)
            {
                this.lblDiaSemana.Text = "Miercoles";
            }
            else if (rest == 5)
            {
                this.lblDiaSemana.Text = "Jueves";
            }
            else
            {
                this.lblDiaSemana.Text = "Viernes";

            }




        }
    }
}
