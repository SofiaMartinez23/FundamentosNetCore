using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor DIRECTOR vacio");
            this.SalarioMinimo += 200;
            
        }

        //METODO SOBREESCRITO
        public new int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() Director");
            int vacacionesEmpleado = base.GetDiasVacaciones();
            return vacacionesEmpleado + 8;
        }


        public int GetDiasVacaciones(int extras)
        {
            return this.GetDiasVacaciones() + extras;
        }
    }
}
