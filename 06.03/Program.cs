using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] celi_cisla = new int[10];


            for (int i = 0; i <= 10; i++)
            {
                celi_cisla[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= 10; i++)
            {
                if (celi_cisla[i] % 2 == 0)
                {
                    Console.WriteLine(celi_cisla);
                }
                else
                {
                    Console.WriteLine("X");
                }

            }
        }
    }
}
