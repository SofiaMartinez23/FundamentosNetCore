using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ProyectoClases.Helpers;

namespace FundamentosNetCore
{
    public partial class Form21FIles : Form
    {
        private string Path { get; set; }
        private HelperFiles helper;
        public Form21FIles()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
            //CUANDO HABLAMOS DE RUTAS DE FICHEROS, CON CARACTERES
            //ESPECIALES'\' TENEMOS DOS POSISBILIDADES
            //C:\carpeta\files1.txt
            //1) UTILIZAR DOBLE CONTRABARRA '\\'
            this.Path = "C:\\carpeta\\file1.txt";
            //2) INDICAR QUE EL STRING SERA LITERAL
            this.Path = @"C:\carpeta\file1.txt";
            this.Path = "file1.txt";

            string mes = HelperFiles.GetMesActual();
            DateTime fecha = DateTime.Now;
        }

        private void butNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.textNombre.Text);
            this.textNombre.SelectAll();
            this.textNombre.Focus();
        }

        public string GetNombreListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void butWriteFile_Click(object sender, EventArgs e)
        {

            string data = this.GetNombreListBox();
            await HelperFiles.WriteFileAsync(this.Path, data);
            MessageBox.Show("Datos guardados");

        }

        private async void butReadFiel_Click(object sender, EventArgs e)
        {
            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.RellenarListBox(data);
            this.textContenido.Text = data;
        }

        public void RellenarListBox(string nombres)
        {
            string[] data = nombres.Split(",");
            this.lstNombres.Items.Clear();
            foreach (string name in data)
            {
                this.lstNombres.Items.Add(nombres);
            }

        }
    }
}
