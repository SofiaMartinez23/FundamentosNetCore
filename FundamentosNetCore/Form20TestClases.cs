using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TextClases : Form
    {
        public Form20TextClases()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellido = "Navidad";
            persona.Edad = 25;
            persona.Genero = TipoGenero.Femenino;
            this.lstClases.Items.Add("Indizada " + persona[0]);
            this.lstClases.Items.Add("Indizada " + persona[33]);
            persona.Nacionalidad = Paises.Andorra;

            persona.Domicilio.Calle = "Oficina principal de Correos";
            persona.Domicilio.Ciudad = "Napapiiri Finlandia";
            persona.Domicilio.CodigoPostal = 96930;
            this.lstClases.Items.Add(
                "Direccion: " + persona.Domicilio.Calle
                + ", " + persona.Domicilio.Ciudad
                + ", " + persona.Domicilio.CodigoPostal);
            this.lstClases.Items.Add("Nombre: " + persona.GetNombreCompleto());
            this.lstClases.Items.Add("Edad: " + persona.Edad);
            this.lstClases.Items.Add("Genero: " + persona.Genero);
            this.lstClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
            this.lstClases.Items.Add("Nombre Mayus: " + persona.GetNombreCompleto());
            this.lstClases.Items.Add("Nombre Minus: " + persona.GetNombreCompleto());

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = "Empleado";
            empleado.Apellido = "Empleado";
            this.lstClases.Items.Add(empleado.GetNombreCompleto());
            this.lstClases.Items.Add("Vacaciones empleado "  
                + empleado.GetDiasVacaciones());
            this.lstClases.Items.Add("Salario empleado "
                + empleado.GetSalarioMinimo());
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellido = "Director";
            this.lstClases.Items.Add(dire.GetNombreCompleto());
            this.lstClases.Items.Add("Vacaciones dire " 
                + dire.GetDiasVacaciones());
            this.lstClases.Items.Add("Salario dire "
                + dire.GetSalarioMinimo());
        }
    }
}
