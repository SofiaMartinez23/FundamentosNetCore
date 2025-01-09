using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado: Persona
    {
        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.SalarioMinimo = 1400;
            this.GetDiasVacaciones(); 

        }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() Empelado");
            return 22;
        }
        public Empleado(string nombre, string apellidos) 
        { 

            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.Nombre = nombre;
            this.Apellido = apellidos;
        }
    }
}
