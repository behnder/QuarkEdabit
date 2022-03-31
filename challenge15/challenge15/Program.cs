using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge15
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string IntercambiarNombres(string cadena)
        {
            string[] subCadena = cadena.Split(' ');           

           return string.Concat(subCadena[1], " ", subCadena[0]);

        }
    }
}


