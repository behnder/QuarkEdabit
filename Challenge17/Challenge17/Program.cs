using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge17
{
    public class Program
    {
        static void Main(string[] args)
        {
            ObtenerFactorial(3);
            Console.ReadKey();
        }

        public static int ObtenerFactorial(int v)
        {
            int resultado = 1;

            for (int i = 0; i < v; i++) {

                if (i == 0)
                {

                    resultado += i * (v - i);
                }
                else
                {
                    resultado += resultado * (v - i);
                }



              
            }
            return resultado;

        }
    }
}
