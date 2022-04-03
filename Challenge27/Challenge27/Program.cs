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

        public static string PilishString(string recibida)
        {
            List<string> retorno = new List<string>();
            string result = "314159265358979";
            var arreglolongitud = result.Select(digit => int.Parse(digit.ToString()));
            int inicio = 0;

            for (int i = 0; i < arreglolongitud.Count(); i++)
            {
                if (inicio < recibida.Length)
                {
                    if ((recibida.Length - inicio) >= arreglolongitud.ElementAt(i))
                    {
                        retorno.Add(recibida.Substring(inicio, arreglolongitud.ElementAt(i)));
                        inicio += arreglolongitud.ElementAt(i);
                    }
                    else
                    {
                        StringBuilder aux = new StringBuilder();
                        aux.Append(recibida.Substring(inicio));

                        for (int j = 0; j < (arreglolongitud.ElementAt(i) - recibida.Substring(inicio).Length); j++)
                        {
                            aux.Append(recibida.Last());
                        }
                        retorno.Add(aux.ToString());
                        break;
                    }
                }
            }          
            return string.Join(" ", retorno.ToArray());
        }
    }
}
