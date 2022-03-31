using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge06
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static string ConvertirNumeroAMes(int mes){

            List<string> meses = new List<string>() {
            "Enero", "Febrero","Marzo",  "Abril", "Mayo",
            "Junio","Julio","Agosto","Septiembre",
            "Octubre", "Noviembre", "Diciembre"
            };

            string retorno="";
            if(mes >0 && mes <13)
            {
                retorno = meses[mes - 1];
            }
            
            return retorno;
        }
    }
}
