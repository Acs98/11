using System;


namespace Practica11Libreria
{
    public class LecturaDatos
    {
        private int edad;
        private string nombre;
        private string ciudad;

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value <= 0 || value > 100)
                {
                    edad = -1;
                }
                else
                {
                    edad = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value == "")
                {
                    nombre = "No nombre";
                }
                else
                {
                    nombre = value;
                }
            }
        }


        public string Ciudad
        {
            get
            {
                return ciudad;
            }
            set
            {
                if (value == "")
                {
                    ciudad = "No ciudad";
                }
                else
                {
                    ciudad = value;
                }
            }
        }

        public LecturaDatos(string Nombre, string Ciudad, int Edad)
        {
            this.Nombre = Nombre;
            this.Ciudad = Ciudad;
            this.Edad = Edad;
        }

        public string QuienEres(string Nombre, string Ciudad, int Edad)
        {
            string Eres = "Tu nombre es " + Nombre + ", vives en " + Ciudad + " y tienes " + Edad.ToString() + " de edad";
            return Eres;
        }


    }
}
