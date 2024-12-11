using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtMail.Text;

            if (!email.Contains("@"))
            {
                MessageBox.Show("El correo debe contener un '@'.");
                this.lblResultado.Text = "Email Incorrecto";
            }

            else if (email.StartsWith("@") || email.EndsWith("@"))
            {
                MessageBox.Show("El correo no puede comenzar ni terminar con '@'.");
                this.lblResultado.Text = "Email Incorrecto";
            }

            else if (email.Split('@').Length - 1 != 1)
            {
                MessageBox.Show("El correo no puede contener más de un '@'.");
                this.lblResultado.Text = "Email Incorrecto";
            }

            else
            {
                string[] partes = email.Split('@');
                string dominio = partes[1];

                if (!dominio.Contains("."))
                {
                    MessageBox.Show("Debe haber al menos un punto después del '@'.");
                    this.lblResultado.Text = "Email Incorrecto";
                }
                else
                {
                    string[] dominioPartes = dominio.Split('.');
                    string extension = dominioPartes[dominioPartes.Length - 1];

                    if (extension.Length < 2 || extension.Length > 4)
                    {
                        this.lblResultado.Text = "Email Incorrecto";
                    }
                    else
                    {
                        this.lblResultado.Text = email;
                    }
                }
            }
        }
    }
}
    

