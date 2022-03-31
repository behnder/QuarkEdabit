using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge05
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( ConvertirAniosADias(-2));
           Console.ReadLine();
        }

        public static int ConvertirAniosADias(int anios)
        {
            int retorno = 0;

            if (anios >= 0)
            {
                retorno = anios * 365;

            }
            return retorno;


        }
    }
}
