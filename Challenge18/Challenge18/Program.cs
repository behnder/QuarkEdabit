using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge18
{
   public class Program
    {
        static void Main(string[] args)
        {
          
        }

        public static int FindVowels(string v)
        {
           // return v.Count(c => "aeiouAEIOU".Contains(c));

            int cantidadDeVocales = 0;
            
            foreach (var item in v.ToLower())
            {
                switch (item)
                {
                    case 'a':
                        cantidadDeVocales++;
                        break;
                    case 'e':
                        cantidadDeVocales++;
                        break;
                    case 'i':
                        cantidadDeVocales++;
                        break;
                    case 'o':
                        cantidadDeVocales++;
                        break;   
                    case 'u':
                        cantidadDeVocales++;
                        break;

                }
            }

            return cantidadDeVocales;
        }
    }
}

