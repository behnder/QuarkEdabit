using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge24
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        
        public static int[] TrackRobot(string[] enviado)
        {
            int[] resultado = new int[2] { 0, 0};
            string movement;
            int count;

            foreach (var x in enviado) {
                string[] aux = x.Split(' ');
                movement = aux[0];
                count= Int32.Parse(aux[1]);

                switch (movement)
                {
                    case "right":
                        resultado[0] += count;
                        break;
                    case "left":
                        resultado[0] -= count;
                        break;
                    case "up":
                        resultado[1] += count;
                        break;
                    case "down":
                        resultado[1] -= count;
                        break;               

                }              
                
            }

            return resultado;
        }
    }
}
