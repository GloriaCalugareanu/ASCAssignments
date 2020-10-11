using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legea_lui_Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            String Consol;
            double cateori;
            while (true)
            {
                //Legea lui Moore presupune faptul ca puterea de calcul se dubleaza la fiecare 18 luni, iar pretul ramane acelasi

                Console.WriteLine("Introduceti un numar n");
                Consol = Console.ReadLine();
                if (double.TryParse(Consol, out cateori))
                {
                    double ani;
                    ani = 1.5 * Math.Log(cateori, 2);
                    Console.WriteLine("In {1} ani, puterea de calcul se va mari de {0} ori", cateori, ani);

                    break;
                }
                else
                {
                    Console.WriteLine("Introduceti un alt numar");
                    Console.ReadKey();
                }


            }
        }
    }
}
