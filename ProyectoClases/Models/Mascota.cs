using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProyectoClases.Models
{
    public class Mascota
    {
        [JsonPropertyName("Nombre")]
        public string Nombre { get; set; }
        [JsonPropertyName("Raza")]
        public string Raza { get; set; }
        [JsonPropertyName("Years")]
        public int Years { get; set; }
    }
}
