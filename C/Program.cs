using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, cir, area;
            r = 0;

            Console.WriteLine("Enter the radius:  ");
            r = Convert.ToDouble(Console.ReadLine());

            cir = 2 * Math.PI * r;
            area = Math.PI * (r * r);

            Console.WriteLine("The Circumference is: " + cir);
            Console.WriteLine("The Area is: " + area);
            Console.ReadLine();

        }
    }
}
