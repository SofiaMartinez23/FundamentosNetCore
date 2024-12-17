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
    public partial class Form17ListDelegados : Form
    {
        //DECLARAMOS UNA VARIABLE CONTADOR
        int contador;
        //DECLARAMOS UNA LISTA DE BOTONES
        List<Button> botones;

        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0; //las inicializaciones siempre dentro del constructor
            this.botones = new List<Button>();

            //this.button1.Click += BotonPulsado;
            //this.button2.Click += BotonPulsado;
            //this.button3.Click += BotonPulsado;
            //this.button4.Click += BotonPulsado;
            //this.button5.Click += BotonPulsado;
            //this.button6.Click += BotonPulsado;

            //SI ALMACENAMOS TODOS LOS BOTONES DENTRO
            //Deactivate LA COLECCION, PODEMOS HACER LA ACCION
            //DELEGADA CON UN FOREACH
            /*this.botones.Add(this.button1);
            this.botones.Add(this.button2);
            this.botones.Add(this.button3);
            this.botones.Add(this.button4);
            this.botones.Add(this.button5);
            this.botones.Add(this.button6);*/
            this.contador = 0;
            this.botones = new List<Button>();

            foreach (Control miControl in this.Controls)
            {
                //boton.Click += BotonPulsado;
                if (miControl is Button)
                {
                    this.botones.Add((Button)miControl);
                }
            }
            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;   
            }
        }

        //QUIERO QUE AL PULSAR CUALQUIER BOTON EN ESTE METODO
        //CAMBIE DE COLOR EL BOTON PULSADO
        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();
            //sender es el objeto que realiza la llamada
            Button miBoton = (Button)sender;
            miBoton.BackColor = Color.Yellow;
        }
    }
}