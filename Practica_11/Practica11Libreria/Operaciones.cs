using System;

namespace Practica11Libreria
{
    public class Operaciones
    {
        public int dia, mes, año = 0;

        public string DiferenciaFechas(string fechaAgregada, string fechaAleatoria)
        {
            string diferencia;
            if (!fechaAgregada.Contains("/") || !fechaAleatoria.Contains("/"))
            {
                diferencia = "No";
            }
            else
            {
                string[] fechaAgregadaDividida = fechaAgregada.Split('/');
                string[] fechaAleatoriaDividida = fechaAleatoria.Split('/');
                //Se crea un arreglo de enteros de la longitud de la cadena fechaAgregadaDividida
                int[] FechaAgregadaDivididaEntero = new int[fechaAgregadaDividida.Length];
                int[] FechaAleatoriaDivididaEntero = new int[fechaAleatoriaDividida.Length];
                for (int i = 0; i < 3; i++)
                {
                    FechaAgregadaDivididaEntero[i] = int.Parse(fechaAgregadaDividida[i]);
                    FechaAleatoriaDivididaEntero[i] = int.Parse(fechaAleatoriaDividida[i]);
                }

                if (FechaAgregadaDivididaEntero[2] > FechaAleatoriaDivididaEntero[2])
                {
                    año = FechaAgregadaDivididaEntero[2] - FechaAleatoriaDivididaEntero[2];
                }
                else
                {
                    año = FechaAleatoriaDivididaEntero[2] - FechaAgregadaDivididaEntero[2];
                }

                if (FechaAgregadaDivididaEntero[1] > FechaAleatoriaDivididaEntero[1])
                {
                    mes = FechaAgregadaDivididaEntero[1] - FechaAleatoriaDivididaEntero[1];
                }
                else
                {
                    mes = FechaAleatoriaDivididaEntero[1] - FechaAgregadaDivididaEntero[1];
                }

                if (FechaAgregadaDivididaEntero[0] > FechaAleatoriaDivididaEntero[0])
                {
                    dia = FechaAgregadaDivididaEntero[0] - FechaAleatoriaDivididaEntero[0];
                }
                else
                {
                    dia = FechaAleatoriaDivididaEntero[0] - FechaAgregadaDivididaEntero[0];
                }

                diferencia = "La diferencia entre las fechas es de " + dia.ToString()
                    + " día(s), " + mes.ToString() + " mes(es) y " + año.ToString() + " año(s).";
                mes = 0; dia = 0; año = 0;
            }
            return diferencia;

        }

        public string FechaAleatoria()
        {
            Random Aleatorio = new Random();

            dia = Aleatorio.Next(1, 31);
            mes = Aleatorio.Next(1, 12);
            año = Aleatorio.Next(1998, 2018);

            string fecha = dia.ToString() + "/" + mes.ToString() + "/" + año.ToString();
            mes = 0; dia = 0; año = 0;
            return fecha;
        }

        public string Cumpleanios(string fechaCumpleanios)
        {
            string Fecha = "Tu cumpleaños es el " + fechaCumpleanios;
            return Fecha;
        }


    }
}
