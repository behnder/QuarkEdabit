using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Challenge14

{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int HammingDistance(string cadena1, string cadena2)
        {
        int contador = 0;

            if (cadena1.Length == cadena2.Length)
            {
                for (int i = 0; i < cadena1.Length; i++)
                {
                       contador +=( !cadena1[i].Equals(cadena2[i])) ? 1 : 0;
              
                }
            }
        return contador;
        }
    }
}
