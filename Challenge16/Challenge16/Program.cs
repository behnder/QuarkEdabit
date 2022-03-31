using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge16
{
    public class Program
    {
        public static void Main(string[] args)
        {
          /*  string str = "0123456789";
            byte[] ASCIIvalues = Encoding.ASCII.GetBytes(str);
            foreach (var value in ASCIIvalues)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine(string.CompareOrdinal("21","44"));
            Console.ReadLine();*/
        }

        public static string StringNumeroMenor(string  cadena1, string cadena2)
        {
          

            return ((string.CompareOrdinal(cadena1, cadena2) <0) ? cadena1 : cadena2);
         
        }
    }
}
