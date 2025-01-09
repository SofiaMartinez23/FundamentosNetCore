using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form23ObjetoXMLMascota : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoXMLMascota()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(List<Mascota>));
        }

        private async void btnGuardarDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtEdad.Text);
            //PARA GUARDAR LOS DATOS DENTRO DE UN FICHERO
            //DEBEMOS UTILIZAR LA CLASE StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }

            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtEdad.Clear();
        }
        private void btnLeerDato_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;

            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota =(Mascota) this.serializer.Deserialize(reader);
                reader.Close();

                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Years.ToString();
            }

        }

    }
}
