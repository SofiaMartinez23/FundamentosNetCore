using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form22Mascotas : Form
    {
        private HelperMascotas helper;
        public Form22Mascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas("mascotas.txt");
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void butnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.textNombre.Text;
            mascota.Raza = this.textRaza.Text;

            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();

        }

        private async void butnLeerMascota_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private async void butnGuardarMascota_Click(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            this.lstMascotas.Items.Clear();
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;

            if(index != -1){
                Mascota mascota = this.helper.Mascotas[index];
                this.textNombre.Text = mascota.Nombre;
                this.textRaza.Text = mascota.Raza;
            }
        }
    }
}
