using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto13._3
{
    class Program
    {
        public class Plano
        {
            private float x, y;

            public void CargarPunto()
            {
                Console.Write("Dame el valor del punto x: ");
                x = float.Parse(Console.ReadLine());

                Console.Write("Dame el valor del punto x: ");
                y = float.Parse(Console.ReadLine());
            }

            public void CuadrantePunto()
            {
                if (x < 0 && y > 0)
                {
                    Console.Write("Primer ");
                }
                else if(x > 0 && y > 0)
                {
                    Console.Write("Segundo ");
                }
                else if(x > 0 && y < 0)
                {
                    Console.Write("Tercer ");
                }
                else if(x < 0 && y < 0)
                {
                    Console.Write("Cuarto ");
                }
                else
                {
                    Console.Write("Ningun ");
                }
                Console.WriteLine("cuadrante.");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Plano punto = new Plano();
                punto.CargarPunto();
                punto.CuadrantePunto();
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
