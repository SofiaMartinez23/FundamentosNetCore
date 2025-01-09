using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ProyectoClases.Models;


namespace FundamentosNetCore
{
    public partial class Form25ColeccionMascotasJSON : Form
    {

        ColeccionMascotas mascotasList;


        public Form25ColeccionMascotasJSON()
        {
            InitializeComponent();
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
            Mascota mascota = new Mascota
            {
                Nombre = this.textNombre.Text,
                Raza = this.textRaza.Text,
                Years = int.Parse(this.textYear.Text)
            };
            this.mascotasList.Add(mascota);
            this.DibujarMascota();

            this.textNombre.Clear();
            this.textRaza.Clear();
            this.textYear.Clear();

        }

        private async void butnLeerMascota_Click(object sender, EventArgs e)
        {
            string fileName = "mascotaslist.json";
            string jsonString = await File.ReadAllTextAsync(fileName);
            this.mascotasList = JsonConvert.DeserializeObject<List<Mascota>>(jsonString);
            this.DibujarMascota();

        }


        private async void butnGuardarMascota_Click(object sender, EventArgs e)
        {
            string fileName = "mascotaslist.json";
            await using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, this.mascotasList);

            this.lstMascotas.Items.Clear();
            this.mascotasList.Clear();
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


