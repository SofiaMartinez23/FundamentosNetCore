using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public enum TipoGenero { Masculino, Femenino }
    public enum Paises { España, Francia, Alemania, Andorra, Tabarnia }

    public class Persona
    {
      public Persona()
        {
            Debug.WriteLine("Constructor PERSONA vacio");
            this.Domicilio = new Direccion("", "");
        }

        public Persona(string nombre, string apellidos)
        {
            Debug.WriteLine("Constructor PERSONA vacio");
            this.Nombre = nombre;
            this.Apellido = apellidos;
        }
    

  
        #region PROPIEDADES

        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set
            {
                Random random = new Random();
                int alert = random.Next(1, 20);
                this._DescripcionThis = "Descripcion " + alert;
            }
        }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioValido { get; set; }
        private TipoGenero _Genero;
        public Paises Nacionalidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        private int _Edad;
        #endregion

        #region METODO
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Masculino && value != TipoGenero.Femenino)
                {
                    throw new Exception("Valor de genero incorrecto");
                }
            }
        }
        public int Edad
        {
            get { return this._Edad; }
            set
            {
                //DEBEMOS COMPROBAR EL VALOR DE LA EDAD 
                //QUE VIENE EN value
                if (value < 0)
                {
                    //SI NOS DAN UN VALOR INCORRECTO
                    //ERROR SILENCIOSO
                    //this._Edad = 0;
                    //LANZAMOS LA EXCEPCION
                    throw new Exception("La edad no puede ser negatriva");
                    //this._Edad = 0;

                }
                else
                {
                    //TODO CORRECTO
                    this._Edad = value;
                }
            }
        }

        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public string GetNombreCompletoDelReves()
        {
            return this.Apellido + " " + this.Nombre;
        }

        public string GetNombreCompleto(bool mayusculas)
        {
            if (mayusculas == true)
            {
                return (this.Nombre + " " + this.Apellido).ToUpper();

            }
            else
            {
                return (this.Nombre + " " + this.Apellido).ToLower();

            }
        }

        #endregion

    }
}
