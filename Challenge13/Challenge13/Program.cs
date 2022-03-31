using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge13
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] MultiplicarPorLongitudDeArray(int[] enviado)
        {
            int[] retorno=  new int[enviado.Length] ;

            for(int i=0; i< enviado.Length; i++)
            {
                retorno[i]= enviado[i] * enviado.Length;
            }
            return retorno;
        }
    }
}
