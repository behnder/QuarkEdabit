using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge23
{
   public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] MultiplicarArray(int numero, int longitud)
        {
            int[] resultado = new int[longitud];
            

            for (int i = 1; i <= longitud; i++)
            {
                resultado[i - 1] = numero * i;
            }

            return resultado;

        }
    }
}

