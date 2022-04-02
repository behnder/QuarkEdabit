using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21
{
   public class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 4, 2, 7, 1 };

            Console.WriteLine( a.Max());
            Console.ReadKey();
        }

        public static double[] FindLargestnumberOfArray(double[][] enviado)
        {
            double[] resultado = new double[enviado.Length];
            for (int i = 0; i < enviado.Length; i++)
            {
                resultado[i] = enviado[i].Max();
            }

            return resultado;
            
        }
    }
}
