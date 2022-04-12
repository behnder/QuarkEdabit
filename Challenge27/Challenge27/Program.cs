using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge27
{
    public class Program
    {
        static void Main(string[] args)
        {         
        }

        public static string PilishString(string stringRecibido)
        {
            List<string> retorno = new List<string>();

            var arregloLongitudesPalabras = "314159265358979".Select(digit => int.Parse(digit.ToString()));
            int inicioSubstring = 0;

            for (int i = 0; i < arregloLongitudesPalabras.Count(); i++)
            {
                if (inicioSubstring < stringRecibido.Length)
                {
                    if ((stringRecibido.Length - inicioSubstring) >= arregloLongitudesPalabras.ElementAt(i))
                    {
                        retorno.Add(stringRecibido.Substring(inicioSubstring, arregloLongitudesPalabras.ElementAt(i)));
                        inicioSubstring += arregloLongitudesPalabras.ElementAt(i);
                    }
                    else
                    {
                        StringBuilder aux = new StringBuilder();
                        aux.Append(stringRecibido.Substring(inicioSubstring));

                        for (int j = 0; j < (arregloLongitudesPalabras.ElementAt(i) - stringRecibido.Substring(inicioSubstring).Length); j++)
                        {
                            aux.Append(stringRecibido.Last());
                        }
                        retorno.Add(aux.ToString());
                        break;
                    }
                }
            }          
            return string.Join(" ", retorno);
        }
    }
}
