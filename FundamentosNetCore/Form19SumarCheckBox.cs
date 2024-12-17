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
    public partial class Form19SumarCheckBox : Form
    {
        List<CheckBox> checkBoxes;
        int suma;

        public Form19SumarCheckBox()
        {
            InitializeComponent();
            this.checkBoxes = new List<CheckBox>();
            this.suma = 0;

            foreach (CheckBox checkBox in this.panel1.Controls)
            {
                this.checkBoxes.Add(checkBox);
                checkBox.Click += SumarNumeros;
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        { 
            CheckBox checkBox = (CheckBox)sender;
            int numero = int.Parse(checkBox.Text);

            if (checkBox.Checked)
            {
                this.suma += numero;
            }
            else
            {
                this.suma -= numero;
            }

            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();

            foreach (CheckBox checkBox in this.checkBoxes)
            {
                int numAleat = random.Next(1, 99);
                checkBox.Text = numAleat.ToString();
                checkBox.Checked = false; 
            }
        }
    }
}
