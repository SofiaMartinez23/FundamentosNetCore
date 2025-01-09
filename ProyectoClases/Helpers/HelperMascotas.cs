using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoClases.Models;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }
        private string Path;

        public HelperMascotas(string path)
        {
            this.Mascotas = new List<Mascota>();
            this.Path = path;
        }

        //Convertir la colección a String
        private string ConvertirMascotasString()
        {
            //Garfield,Gato@Pluto,Perro
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                string temp = mascota.Nombre + "," + mascota.Raza;
                data += temp + "@";
            }
            data = data.TrimEnd('@');
            return data;
        }

        //Convertir el String del Read a colección mascotas
        private void ConvertirMascotasList(string data)
        {
            //Garfield,Gato@Pluto,Perro
            //LIMPIAMOS LA COLECCION ACTUAL
            this.Mascotas.Clear();
            //SEPARAMOS EL STRING POR CADA MASCOTA @
            string[] datosMascotas = data.Split("@");
            foreach (string stringMascota in datosMascotas)
            {
                //Garfield,Gato
                string[] propiedades = stringMascota.Split(",");
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }

        //NECEITAMOS LEER/ESCRIBIR MASCOTAS DE ESTA COLECCION
        public async Task WriteMascotasAsync()
        {
            //CONVERTIMOS LA COLECCION A STRING
            string data = this.ConvertirMascotasString();
            await HelperFiles.WriteFileAsync(this.Path, data);
        }

        public async Task ReadMascotasAsync()
        {
            //LEEMOS EL FICHERO
            string data = await HelperFiles.ReadFileAsync(this.Path);
            this.ConvertirMascotasList(data);
        }
    }
}