using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge26
{
    public class Program
    {
        static void Main(string[] args)
        {

            string cadenaEnviada = "hello world";
          
         

            AlphabeticalOrder(cadenaEnviada);
            Console.ReadKey();
        }

        public static string AlphabeticalOrder(string cadenaEnviada)
        {
            string[] nuevaCadena;
            StringBuilder resultado= new StringBuilder();
            
            nuevaCadena = cadenaEnviada.Split(' ');

            cadenaEnviada = String.Concat(cadenaEnviada.OrderBy(c => c)).Trim();

            int posicionInicio=0;

            foreach (var  i in nuevaCadena)
            {
                resultado.Append(cadenaEnviada.Substring(posicionInicio, i.Length));
                resultado.Append(" ");
                posicionInicio += i.Length;
            }
            return resultado.ToString().Trim();

        }
    }
}
