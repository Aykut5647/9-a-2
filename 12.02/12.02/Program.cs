using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko dushi shte vivejdash?: ");
            int hora = int.Parse(Console.ReadLine());
            string[] ime = new string[hora];
            double[] djobni = new double[hora];

            Console.WriteLine("Vivejdane na danni: ");
            for (int i = 0; i < hora; i++)
            {
                Console.WriteLine("ime");
                ime[i] = Console.ReadLine();
                Console.WriteLine("djobni");
                djobni[i] = int.Parse(Console.ReadLine()); Console.WriteLine("ime");
            }
            Console.WriteLine("Izhod 1: ");
            for (int i = 0; i < hora; i++)
            {
                Console.WriteLine(ime[hora] + "ima" + djobni[hora] + "lv");
            }
            Console.WriteLine("Izhod 2: ");
            if (djobni &> "7")
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Izhod 3: ");
            if (hora==0)
            {
                int banica =-2;
                Console.WriteLine(ime[hora] + banica);
            }
        }
    }
}
