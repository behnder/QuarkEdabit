using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge11
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int SumaAbsoluta(int[] enviado)
        {
            int resultado = 0;
            foreach (var c in enviado)
            {

                resultado = (c < 0) ? (resultado += (c * -1)) : (resultado += c);

            }
            return resultado;
        }
    }
}
