using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge22
{
   public class Program
    {
        static void Main(string[] args)
        {
     

        }

        public static string ReverseTheCase(string normalWord)
        {

            StringBuilder inverseString = new StringBuilder("");

            foreach (char item in normalWord)
            {
                inverseString.Append(char.IsLower(item) ? item.ToString().ToUpper() : item.ToString().ToLower());
            
               /* if (Char.IsLower(item))
                {
                    inverseString.Append(item.ToString().ToUpper());
                }
                else
                {
                    inverseString.Append(item.ToString().ToLower());
                }*/
            }

            return inverseString.ToString();
        }
    }
}

//	return string.Concat(str.Select(x=>char.IsUpper(x)?char.ToLower(x):char.ToUpper(x)));
    