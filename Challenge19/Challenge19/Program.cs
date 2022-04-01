using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge19
{
  public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] OrdenarNumerosAsc(int[] enviado)
        {

            if (enviado.Length == 0)
            {
                return new int[0];
            }
            //Se dejan las líneas antes del refactor
            //int[] arrayOrdenado = new int[enviado.Length];
            //List<int> enviado2 = new List<int>();
            List<int> enviado2 = enviado.ToList();
            enviado2.Sort();
            //int [] arrayOrdenado = enviado2.ToArray();
            return enviado2.ToArray();

        }
    }
}

//otras soluciones
//  Array.Sort(enviado);
// return enviado.OrderBy(x => x).ToArray();
