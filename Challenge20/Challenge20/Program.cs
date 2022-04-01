using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge20
{
  public class Program
    {
        static void Main(string[] args)
        {
        
        }

        public static bool CaracteresIdenticos(string v)
        {
             List<char> aux = new List<char>();
            aux = v.ToList();
          
           return( aux.Distinct().Count() == 1  ? true : false );

          /*  if (v.Length > 1)
            {
                for (int i = 0; i < v.Length -1; i++)
                {
                    if (v[i] != v[i +1])
                    {
                        return false;
                    }
                }
 
            }
            return true;*/
        }
    }
}
//otras soluciones:
/*
 	return str.All(a => a == str[0]);
    return v.Distinct().Count()== 1;
 */
