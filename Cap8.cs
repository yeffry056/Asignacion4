using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion4
{
    public class Cap8
    {

        public static string Fecha()
        {
            string fecha;
            fecha = String.Format("{0:h:mm tt  yyyy/d/M}", DateTime.Now);
            return fecha;
        }
        public static string[] Ordenar(string cadena1, string cadena2)
        {
            char aux;
            char [] cadena  = cadena1.ToArray();
            string []cadenasOrdenadas = new string[2];
            for(int i = 0; i < cadena.Length; i++)
            {
                for(int j =i+1; j <cadena.Length; j++)
                {
                    if(cadena[i] > cadena[j])
                    {
                        aux = cadena[i];
                        cadena[i] = cadena[j];
                        cadena[j] = aux;
                    }
                }
            }
            cadenasOrdenadas[0] = new string(cadena);
            cadena = cadena2.ToArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = i + 1; j < cadena.Length; j++)
                {
                    if (cadena[i] > cadena[j])
                    {
                        aux = cadena[i];
                        cadena[i] = cadena[j];
                        cadena[j] = aux;
                    }
                }
            }
            cadenasOrdenadas[1] = new string(cadena);

            return cadenasOrdenadas;
        }
    }
}
