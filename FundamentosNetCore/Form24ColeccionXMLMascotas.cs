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
    public partial class Form24ColeccionXMLMascotas : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotasList;
        public Form24ColeccionXMLMascotas()
        {
            InitializeComponent();

            this.serializer = new XmlSerializer(typeof(ColeccionMascotas));
            this.mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascota()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }
        private void butnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.textNombre.Text;
            mascota.Raza = this.textRaza.Text;
            mascota.Years = int.Parse(this.textYear.Text);
            this.mascotasList.Add(mascota);
            this.DibujarMascota();

            this.textNombre.Clear();
            this.textRaza.Clear();
            this.textYear.Clear();
        }
        private async void butnGuardarMascota_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("mascotaslist.xml"))
            {
                this.serializer.Serialize(writer, this.mascotasList);
                await writer.FlushAsync();
                writer.Close();

                this.lstMascotas.Items.Clear();
                this.mascotasList.Clear();
            }
        }
        private void butnLeerMascota_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("mascotaslist.xml"))
            {
                this.mascotasList = (ColeccionMascotas)this.serializer.Deserialize(reader);
                reader.Close();

                this.DibujarMascota();
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1) 
            {
                Mascota mascota = this.mascotasList[index];
                this.textNombre.Text = mascota.Nombre;
                this.textRaza.Text = mascota.Raza;
                this.textYear.Text = mascota.Years.ToString();
            }
        }
    }
}
