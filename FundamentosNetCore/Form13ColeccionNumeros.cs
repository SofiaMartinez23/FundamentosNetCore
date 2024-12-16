using System;
using System.Linq;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                int numeroAleatorio = random.Next(1, 101);
                this.lstNumeros.Items.Add(numeroAleatorio);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach (var item in lstNumeros.Items)
            {
                int numero = (int)item;
                sumaTotal += numero;

                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }

            txtSumaTotal.Text = sumaTotal.ToString();
            txtSumaPares.Text = sumaPares.ToString();
            txtSumaImpares.Text = sumaImpares.ToString();
        }
    }
}
