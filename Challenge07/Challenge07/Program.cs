using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge07
{
    public class Program
    {
        static void Main(string[] args)
        {


        }

        public static int[] MaximoYMinimo(int[] matriz)
        {
           /* int[] resultado = new int[2];


            int min = matriz[0];
            int max = matriz[0];
            resultado[0] = matriz[0];
            resultado[1] = matriz[0];


            foreach (var num in matriz)
            {
                if (num < min)
                {
                    resultado[0] = num;
                    min = resultado[0];
                   
                }
                if (num > max)
                {
                    resultado[1] = num;
                    max = resultado[1];
                  
                }

            }*/

            //return resultado;
            return ( new int []{matriz.Min(), matriz.Max()});
        }

    }
}
