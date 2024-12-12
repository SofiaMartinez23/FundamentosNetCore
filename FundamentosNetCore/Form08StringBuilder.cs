using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            krono.Start();//INICIA EL PROCESO DEL CRONOMETRO

            for (int i = 0; i < longitud; i++)
            {
                //RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            krono.Stop();
            //EL OBJETO krono CONTIENE UNA SERIE DE PROPIEDADES
            //PARA SABER EL TIEMPO QUE HA PASADO
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds
                + ", Milisegundos: " + krono.Elapsed.Microseconds;

            this.txtTexto.Text = cadena;
        }

        private void btnInvertStringBuilder_Click(object sender, EventArgs e)
        {
            //StringBuilder se utiliza para grandes cantidades de texto
            Stopwatch krono = new Stopwatch();
            StringBuilder cadena = new StringBuilder();
            //PARA AÑADIR CONTENIDO AL STRINGBUILDER
            cadena.Append(this.txtTexto.Text);
            int longitud = cadena.Length;
            krono.Start();

            for (int i = 0; i < longitud; i++)
            {
                char letra = cadena[longitud - 1];
                cadena = cadena.Remove(longitud - 1, 1);
                cadena = cadena.Insert(i, letra);
            }

            krono.Stop();

            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds
                + ", Milisegundo: " + krono.Elapsed.Milliseconds;

            this.txtTexto.Text = cadena.ToString();
        }

    }
}
