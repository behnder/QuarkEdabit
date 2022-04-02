using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge25
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] enviado = { 5, 1, 4, 3, 2 };
            ConsecutiveNumbers(enviado);
            Console.ReadLine();
        }

        public static bool ConsecutiveNumbers(int[] enviado)
        {
            List<int> enviadoLista = enviado.ToList();

            enviadoLista.Sort();
            bool retornoResultado = true;

            retornoResultado = ( enviadoLista.Distinct().Count() == enviadoLista.Count() ? true: false);
            
            if (retornoResultado)
            {
                for (int i = 0; i < enviadoLista.Count - 1; i++)
                {
                    if (enviadoLista[i] != enviadoLista[i + 1] - 1)
                    {
                        retornoResultado= false;
                    }
                }

            }

            return retornoResultado;

        }
    }
}

